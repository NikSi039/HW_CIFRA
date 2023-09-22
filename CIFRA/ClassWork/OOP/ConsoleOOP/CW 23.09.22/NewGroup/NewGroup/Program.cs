Matrix mat1 = new Matrix();
mat1.firstMatrix = new int[3, 3]
{
    {1,2,3 },
    {4,5,6},
    {7,8,9 }
};

mat1.secondMatrix = new int[3, 3]
    {
    {1,2,3 },
    {4,5,6},
    {7,8,9 }
};

int[,] array = mat1 + mat1;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}








class Matrix
{
    public int[,] firstMatrix = new int[3,3];
    public int[,] secondMatrix = new int[3,3];  
    
    public static int[,] operator+(Matrix first, Matrix second)
    {
        int[,] currentMatrix = new int[3, 3];

        for (int row = 0; row < currentMatrix.GetLength(0); row++)
        {
            for (int columns = 0; columns < currentMatrix.GetLength(1); columns++)
            {
                currentMatrix[row,columns] = first.firstMatrix[row,columns] + second.firstMatrix[row,columns];
            }
        }

        return currentMatrix;

    }
}
