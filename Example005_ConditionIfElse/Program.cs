Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ого!!! Чё-каво, Мария?");
}
else
{
    Console.Write("Добрый день, ");
    Console.WriteLine(username);
}
