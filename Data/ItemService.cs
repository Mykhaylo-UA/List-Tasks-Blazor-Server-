using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using TLSchema;
using TLSharp;

namespace TaskLists.Data
{
    public class ItemService
    {
        private readonly ApplicationDbContext _appcontext;
        public ItemService(ApplicationDbContext appcontext)
        {
            _appcontext = appcontext;
        }

        public IEnumerable<Folder> GetFolders(string user)
        {
            if (user == null) return null;
            User us = _appcontext.Users.Include(f=> f.Folders).FirstOrDefault(u => u.Email == user);
            return us.Folders;
        }

        public async Task<bool> AddFolder(Folder folder, string user)
        {
            if (user == null) return false;
            User us = await _appcontext.Users.FirstOrDefaultAsync(u => u.Email == user);
            folder.UserId = us.Id;
            await _appcontext.Folders.AddAsync(folder);
            await _appcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteFolder(Folder folder)
        {
            if (folder == null) return false;
            _appcontext.Folders.Remove(folder);
            await _appcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EditFolder(Folder folder)
        {
            if (folder == null) return false;
            _appcontext.Update(folder);
            await _appcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddItem(Item item, int folderId)
        {
            if (item == null) return false;
            item.FolderId = folderId;
            await _appcontext.Items.AddAsync(item);
            await _appcontext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteItem(Item item)
        {
            if (item == null) return false;
            _appcontext.Items.Remove(item);
            await _appcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EditItem(Item item)
        {
            if (item == null) return false;
            _appcontext.Update(item);
            await _appcontext.SaveChangesAsync();
            return true;
        }

        public async Task<Folder> GetFolderAndItemsAsync(int folderId, string user)
        {
            if (user == null) return null;
            User us = await _appcontext.Users.FirstOrDefaultAsync(u => u.Email == user);

            Folder folder = await _appcontext.Folders.Include(folder => folder.Items).FirstOrDefaultAsync(folder => folder.Id == folderId);

            if (folder.UserId == us.Id)
            {
                return folder;
            }
            else return new Folder() { Id=-1 };
        }

        public async Task<bool> SendNotification(string user)
        {
            TelegramBotClient client = new TelegramBotClient("1226539117:AAEPwcnmeJtJHKxH7wqHTKEP0nPVQFn9C5s");
            if (user == null) return false;
            User us = await _appcontext.Users.Include(fol => fol.Folders).ThenInclude(it => it.Items).FirstOrDefaultAsync(u => u.Email == user);

            foreach(Folder folder in us.Folders)
            {
                foreach(Item item in folder.Items.Where(i => i.IsNotificationTelegram == true))
                {
                    DateTime dateTime = DateTime.Now;
                    if(item.Date.Date == dateTime.Date.Date)
                    {
                        if(item.Time.Hour == dateTime.Hour && item.Time.Minute == dateTime.Minute)
                        {
                            await client.SendTextMessageAsync(us.TelegramChatId, item.Text);
                        }
                    }
                }
            }
            return true;
        }
    }
}
