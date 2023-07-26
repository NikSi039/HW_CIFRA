using Studentsss;

Student student = new Student()
{
    FirstName = "Ivan",
    LastName = "Ivanov",
    Group = "22ISP - 2",
    AverageMark = 5
};
Console.WriteLine(student.getScolarship());

Aspirant aspirant = new Aspirant()
{
    FirstName = "Petr",
    LastName = "Petrov",
    Group = "P - 12",
    AverageMark = 5,
    ScientistPurpose = "Physics"
};
Console.WriteLine(aspirant.getScolarship());

Student[] students = new Student[2];
students[0] = student;
students[1] = aspirant;