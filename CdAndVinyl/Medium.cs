using System;
using System.Collections.Generic;
using System.Text;

namespace CdAndVinyl
{
    public class Medium
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Type { get; set; }

        public Medium(string? title, string? artist, string? type)
        {
            Title = title;
            Artist = artist;
            Type = type;
        }
    }
}
