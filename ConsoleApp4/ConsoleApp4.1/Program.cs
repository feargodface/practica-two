class RomanToIntegerConverter
{
    private Dictionary<char, int> romanValues = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int ConvertToInteger(string roman)
    {
        int result = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && romanValues[roman[i]] < romanValues[roman[i + 1]])
            {
                result -= romanValues[roman[i]];
            }
            else
            {
                result += romanValues[roman[i]];
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        RomanToIntegerConverter converter = new RomanToIntegerConverter();
        
        Console.WriteLine("Пример 1: Input: \"III\" Output: {0}", converter.ConvertToInteger("III"));
        Console.WriteLine("Пример 2: Input: \"LVIII\" Output: {0}", converter.ConvertToInteger("LVIII"));
        Console.WriteLine("Пример 3: Input: \"MCMXCIV\" Output: {0}", converter.ConvertToInteger("MCMXCIV"));
    }
}