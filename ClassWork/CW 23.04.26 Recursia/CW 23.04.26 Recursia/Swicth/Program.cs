namespace Swicth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите номер дня недели: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(DayWeek(n));

                Console.WriteLine(DayWeekNew(n));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            //end

            string DayWeek(int n)
            {
                string result;

                switch (n)
                {
                    case 1: result = "Понедельник"; break;
                    case 2: result = "Вторник"; break;
                    case 3: result = "Среда"; break;
                    case 4: result = "Четверг"; break;
                    case 5: result = "Пятница"; break;
                    case 6: result = "Суббота"; break;
                    case 7: result = "Воскресенье"; break;
                    default: result = "Нет такого дня недели"; break;
                }

                return result;
            }

            string DayWeekNew(int n)
            {
                string s;

                return s = n switch
                {
                    1 => "Понедельник",
                    2 => "Вторник",
                    3 => "Среда",
                    4 => "Четверг",
                    5 => "Пятница",
                    6 => "Суббота",
                    7 => "Воскресенье",
                    _ => "Нет такого дня недели"
                };
            }

            Console.ReadKey();
        }
    }
}