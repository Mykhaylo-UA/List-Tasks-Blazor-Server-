using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLists.Data
{
    public class Item
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set;}
        public Color Color { get; set; } = Color.White;
        public bool IsNotificationTelegram { get; set; }

        [NotMapped]
        public StatusModel StatusModel { get; set; } = StatusModel.Static;
        public int FolderId { get; set; }
        public Folder Folder { get; set; }
    }
}
