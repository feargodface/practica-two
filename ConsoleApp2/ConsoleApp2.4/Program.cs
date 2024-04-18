class Counter
{
    private int value;

    public Counter()
    {
        value = 0;
    }

    public Counter(int newValue)
    {
        value = newValue;
    }

    public void Increase()
    {
        value++;
    }

    public void Decrease()
    {
        value--;
    }

    public int Value
    {
        get { return value; }
        set { value = value; }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        Counter count = new Counter(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("\nТекущее значение счетчика: " + count.Value);

        count.Increase();
        Console.WriteLine("Увеличение счетчика: " + count.Value);

        count.Decrease();
        Console.WriteLine("Уменьшение счетчика: " + count.Value);

        Console.WriteLine("\nВыберите функцию: увеличить (1) или уменьшить (2)");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i < 2)
        {
            count.Increase();
            Console.WriteLine("Увеличение счетчика: " + count.Value);
        }
        else
        {
            count.Decrease();
            Console.WriteLine("Уменьшение счетчика: " + count.Value);
        }

        Console.WriteLine("\nТекущий счетчик: " + count.Value);
    }
}