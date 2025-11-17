Console.Write("Введите что нибудь: ");
string inf = Console.ReadLine();

if (int.TryParse(inf, out int intValue))
{
    Console.WriteLine($"int: {intValue}");
}
else if (double.TryParse(inf, out double doubleValue))
{
    Console.WriteLine($" double: {doubleValue}");
}
else if (bool.TryParse(inf, out bool boolValue))
{
    Console.WriteLine($" bool: {boolValue}");
}
else
{
    Console.WriteLine("Не удалось определить тип.");
}
