class NumHolder
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public NumHolder(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    public void Numbers()
    {
        Console.WriteLine($"Числа: {Num1}, {Num2}");
    }

    public int GetSum()
    {
        return Num1 + Num2;
    }

    public int GetMax()
    {
        return Math.Max(Num1, Num2);
    }

    public void ChangeNumbers(int newNum1, int newNum2)
    {
        Num1 = newNum1;
        Num2 = newNum2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        NumHolder nums = new NumHolder(num1, num2);

        Console.WriteLine($"Сумма чисел: {nums.GetSum()}");
        Console.WriteLine($"Максимальное число: {nums.GetMax()}");

        Console.WriteLine("Изменить эти числа?");
        nums.Numbers();

        Console.WriteLine("Введите новое первое число:");
        int newNum1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите новое второе число:");
        int newNum2 = Convert.ToInt32(Console.ReadLine());

        nums.ChangeNumbers(newNum1, newNum2);
        Console.WriteLine($"Измененные числа: {nums.Num1}, {nums.Num2}");
        Console.WriteLine($"Сумма чисел: {nums.GetSum()}");
        Console.WriteLine($"Максимальное число: {nums.GetMax()}");
    }
}