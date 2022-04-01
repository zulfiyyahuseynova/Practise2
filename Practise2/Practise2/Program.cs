using System;
using Practise2.Models;

namespace Practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Aysu Memmedova", 90);
            Student stu2 = new Student("Ayse Uluxanova", 95);
            Student stu3 = new Student("Zulfiyye Huseynova", 80);
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
                if (!user1.PasswordChecker(user1.Password))
                {
                    Console.WriteLine("Password uygun deyil");
                }

            } while (!user1.PasswordChecker(user1.Password));

            int key;
            do
            {
                Console.WriteLine("Bir secim edin");
                Console.WriteLine("1 - Show Info");
                Console.WriteLine("2 - Create new group");
                key = Convert.ToInt32(Console.ReadLine());
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
                            if (!group1.CheckGroupNo(group1.GroupNo))
                            {
                                Console.WriteLine("Qrup nomresi uygun deyil");
                            }

                        } while (!group1.CheckGroupNo(group1.GroupNo));

                        do
                        {
                            Console.WriteLine("Telebe sayini daxil edin");
                            group1.StudentLimit = Convert.ToInt32(Console.ReadLine());
                            if (group1.StudentLimit < 5 || group1.StudentLimit > 18)
                            {
                                Console.WriteLine("Telebe sayi minimum 5, maximum 18 ola biler");
                            }

                        } while (group1.StudentLimit < 5 || group1.StudentLimit > 18);

                        int choice;
                        do
                        {
                            Console.WriteLine("Bir secim edin\n" +
                                "1 - Show all students\n" +
                                "2 - Get student by id\n" +
                                "3 - Add student\n" +
                                "0 - Quit");
                            choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    group1.GetAllStudents();
                                    break;
                                case 2:
                                    Console.WriteLine("Id daxil edin");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    group1.GetStudent(id);
                                    break;
                                case 3:
                                    group1.AddStudent(stu1);
                                    Console.WriteLine("Telebe elave olundu");
                                    break;
                                case 0:
                                    Console.WriteLine("Proqram sonlandi");
                                    break;
                            }

                        } while (choice!=0);
                        break;

                    default:
                        Console.WriteLine("Duzgun daxil edin");
                        break;
                }

            } while (key != default);



        }
    }
}
