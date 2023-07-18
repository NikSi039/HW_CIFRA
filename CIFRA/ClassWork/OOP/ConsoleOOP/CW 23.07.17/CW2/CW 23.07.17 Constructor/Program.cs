using CW_23._07._17_Constructor;

Console.Write("Введите количество поездов на станции: ");
int n = int.Parse(Console.ReadLine()!);

Station station = new Station(n);

station.SortByNumder();

station.Print();

for (int i = 0; i < station.CountTrains() - 1; i++)
{
	for (int j = i + 1; j < station.CountTrains(); j++)
	{
		if (station[i].getDestination().CompareTo(station[j].getDestination()) > 0)
		{
			Train temp = station[i];
			station[i] = station[j];
			station[j] = temp;
		}
	}
}
station.Print();

Console.ReadKey();
