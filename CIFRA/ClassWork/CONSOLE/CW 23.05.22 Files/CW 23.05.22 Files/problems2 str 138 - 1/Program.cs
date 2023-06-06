using System;

Console.Write("Введите количество студентов: ");
int n = int.Parse(Console.ReadLine());

Student[] mas = new Student[n];
Random random = new();

for (int i = 0; i < mas.Length; i++)
{
    Console.Write("\nВведите ФИО: ");
    mas[i].Fio = Console.ReadLine();

    Console.Write("Введите номер группы: ");
    mas[i].Number = int.Parse(Console.ReadLine());

    mas[i].Grades = new int[3];
    Console.Write("Оценки: ");

    for (int j = 0; j < mas[i].Grades.Length; j++)
    {
        mas[i].Grades[j] = random.Next(3, 6);
        Console.Write(mas[i].Grades[j] + " ");
    }

    Console.Write("\nВведите стипендию: ");
    mas[i].Scolarship = decimal.Parse(Console.ReadLine());
}

using (BinaryWriter writer = new(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    foreach (Student st in mas)
    {
        writer.Write(st.Fio);
        writer.Write(st.Number);
        for (int i = 0; i < st.Grades.Length; i++)
        {
            writer.Write(st.Grades[i]);
        }
        writer.Write(st.Scolarship);
    }
}

using (BinaryReader reader = new(File.Open("file.dat", FileMode.Open)))
{
    while (reader.PeekChar() > -1)
    {
        string fio = reader.ReadString();
        int number = reader.ReadInt32();
        int[] studGrades = new int[3];
        bool isTrue = true;
        for (int i = 0; i < 3; i++)
        {
            studGrades[i] = reader.ReadInt32();
            if (studGrades[i] == 3) isTrue = false;
        }
        decimal scolarship = reader.ReadDecimal();

        if (isTrue)
        {
            Console.Write("\n\n\n" + fio + " " + number + " " + studGrades[0] +
                " " + studGrades[1] + " " + studGrades[2] + " " + scolarship);
        }
    }
}

Console.ReadKey();


struct Student
{
    public string Fio;
    public int Number;
    public int[] Grades;
    public decimal Scolarship;
}
