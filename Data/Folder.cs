using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace TaskLists.Data
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public List<Item> Items {get;set;}

        public string UserId { get; set; }
        public User User { get; set; }

        [NotMapped]
        public StatusModel StatusModel { get; set; } = StatusModel.Static;

        public Folder()
        {
            Items = new List<Item>();
        }
    }

    public enum Color
    {
        White,
        Black,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple,
        Pink
    }
}
