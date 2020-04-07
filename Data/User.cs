using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLists.Data
{
    public class User : IdentityUser
    {
        public List<Folder> Folders { get; set; }
        public string TelegramName { get; set; }
        public string TelegramChatId { get; set; }
        public User()
        {
            Folders = new List<Folder>();
        }
    }
}
