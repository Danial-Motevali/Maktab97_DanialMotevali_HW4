using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class Delete_User
    {
        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        public void delete(int id)
        {
            int i = 0;
            var readFile = File.ReadAllLines(path);
            string[] strings = new string[readFile.Length];

            foreach (var line in readFile)
            {
                var j = JsonConvert.DeserializeObject(line);
                strings[i] = j.ToString();
                i++;
            }
            
        }
    }
}
