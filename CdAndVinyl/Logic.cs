using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace CdAndVinyl
{
    public class Logic
    {
        public List<Medium> collection = new List<Medium>();
        string folder_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");
        string file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "jsonSaved.json");


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

        public void new_medium(Medium m)
        {
            collection.Add(m);
            json_save();
        }

        void json_save()
        {
            Directory.CreateDirectory(folder_path);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(collection, options);
            File.WriteAllText(file_path, json);

        }


    }
}
