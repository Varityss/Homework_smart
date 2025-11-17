Console.Write("Введите количество яиц");
string eggs=Console.ReadLine();

try
{
    int eggs1=int.Parse(eggs);
}
catch
{
    Console.WriteLine("Ошибка при конвертации int.Parse");
}

bool result = int.TryParse(eggs, out var number);
if (result == true)
    Console.WriteLine($"Преобразование прошло успешно. Число ваших яиц: {number}");
else
    Console.WriteLine("Преобразование int.TryParse завершилось неудачно");