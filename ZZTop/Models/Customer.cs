using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZZTop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavGenre { get; set; }
        public string FavSong { get; set; }
        public string ImagePath { get;  set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}," +
                   $"{nameof(FavGenre)}: {FavGenre}, {nameof(FavGenre)}: {FavSong}, {nameof(ImagePath)}: {ImagePath}";
        }

    }

}
