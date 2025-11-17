class Program
{
    static void User(string name, int age)
    {
        Console.WriteLine($"Hello {name}, you look good for {age}.");
    }

    static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());

        User(name, age);
    }
}
