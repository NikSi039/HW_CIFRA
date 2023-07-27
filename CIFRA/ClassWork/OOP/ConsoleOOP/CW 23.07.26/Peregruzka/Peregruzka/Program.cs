using Peregruzka;

Timee t1 = new Timee(DateTime.Now.Hour, DateTime.Now.Minute);
Console.WriteLine(t1.PrintTime());

Timee t2 = new Timee(4, 35);
Console.WriteLine(t2.PrintTime());

Timee t3 = t1 + t2;
Console.WriteLine(t3.PrintTime());

Timee t4 = t1 - t2;
Console.WriteLine(t4.PrintTime());

Console.WriteLine(t1 == t2);
Console.WriteLine(t3 != t4);

Timee t5 = t1 + 26;
Console.WriteLine(t5.PrintTime());