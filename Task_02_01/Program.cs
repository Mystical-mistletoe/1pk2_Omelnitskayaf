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





















































namespace consoleProject
{
    /// <summary>
    ///  класс Card описывающий банковскую карту как сущность 
    ///  в приложении c данными:
    ///  Номер карты, Фио клиента, Срок действия, Код безопасности, Дебетовая/кредитная
    /// </summary>
    internal class Card
    {
        #region поля
        private ulong number;
        private string clientFIO;
        private DateTime validity;
        private int secureCode;
        private string type;
        #endregion

        #region свойства
        //открытое свойство номера, связанное с полем номера и выполняющее предварительную проверка на количество цифр меньше 20 или больше
        public ulong Number
        {
            get { return number; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value.ToString().Length == 20) //если приходящее значение == 20
                    number = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! number not equal to 20"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }

        }
        //открытое свойство ФИО, связанное с полем ФИО и выполняющее предварительную проверка на попытку записать пустое имя
        public string ClientFIO
        {
            get { return clientFIO; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    clientFIO = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! clientFIO is empty"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }

        //открытое свойство кода, связанное с полем кода и выполняющее предварительную проверка на количество цифр меньше 3 или больше
        public DateTime Validity
        {
            get { return validity; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                DateTime date1 = new DateTime(2022, 1, 1);
                DateTime date2 = new DateTime(2026, 1, 1);
                if (date1 <= value && date2 >= value) //
                    validity = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! validity does not match the date"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }

        }

        //открытое свойство кода, связанное с полем кода и выполняющее предварительную проверка на количество цифр меньше 3 или больше
        public int SecureCode
        {
            get { return secureCode; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value.ToString().Length == 3) //если приходящее значение == 20
                    secureCode = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! secureCode not equal to 3"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }

        }

        //открытое свойство ФИО, связанное с полем ФИО и выполняющее предварительную проверка на попытку записать пустое имя
        public string Type
        {
            get { return type; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    type = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! Type is empty"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }

        #endregion

        #region static

        #endregion

        #region конструкторы
        //значения по умолчания
        public Card() {}

        /// <summary>
        /// объект с номером и фамилией
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="clientFIO">фамилия</param>
        public Card(ulong number, string clientFIO)
        {
            Number = number;
            ClientFIO = clientFIO;
        }

        /// <summary>
        /// объект с номером фамилией сроком действия
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="clientFIO">фамилия</param>
        /// <param name="validity">срок</param>
        public Card(ulong number, string clientFIO, DateTime validity)
        {
            Number = number;
            ClientFIO = clientFIO;
            Validity = validity;
        }
        /// <summary>
        /// объект с номером фамилией сроком действия кодом безопасности
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="clientFIO">фамилия</param>
        /// <param name="validity">срок</param>
        /// <param name="secureCode">код безопасности</param>
        public Card(ulong number, string clientFIO, DateTime validity, int secureCode)
        {
            Number = number;
            ClientFIO = clientFIO;
            Validity = validity;
            SecureCode = secureCode;
        }

        /// <summary>
        /// объект с номером фамилией сроком действия кодом безопасности и типом
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="clientFIO">фамилия</param>
        /// <param name="validity">срок</param>
        /// <param name="secureCode">код безопасности</param>
        /// <param name="type">тип</param>
        public Card(ulong number, string clientFIO, DateTime validity, int secureCode, string type)
        {
            Number = number;
            ClientFIO = clientFIO;
            Validity = validity;
            SecureCode = secureCode;
            Type = type;
        }
        #endregion

        #region методы
        /// <summary>
        /// возврат текущей информации по объекту
        /// </summary>
        /// <returns>строка с информацией</returns>
        public void PrintInfo()
        {
            Console.WriteLine("Информация о карте:\n" + $"Номер: {Number}\n" +
                $"ФИО клиента: {ClientFIO}\n" + $"Срок действия: {Validity}\n" +
                $"Код безопасности: {SecureCode} \n" + $"Тип: {Type}\n");
            Console.WriteLine();
        }
        #endregion
    }
}
Создать статические поля для этой программы
Назначение статического поля/полей
Подсчитывает количество всех банковских карт
Подсчитывает количество карт, срок действия которых истекает в этом году




