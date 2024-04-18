namespace GarageConsoleApp;

public class Program
{
    public static void Main(string[] arg)
    {
        int answer = 0;
        while (answer != 7)
        {
            Console.WriteLine("\nВыберите функцию: ");
            Console.WriteLine("1. Просмотр существующих машин: ");
            Console.WriteLine("2. Просмотр существующих типов машин: ");
            Console.WriteLine("3. Просмотр существующих водителей и их прав: ");
            Console.WriteLine("4. Просмотр существующих маршрутов: ");
            Console.WriteLine("5. Просмотр существующих рейсов: ");
            Console.WriteLine("6. Просмотр категорий прав водителей.");
            Console.WriteLine("7. Выйти из программы");
            
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Машины: ");
                    DatabaseRequests.GetCarQuery();
                    DatabaseRequests.AddCarQuery(4, "Toyota Supra", "X666XX70", 3);
                    break;
                case 2:
                    Console.WriteLine("Тип машин: ");
                    DatabaseRequests.GetTypeCarQuery();
                    DatabaseRequests.AddTypeCarQuery("Водный");
                    break;
                case 3:
                    Console.WriteLine("Водители и их права: ");
                    DatabaseRequests.GetDriverQuery();
                    DatabaseRequests.AddDriverQuery("Олег", "Нечипоренко", new DateTime(1989, 05, 21));
                    break;
                case 4:
                    Console.WriteLine("Маршруты: ");
                    DatabaseRequests.GetItineraryQuery();
                    DatabaseRequests.AddItineraryQuery("Томск-Барселона");
                    break;
                case 5:
                    Console.WriteLine("Рейсы: ");
                    DatabaseRequests.GetRouteQuery();
                    DatabaseRequests.AddRouteQuery(3, 2, 4, 4);
                    break;
                case 6:
                    Console.WriteLine("Права");
                    DatabaseRequests.GetDriverRightsCategoryQuery(1);
                    DatabaseRequests.AddDriverRightsCategoryQuery(3, 2);
                    break;
                case 7:
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Упс! Ошибка. Введите предложенные функции.");
                    break;
            }
        }
    }
}