class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }

    public double GetSalary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите имя работника: ");
        string name = Console.ReadLine();

        Console.WriteLine("Введите фамилию работника: ");
        string surname = Console.ReadLine();

        Console.WriteLine("Введите ставку за день работы: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите количество отработанных дней: ");
        int days = Convert.ToInt32(Console.ReadLine());

        Worker worker = new Worker(name, surname, rate, days);

        Console.WriteLine("\nЗарплата работника {0} {1}: {2}", worker.Name, worker.Surname, worker.GetSalary());
    }
}