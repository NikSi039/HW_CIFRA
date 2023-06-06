namespace CW_23._04._05_REF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _operators = "+";

            string line = Console.ReadLine();
            line = line.Replace(_operators, " " + _operators + " ");

            List<string> _items = GetItems(line);


            float value1 = 0;
            float value2 = 0;
            string oper = "";
            bool _succes = true;

            value1 = TryParse(_items[0], ref _succes);
            oper = _items[1].Trim();
            value2 = TryParse(_items[2], ref _succes);

            if (_succes == false)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                Console.WriteLine("Результат: " + Calculate());
            }  

            Console.WriteLine("Результат: " + (value1 + value2));
            Console.ReadKey();





            float Calculate()
            {
                if (oper == "+")
                {
                    return value1 + value2;
                }
                return 0;
            }

            float TryParse(string line, ref bool succes)
            {
                float result = 0f;

                try
                {
                    result = float.Parse(line);
                }
                catch
                {
                    succes = false;
                }

                return result;
            }

            List<string> GetItems(string text)
            {
                List<string> items = line.Split(' ').ToList();

                foreach (var item in items.ToList())
                {
                    if (item != "") continue;

                    items.Remove(item);

                }

                return items;
            }


            //for (int i = items.Count; i >= 0 ; i--)
            //{
            //    items.RemoveAt(i);
            //}

            //var itemsCopy = items;
            //foreach (var item in itemsCopy)
            //{
            //    items.RemoveAt(0);
            //}
        }
    }
}