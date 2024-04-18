class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public Worker(string name, string surname, double rate, int days)
    {
        this.name = name;
        this.surname = surname;
        this.rate = rate;
        this.days = days;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSurname()
    {
        return surname;
    }

    public double GetRate()
    {
        return rate;
    }

    public int GetDays()
    {
        return days;
    }

    public double GetSalary()
    {
        return rate * days;
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

        Console.WriteLine("\nИмя работника: {0}", worker.GetName());
        Console.WriteLine("Фамилия работника: {0}", worker.GetSurname());
        Console.WriteLine("Ставка за день работы: {0}", worker.GetRate());
        Console.WriteLine("Количество отработанных дней: {0}", worker.GetDays());
        Console.WriteLine("Зарплата работника: {0}", worker.GetSalary());
    }
}