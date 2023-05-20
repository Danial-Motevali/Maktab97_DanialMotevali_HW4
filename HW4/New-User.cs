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
        int finalId = 1;
        
        public void AddingUser(string name , long phoneNumber, DateTime birthDay)
        {    
            StreamWriter dataFile = new StreamWriter(path);
            NewUserModal model1 = new NewUserModal();
            date = birthDay.ToString("dd/MM/yyyy");

            newid(finalId);

            model1.id = finalId;
            model1.name = name;
            model1.phoneNumber = phoneNumber;
            model1.birthDay = date;
            
            var toJson = JsonConvert.SerializeObject(model1);
            dataFile.Write(toJson);
            dataFile.Close();
        }
        public int newid(int id)
        {
            StreamReader readFile = new StreamReader(path);
            var filetoJson = JsonConvert.DeserializeObject<NewUserModal>(readFile.ReadLine());

            while (filetoJson != null)
            {
                if(filetoJson.id == id)
                {
                    readFile.Close();
                    return id++;
                }
            }
            readFile.Close();
            return id;
        }
    }
}
