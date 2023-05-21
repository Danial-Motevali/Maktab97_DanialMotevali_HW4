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
            string name = string.Empty;
            long phoneNumber = 0;
            DateTime bithDay;
            New_User user = new New_User();
            ShowTheList showList = new ShowTheList();

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
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--your are now see the existing list--\n");
                    var list = showList.ShowList(path);
                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\npress eny key to contnue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("its empty");
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