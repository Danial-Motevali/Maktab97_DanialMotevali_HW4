namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do 
            {
                Console.WriteLine("--1.New user/2.Show list/3.Updata user/4.Delete user--");
                input = Convert.ToInt32(Console.ReadLine());

                if(input == 1)
                {

                }else if(input == 2)
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