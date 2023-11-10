using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryApp.Models
{
    public class Music
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Artist { get; set; }
        public string? Album { get; set; }
        public int Year { get; set; }
        public string? Image { get; set; }
        public string[]? Tags { get; set; }
        public bool IsActive;
        public bool IsHome;
    }
}