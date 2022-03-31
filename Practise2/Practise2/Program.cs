using System;
using Practise2.Models;

namespace Practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Group group1 = new Group();
            Console.WriteLine("Yeni User yaradin");
            Console.WriteLine("User name daxil edin");
            user1.FullName = Console.ReadLine();
            Console.WriteLine("Email daxil edin");
            user1.Email = Console.ReadLine();

            do
            {
                Console.WriteLine("Password daxil edin");
                user1.Password = Console.ReadLine();

            } while (!user1.PasswordChecker(user1.Password));

            do
            {
                Console.WriteLine("Bir secim edin");
                Console.WriteLine("1 - Show Info");
                Console.WriteLine("2 - Create new group");
                int key = 0;
                switch (key)
                {
                    case 1:
                        user1.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("Yeni qrup yaradin");
                        do
                        {
                            Console.WriteLine("Qrupun nomresini daxil edin");
                            group1.GroupNo = Console.ReadLine();

                        } while (!group1.CheckGroupNo(group1.GroupNo));

                        Console.WriteLine("Telebe sayini daxil edin");
                        group1.StudentLimit = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        break;
                }

            } while (true);



        }
    }
}
