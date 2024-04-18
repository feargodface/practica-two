class Program 
{
    static void Main()
    {
        Console.WriteLine("Ввод: ");
        string j = Console.ReadLine();
        string s = Console.ReadLine();

        int count = 0;
        foreach(char jewel in j) 
        {
            foreach(char stone in s) 
            {
                if(jewel == stone) 
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Вывод: " + count); 
    }
}