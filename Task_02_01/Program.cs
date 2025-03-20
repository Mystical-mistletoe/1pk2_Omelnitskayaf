namespace Task_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}






using System;

public class FactorialCalculator
{
    public static long Factorial(int n)
    {
        // 1. Проверяем, что число неотрицательное
        if (n < 0)
        {
            // Если число отрицательное, выбрасываем исключение. 
            // Это стандартный способ сообщить об ошибке в C#.
            throw new ArgumentOutOfRangeException("Факториал определен только для неотрицательных чисел.");
        }

        // 2. Факториал нуля равен единице. Это особое правило.
        if (n == 0)
        {
            return 1;
        }

        // 3. Если число положительное, вычисляем факториал через цикл
        long result = 1; // Начинаем с 1, т.к. будем умножать
        for (int i = 1; i <= n; i++)
        {
            result *= i; // Умножаем результат на текущее число
        }

        // 4. Возвращаем результат
        return result;
    }



    public static void Main(string[] args)
    {
        // Примеры использования
        try // Блок try-catch для обработки исключений
        {
            Console.WriteLine($"Факториал 5: {Factorial(5)}"); // Выведет 120
            Console.WriteLine($"Факториал 0: {Factorial(0)}"); // Выведет 1
            Console.WriteLine($"Факториал -3: {Factorial(-3)}"); // Выбросит исключение
        }
        catch (ArgumentOutOfRangeException ex) // Ловим исключение, если число отрицательное
        {
            Console.WriteLine($"Ошибка: {ex.Message}"); // Выводим сообщение об ошибке
        }

    }
}
