using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class IsValid
    {
        string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        public bool newUser (long phonenumber, DateTime birthday) 
        {
            if(phonenumber > 99999999999 || phonenumber < 999999999)
            {
                throw new PhoneNumberException("not valid phone number");
            }
            if(birthday > DateTime.Now)
            {
                throw new BirthDayException("you dont born yet");
            }
            return true;
        }
        public bool updata (int id)
        {
            int count = 0;
            var jsonId = File.ReadAllLines(path);
            foreach(var line in jsonId)
            {
                var specficId = JsonConvert.DeserializeObject<NewUserModal>(line);
                if(specficId.id != id) 
                {
                    count++;
                }
                if(count == jsonId.Length) 
                {
                    throw new UpDataException("not user found");
                }
            }
            return true;
        }
    }
}
