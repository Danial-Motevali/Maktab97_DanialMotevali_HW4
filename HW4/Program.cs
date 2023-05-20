namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string name = string.Empty;
            long phoneNumber = 0;
            DateTime bithDay;
            New_User user = new New_User();
            do 
            {
                Console.WriteLine("--1.New user/2.Show list/3.Updata user/4.Delete user--");
                input = Convert.ToInt32(Console.ReadLine());

                if(input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--you are now adding a new user--");
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Phone-Number: ");
                    phoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Birth-Day: ");
                    bithDay = Convert.ToDateTime(Console.ReadLine());
                    user.AddingUser(name, phoneNumber, bithDay);

                }
                else if(input == 2)
                {

                }else if (input == 3)
                {

                }else if (input == 4)
                {

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