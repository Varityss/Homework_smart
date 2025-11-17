 var products = new (string Name, int Count) [4]
        {
            ("Молоток", 900),
            ("Саморез", 100),
            ("Гвоздь",200),
            ("Отвертка",900)
        };


Console.WriteLine("{0, -8} {1, 6}", "Name", "Count");

foreach (var (Name, Count) in products)
{
    Console.WriteLine("{0, -8} {1, 6:N0}", Name, Count);
}