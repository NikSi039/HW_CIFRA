//Задача на взаимодействие между классами.

//Разработать систему «Автобаза». 

//Диспетчер распределяет заявки на Рейсы между Водителями 
//и назначает для этого Автомобиль. 

//Водитель может сделать заявку на ремонт. 

//Диспетчер может отстранить Водителя от работы. 

//Водитель делает отметку о выполнении Рейса и состоянии Автомобиля.

using HW_23._07._26;

Dispetcher dispetcher = new Dispetcher() { Name = "Sidorov A.V." };

Driver driver1 = new Driver("Ivanov V.V.");

Auto auto1 = new Auto(1);

Flight flight1 = new Flight(1, driver1, auto1);

dispetcher.ScheduleFlight(flight1);
driver1.FlightDoneSucces(flight1, auto1);

dispetcher.WorkSuspention(driver1);
dispetcher.ScheduleFlight(flight1);

dispetcher.WorkPermit(driver1);

driver1.RepairRequest(auto1);
dispetcher.ScheduleFlight(flight1);

Console.ReadKey();