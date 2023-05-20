using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;

namespace HW4
{
    public class New_User
    {
        string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.txt";
        string date = string.Empty;
        int finalId = 1;
        
        public void AddingUser(string name , long phoneNumber, DateTime birthDay)
        {    
            date = birthDay.ToString("dd/MM/yyyy");
            NewUserModal model1 = new NewUserModal();


            model1.id = newid(finalId);
            model1.name = name;
            model1.phoneNumber = phoneNumber;
            model1.birthDay = date;



        }
        public int newid(int Id)
        {
            var f = File.ReadAllLines(path);
            foreach (string specificLine in f)
            {
                var g = JsonConvert.DeserializeObject<NewUserModal>(specificLine);
                if(g.id == Id)
                {
                    Id++;
                }
                
            }

            return Id;
        }
    }
}
