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












// Файл: Card.cs
using System;

public class Card
{
    public string Number { get; set; }
    public string ClientFIO { get; set; }
    public string Validity { get; set; }
    public string SecureCode { get; set; }
    public string Type { get; set; }

    // Конструктор по умолчанию
    public Card()
    {
        Type = "Дебетовая"; // Значение по умолчанию
    }

    // Конструктор с инициализацией номера карты и ФИО клиента
    public Card(string number, string clientFIO) : this() // Вызов конструктора по умолчанию
    {
        Number = number;
        ClientFIO = clientFIO;
    }

    // Конструктор с инициализацией всех полей, кроме типа карты
    public Card(string number, string clientFIO, string validity, string secureCode) : this(number, clientFIO)
    {
        Validity = validity;
        SecureCode = secureCode;
    }


    // Конструктор с инициализацией всех полей
    public Card(string number, string clientFIO, string validity, string secureCode, string type) : this(number, clientFIO, validity, secureCode)

    {
        Type = type;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Информация о карте:");
        Console.WriteLine($"Номер: {Number}");
        Console.WriteLine($"ФИО клиента: {ClientFIO}");
        Console.WriteLine($"Срок действия: {Validity}");
        Console.WriteLine($"Код безопасности: {SecureCode}");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine();
    }
}

// Файл: Program.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Создание объектов класса Card с использованием разных конструкторов
        Card card1 = new Card();
        Card card2 = new Card("1234567890123456", "Иванов Иван Иванович");
        Card card3 = new Card("9876543210987654", "Петров Петр Петрович", "12/25", "123");
        Card card4 = new Card("5555444433332222", "Сидоров Сидор Сидорович", "11/28", "456", "Кредитная");

        // Вызов метода PrintInfo() для каждого объекта
        card1.PrintInfo();
        card2.PrintInfo();
        card3.PrintInfo();
        card4.PrintInfo();

    }
}




