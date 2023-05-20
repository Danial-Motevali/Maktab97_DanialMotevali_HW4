using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4
{
    public class New_User
    {
        string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        string date = string.Empty;
        
        public void AddingUser(string name , long phoneNumber, DateTime birthDay)
        {
            FileStream datafile = new FileStream(path);
            date = birthDay.ToString("dd/MM/yyyy");
            
        }
    }
}
