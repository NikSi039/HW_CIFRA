namespace _2;
class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 1, 4, 6, 2 };

        Insert(ref myArray, -5, 2);// By Index

        AddFirst(ref myArray, -5); // By Start

        AddLast(ref myArray, -5);  // By End


        //END PROGRAMM




        void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }

        void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }

        void AddLast(ref int[] array,int value)
        {
            Insert(ref array, value, array.Length);
        }
    }
}

