class ClassFixed
{
    public int num { get; set; }
    public string words { get; set; }

    public ClassFixed()
    {
        defoalt();
    }

    public ClassFixed(int prop1, string prop2)
    {
        num = prop1;
        words = prop2;
    }

    public void defoalt()
    {
        num = 0;
        words = "по умолчанию";
    }

    ~ClassFixed()
    {
        Console.WriteLine("Объект удален.");
    }

    public void Conclusion()
    {
        Console.WriteLine($"Число: {num}, слова {words}");
    }
}

class Program
{
    static void Main()
    {
        ClassFixed def = new ClassFixed();
        
        ClassFixed obj1 = new ClassFixed(999, "Аркана");
        Console.WriteLine("Первый объект: ");
        obj1.Conclusion();

        ClassFixed obj2 = new ClassFixed(1337, "тю тюнь.");
        Console.WriteLine("Второй объект: ");
        obj2.Conclusion();
    }
}