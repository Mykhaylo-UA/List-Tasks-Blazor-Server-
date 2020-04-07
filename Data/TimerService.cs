using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TaskLists.Data
{
    public class TimerService : IHostedService, IDisposable
    {
        private ApplicationDbContext _context;
        private Timer _timer;
        public IServiceScopeFactory _serviceScopeFactory;
        private DateTime sendTime;

        public TimerService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
            sendTime = DateTime.Now;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
           
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(20));

            return Task.CompletedTask;
        }
        private async void DoWork(object state)
        {
            DateTime dateTimeNow = DateTime.Now;
            TelegramBotClient client = new TelegramBotClient("1226539117:AAEPwcnmeJtJHKxH7wqHTKEP0nPVQFn9C5s");
            if (sendTime.Minute != dateTimeNow.Minute)
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    List<User> users = await _context.Users.Include(fol => fol.Folders).ThenInclude(it => it.Items).ToListAsync();
                    foreach (User user in users)
                    {
                        foreach (Folder folder in user.Folders)
                        {
                            foreach (Item item in folder.Items.Where(i => i.IsNotificationTelegram == true))
                            {
                                DateTime dateTime = DateTime.Now;
                                if (item.Date.Date == dateTime.Date.Date)
                                {
                                    if (item.Time.Hour == dateTime.Hour && item.Time.Minute == dateTime.Minute)
                                    {
                                        if (user.TelegramChatId != null)
                                        {
                                            await client.SendTextMessageAsync(user.TelegramChatId, item.Text);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                sendTime = dateTimeNow;
            }
        }
    
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
