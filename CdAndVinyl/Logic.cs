using System;
using System.Collections.Generic;
using System.Text;

namespace CdAndVinyl
{
    public class Logic
    {
        public bool check_space(string type, string artist, string title)
        {
            List<string> user_input = new List<string>() {type, artist, title};

            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(artist) || string.IsNullOrWhiteSpace(title))
                {
                    return true;
                }

            if (user_input.Any(s => s.Length >= 50))
                {
                    return true;
                }

            else
            {
                return false;
            }
        }

        public bool check_mediumtype(string type)
        {
            List<string> medium_type = new List<string>() { "cd", "vinyl" };
            string type_lower = type.ToLower();

            if (medium_type.Contains(type_lower))
            {
                return true;
            }

            else
            {
                return false;
            }

        }


    }
}
