using System;
using System.Collections.Generic;
using System.Text;

namespace CdAndVinyl
{
    public class Logic
    {
        public bool userinput_bool(string user_choice_title, string user_choice_artist)
        {

            if (int.TryParse(user_choice_title, out int a))
            {
                return false;
            }

            if (int.TryParse(user_choice_artist, out int b))
            {
                return false;
            }


            if (user_choice_title.Length > 50 || user_choice_artist.Length > 50)
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        public string mediuminput_stringreturn(string user_choice_mediumtype)
        {
            string user_choice_mediumtype_lower = user_choice_mediumtype.ToLower();

            if (user_choice_mediumtype_lower != "cd" && user_choice_mediumtype_lower != "vinyl")
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
