class Calculation
{
    private string calculationLine { get; set; }

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (string.IsNullOrEmpty(calculationLine))
        {
            return ' ';
        }
        else
        {
            return calculationLine[calculationLine.Length - 1];
        }
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine("1337 + 663 = ");

        Console.WriteLine("Строка вычисления: {0}", calc.GetCalculationLine());

        calc.SetLastSymbolCalculationLine('?');
        Console.WriteLine("Строка вычисления с добавленным символом: {0}", calc.GetCalculationLine());

        char lastSymbol = calc.GetLastSymbol();
        Console.WriteLine("Последний символ: {0}", lastSymbol);

        calc.DeleteLastSymbol();
        Console.WriteLine("Строка вычисления после удаления последнего символа: {0}", calc.GetCalculationLine());
    }
}