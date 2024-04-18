class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public string DepartureTime { get; set; }

    public Train(string destination, int trainNumber, string departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    public void DisplayTrainInfo(int enteredTrainNumber)
    {
        if (enteredTrainNumber == TrainNumber)
        {
            Console.WriteLine($"Пункт назначения: {Destination}");
            Console.WriteLine($"Номер поезда: {TrainNumber}");
            Console.WriteLine($"Время отправления: {DepartureTime}");
        }
    }
}

class Program
{
    static void Main()
    {
        Train train1 = new Train("Томск", 1337, "9:10");
        Train train2 = new Train("Санкт-Петербург", 999, "14:30");

        Console.WriteLine("Введите номер поезда: ");
        int userTrainNumber = int.Parse(Console.ReadLine());

        train1.DisplayTrainInfo(userTrainNumber);
        train2.DisplayTrainInfo(userTrainNumber);
    }
}