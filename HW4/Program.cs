﻿using System.ComponentModel.Design;
using System.Threading.Channels;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
            var f = File.Open(path, FileMode.OpenOrCreate);
            f.Close();
            
            int input = 0;
            int idForDelete = 0;
            int idForUpdata = 0;
            string forUpdata;
            string newForUpdata;
            string inputShowList;
            string name = string.Empty;
            long phoneNumber = 0;
            DateTime bithDay;

            New_User user = new New_User();
            ShowTheList showList = new ShowTheList();
            Delete_User delete_User = new Delete_User();
            UpData upData = new UpData();
            IsValid valid = new IsValid();

            do
            {
                Console.Clear();
                Console.WriteLine("--1.New user/2.Show list--");
                Console.Write("-");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--you are now adding a new user--");
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Phone-Number: ");
                    phoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Birth-Day: ");
                    bithDay = Convert.ToDateTime(Console.ReadLine());
                    var validornot = valid.newUser(phoneNumber, bithDay);
                    if (validornot == true)
                    {

                        var addingStutse = user.AddingUser(name, phoneNumber, bithDay);
                        if (addingStutse == true)
                        {
                            Console.WriteLine("you have successfully add new user");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Unsuccessful to add user");
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        continue;
                    }
                
                   
                    
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--your are now see the existing list--\n");
                    var list = showList.ShowList(path);
                    if (list == null)
                    {
                        Console.WriteLine("its empty");
                        Thread.Sleep(2000);
                        continue;
                    }
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("\n--1.updata the user/2.delete the user/press any key to exite");
                    inputShowList = Console.ReadLine();
                    if(inputShowList == "1")
                    {
                        Console.Write("wich Id: ");
                        idForUpdata = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Phone-Number: ");
                        phoneNumber = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Birth-Day: ");
                        bithDay = Convert.ToDateTime(Console.ReadLine());
                        var validup = valid.updata(idForUpdata);
                        if(validup == true)
                        {
                            var status = upData.upData(idForUpdata, name, phoneNumber, bithDay);
                            if (status == true)
                            {
                                Console.WriteLine("you updata you user-name succesfuly");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("you cont updata you user-name");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("you cont updata you user");
                        }
                        
                    }
                    else if(inputShowList == "2")
                    {
                        Console.Write("wich Id: ");
                        idForDelete = Convert.ToInt32(Console.ReadLine());
                        delete_User.delete(idForDelete);
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Not invalid make sure you pick from menu with number");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);
        }
    }
}