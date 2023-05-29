namespace Design_Patterns_Singleton_CSHARP;

public class Singleton
{
    private static Singleton single = null;

    protected Singleton() // Объект класса мы можем создать только через метод 
    {
        
    }

    public static Singleton Initialize() // Создаем метод
    {
        if (single == null)
        {
            single = new Singleton();
        }

        return single;
    }
}