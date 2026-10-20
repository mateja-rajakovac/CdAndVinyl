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

    public class Logic
    {
        public bool userinput_bool(string user_choice)
        {
            if (int.TryParse(user_choice, out int number))
            {
                return false;
            }

            if (user_choice.Length > 50)
            {
                return false;
            }

            else
            {
                return true;
            }
            
        }

        public string mediuminput_bool(string user_choice)
        {
            string user_choice_lower = user_choice.ToLower();

            if (user_choice_lower != "cd" && user_choice_lower != "vinyl")
            {
                return "INVALID";
            }

            else
            {
                return "";
            }

        }
    }
}
