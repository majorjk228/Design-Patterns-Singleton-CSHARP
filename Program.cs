using System.Security.Cryptography;

namespace Design_Patterns_Singleton_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Initialize(); // Создаем объект

            Singleton s2 = Singleton.Initialize(); // Присваеваем тот же объект (s1)

            Console.WriteLine(s1.Equals(s2));
        }
    }
}