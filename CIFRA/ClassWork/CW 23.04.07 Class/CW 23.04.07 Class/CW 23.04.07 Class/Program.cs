using System.Runtime.Intrinsics.X86;

namespace CW_23._04._07_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[10];

            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new User();
                users[i].Create();
            }

            users[2].Name = "";
            users[4].Age = 12;



            PrintUsers();
            Console.WriteLine("------------------------------------");
            TrimUsers();
            users[0].PrintAgeDifferense(users);

            Console.ReadKey();

            //END PROGRAMM


            void PrintUsers()
            {
                for (int i = 0; i < users.Length; i++)
                {
                    Console.Write(users[i].Name + "\t" + users[i].Surname + "\tВозраст:  " + users[i].Age);

                    if (users[i].Validate() == false)
                    {
                        Console.Write("   ---- Не корректный");
                    }

                    Console.WriteLine();
                }
            }

            void TrimUsers()
            {
                for (int i = 0; i < users.Length; i++)
                {
                    users[i].Trim();
                }
            }
        }
    }
}