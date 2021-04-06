using System;
using System.Collections.Generic;

namespace MyMusicStore.Models
{
    public class Artist
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Album> Albums { get; set; }
    }
}
