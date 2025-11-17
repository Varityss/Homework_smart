using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        double number = 123456.78;

        string[] cultures ={ "ru-RU", "en-US", "de-DE" };

        foreach (string cultureName in cultures)
        {
            CultureInfo culture = new CultureInfo(cultureName);

            Console.WriteLine($"Культура: {cultureName}");
            Console.WriteLine($"Дата: {now.ToString(culture)}");
            Console.WriteLine($"Число (N): {number.ToString("N", culture)}");
            Console.WriteLine($"Число (C): {number.ToString("C", culture)}");
            Console.WriteLine();
        }
    }
}
