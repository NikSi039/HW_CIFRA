using CW_23._07._17_Auto;

Autom autom = new Autom("Cidan", 30,8);

Console.WriteLine(autom.Total());

autom.Go(120);

autom.Print();

autom.AddFuel(15);

autom.Print();

Console.ReadKey();