class Student
{
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Group { get; set; }
    private int[] grades = new int[5];

    public int[] Grades
    {
        get { return grades; }
        set { grades = value; }
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine("Фамилия: " + Surname);
        Console.WriteLine("Дата рождения: " + BirthDate.ToString("dd.MM.yyyy"));
        Console.WriteLine("Группа: " + Group);
        Console.Write("Успеваемость: ");
        foreach (int grade in Grades)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
    }

    public void ChangeSurname(string newSurname)
    {
        Surname = newSurname;
    }

    public void ChangeBirthDate(DateTime newBirthDate)
    {
        BirthDate = newBirthDate;
    }

    public void ChangeGroup(string newGroup)
    {
        Group = newGroup;
    }

    public void StudentInfo()
    {
        Console.WriteLine("Фамилия: " + Surname);
        Console.WriteLine("Дата рождения: " + BirthDate.ToString("dd.MM.yyyy"));
        Console.WriteLine("Группа: " + Group);
        Console.Write("Успеваемость: ");
        foreach (int grade in Grades)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        Console.WriteLine("Введите фамилию: ");
        student.Surname = Console.ReadLine();
        Console.WriteLine("Введите дату рождения (дд.мм.гггг): ");
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        student.BirthDate = birthDate;
        Console.WriteLine("Введите группу: ");
        student.Group = Console.ReadLine();
        Console.WriteLine("Введите успеваемость (5 элементов): ");
        int[] grades = new int[5];
        for (int i = 0; i < 5; i++)
        {
            grades[i] = int.Parse(Console.ReadLine());
        }
        student.Grades = grades;
        Console.WriteLine("\nИнформация о студенте: ");
        student.PrintStudentInfo();

        Console.WriteLine("\nИзменение информации.");
        Console.WriteLine("Введите новую фамилию: ");
        string newSurname = Console.ReadLine();
        student.ChangeSurname(newSurname);

        Console.WriteLine("Введите новую дату рождения (дд.мм.гггг): ");
        DateTime newBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        student.ChangeBirthDate(newBirthDate);

        Console.WriteLine("Введите новую группу: ");
        string newGroup = Console.ReadLine();
        student.ChangeGroup(newGroup);

        Console.WriteLine("\nОбновленная информация о студенте: ");
        student.StudentInfo();
    }
}