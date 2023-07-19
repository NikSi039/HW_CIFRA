using CW_23._07._19_Turniket;

BusTicket ticket1 = new BusTicket(1, DateOnly.Parse("31.12.2023"), TypeOfTicket.разовый, true);

BusTurniket turniket = new BusTurniket();

turniket.IsValid(DateOnly.FromDateTime(DateTime.Now), ticket1);
turniket.IsValid(DateOnly.FromDateTime(DateTime.Now), ticket1);

BusTicket ticket2 = new BusTicket(1, DateOnly.Parse("19.07.2023"), TypeOfTicket.проездной, true);
turniket.IsValid(DateOnly.FromDateTime(DateTime.Now), ticket2);

Console.ReadKey();