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
            StreamWriter w = new StreamWriter(path);
            w.Close();
            foreach (var line in readFile)
            {
                var search = JsonConvert.DeserializeObject<NewUserModal>(line);
                if(search.id == id)
                {
                    continue;
                }
                var final = JsonConvert.SerializeObject(search);
                File.AppendAllText(path, final + Environment.NewLine);
            }
        }
    }
}
