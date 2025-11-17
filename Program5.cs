using System.Security.AccessControl;

string? nickname = null;

int NicknameLength()
{
    return nickname?.Length ?? 0;
    
}


Console.Write("Введите имя пользователя");
nickname = Console.ReadLine();

if (nickname == "")
{
    Console.WriteLine("Ввод пустой, попробуйте заново");
}
else
{
     int nicknamelength = NicknameLength();
    Console.WriteLine($"Никнейм: {nickname}, Длина: {nicknamelength}");
}

