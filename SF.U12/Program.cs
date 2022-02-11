//Задание 12.1.5
//Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.

using System;

namespace SF.U12;
class Program
{
    static void Main()
    {
        List<User> users = new List<User>()
        {   new User("vova1987", "Владимир", true),
            new User("anka", "Анна", false),
            new User("soldier1914", "Швейк", true),
            new User("shurik2020", "Александр", false),
            new User("fallenangel1963", "Анжела", true),};

        foreach (User user in users)
        {
            Console.WriteLine($"Приветствуем Вас, {user.Name}!");

            if (!user.IsPremium)
                ShowAds();
        }    
    }
    static void ShowAds()
    {
        Console.WriteLine("\tПосетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("\tКупите подписку на МыКомбо и слушайте музыку везде и всегда.");        
        Thread.Sleep(2000);

        Console.WriteLine("\tОформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");    
        Thread.Sleep(3000);
    }
}