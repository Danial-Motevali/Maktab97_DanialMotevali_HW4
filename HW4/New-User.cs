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
using System.Data;

namespace HW4
{
    public class New_User
    {
        string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        string date = string.Empty;
        int finalId = 1;

        public bool AddingUser(string name, long phoneNumber, DateTime birthDay)
        {
            date = birthDay.ToString("dd/MM/yyyy");
            NewUserModal model1 = new NewUserModal();

            model1.id = newid(finalId);
            model1.name = name;
            model1.phoneNumber = phoneNumber;
            model1.birthDay = date;
            model1.time = DateTime.Now.ToString();

            var jsonToFile = JsonConvert.SerializeObject(model1);

            File.AppendAllText(path, jsonToFile + Environment.NewLine);

            return true;
        }
        public int newid(int Id)
        {
            var pathLins = File.ReadAllLines(path);
            foreach (string specificLine in pathLins)
            {
                var fileToJson = JsonConvert.DeserializeObject<NewUserModal>(specificLine);
                if(specificLine == "" && fileToJson.id != Id)
                {
                    return Id;
                }else if (fileToJson.id == Id)
                {
                    Id++;
                }
            }
            return Id;
        }
    }
}
