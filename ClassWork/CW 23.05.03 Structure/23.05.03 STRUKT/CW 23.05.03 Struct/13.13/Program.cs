using System.Text;
using System;

namespace _13._13
{
    internal class Program
    {
        //13.13. Известны данные о стоимости каждого из 20 наименований товаров:
        //число рублей и число копеек.
        //Составить программу, сравнивающую стоимость двух любых наименований товаров
        //(определяющую, какой из товаров стоит дороже).

        struct Tovar
        {
            public string name;
            public int rub;
            public int kop;
        }

        static void Main(string[] args)
        {
            Tovar[] tovars = new Tovar[5];

            Random random = new Random();   

            for (int i = 0; i < tovars.Length; i++)
            {
                tovars[i] = new Tovar();
                tovars[i].name = GetString(random.Next(4, 10));
                tovars[i].rub = random.Next(100, 1000);
                tovars[i].kop = random.Next(0, 100);

                Console.WriteLine(tovars[i].name + " " + tovars[i].rub + " " + tovars[i].kop);
            }

            for (int i = 0; i < tovars.Length - 1; i++)
            {
                for (int j = i + 1; j < tovars.Length; j++)
                {
                    if (tovars[i].rub * 100 + tovars[i].kop < tovars[j].rub * 100 + tovars[j].kop)
                    {
                        Tovar temp = tovars[i];
                        tovars[i] = tovars[j];
                        tovars[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n");

            foreach (Tovar tovar in tovars)
            {
                Console.WriteLine(tovar.name + " " + tovar.rub + " " + tovar.kop);
            }

            Console.ReadKey();


            //end


            string GetString(int n)
            {
                StringBuilder str = new StringBuilder();

                str.Append((char)random.Next(1040, 1072));

                for (int i = 0; i < n; i++)
                {
                    str.Append((char)random.Next(1072, 1104));
                }

                return str.ToString();
            }
        }
    }
}