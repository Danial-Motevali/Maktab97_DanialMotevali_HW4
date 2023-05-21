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
            //string date = string.Empty;
            //date = birth.ToString("dd/MM/yyyy");
            //NewUserModal model1 = new NewUserModal();

            //var linse = File.ReadAllLines(path);

            //foreach (var line in linse)
            //{
            //    var fileToJson = JsonConvert.DeserializeObject<NewUserModal>(line);
            //    if (fileToJson.id == id)
            //    {
            //        fileToJson.id = id;
            //        fileToJson.name = name;
            //        fileToJson.phoneNumber = phone;
            //        fileToJson.birthDay = date;
            //        fileToJson.time = DateTime.Now.ToString();
            //    }
            //}

            //var jsonToFile = JsonConvert.SerializeObject(fileToJson);
            //File.AppendAllText(path, jsonToFile + Environment.NewLine);

            return true;
        }
    }
}
