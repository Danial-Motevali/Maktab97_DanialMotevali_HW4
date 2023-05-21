using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class ShowTheList
    {
        
        public string[] ShowList(string path)
        {   
            int id = 1;
            var lines = File.ReadAllLines(path); 
            object[] list = new object[lines.Length];
            string[] objectLine = new string[lines.Length];
            
            foreach (string line in lines)
            {
                var speficLine = JsonConvert.DeserializeObject<NewUserModal>(line);
                if( speficLine.id == id)
                {
                    list.Append(speficLine);
                    id++;
                }
            }
            var sortedList = JsonConvert.SerializeObject(list);
            StreamWriter sw = new StreamWriter(path);
            sw.Write(sortedList);
            sw.Close();

            return objectLine;
        }
    }
}
