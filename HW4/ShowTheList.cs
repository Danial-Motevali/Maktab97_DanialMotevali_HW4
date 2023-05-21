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
        
        public object[] ShowList(string path)
        {   
            int id = 1;
            var lines = File.ReadAllLines(path); 
            String[] list = new String[lines.Length];
            
            foreach (string line in lines)
            {
                var speficLine = JsonConvert.DeserializeObject<NewUserModal>(line);
                if( speficLine.id == id)
                {
                    list.Append(speficLine.ToString());
                    id++;
                }
            }
            return list;
        }
    }
}
