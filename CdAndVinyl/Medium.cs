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


    }

    public class Logic
    {
        public bool userinput_truefalse(string user_choice)
        {
            if (int.TryParse(user_choice, out int number))
            {
                return false;
            }

            if (user_choice.Length > 20)
            {
                return false;
            }

            else
            {
                return true;
            }
            
        }
    }
}
