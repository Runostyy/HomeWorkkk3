using System;

// Універсальний клас з одним параметром T
public class GenericClass<T> where T : IComparable<T>
{
    // Поля класу
    private T first;
    private T second;

    // Конструктор, який приймає два значення типу T
    public GenericClass(T first, T second)
    {
        this.first = first;
        this.second = second;
    }

    // Метод для знаходження меншого з двох чисел
    public T GetMinimum()
    {
        return first.CompareTo(second) < 0 ? first : second;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання для чисел типу int
        var intExample = new GenericClass<int>(10, 20);
        Console.WriteLine($"Мінімум між 10 і 20: {intExample.GetMinimum()}");

        // Приклад використання для чисел типу double
        var doubleExample = new GenericClass<double>(15.5, 10.2);
        Console.WriteLine($"Мінімум між 15.5 і 10.2: {doubleExample.GetMinimum()}");

        // Приклад використання для строк (порівнюється за алфавітним порядком)
        var stringExample = new GenericClass<string>("Apple", "Banana");
        Console.WriteLine($"Мінімум між 'Apple' і 'Banana': {stringExample.GetMinimum()}");
    }
}