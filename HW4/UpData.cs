using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class UpData
    {
        string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        public bool upData(int id, string name,long phone,DateTime birth)
        {
            Delete_User delete = new Delete_User();
            delete.delete(id);

            New_User newUser = new New_User();
            newUser.AddingUser(name, phone, birth);

            return true;
        }
    }
}
