﻿using HumanWorker;

Worker wk = new Worker("Petrov V.A.", "29.02.2023", "Manager");

Console.WriteLine(wk.Name);
Console.WriteLine(wk.Date);
Console.WriteLine(wk.Position);

wk.Name = "Ivanov V.A.";
