using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HW4
{
    public class New_User
    {
        string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.txt";
        string date = string.Empty;
        
        public void AddingUser(string name , long phoneNumber, DateTime birthDay)
        {
            date = birthDay.ToString("dd/MM/yyyy");
            
            NewUserModal model1 = new NewUserModal();
            model1.name = name;
            model1.phoneNumber = phoneNumber;
            model1.birthDay = date;

            var addtofile = JsonConvert.SerializeObject(model1);
            StreamWriter dataFile = new StreamWriter(path);

            dataFile.Write(addtofile);
            dataFile.Close();
        }
    }
}
