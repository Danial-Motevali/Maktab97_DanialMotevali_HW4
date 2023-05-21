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
        object[] list;
        int id = 1;
        public object[] ShowList(string path)
        {
            var lines = File.ReadAllLines(path);
            
            foreach (string line in lines)
            {
                var speficLine = JsonConvert.DeserializeObject<NewUserModal>(line);
                if( speficLine.id == id)
                {
                    list.Append(speficLine);
                    this.id++;
                }
            }

            return list;
        }
    }
}
