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




























using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

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

        //открытое свойство кода
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

        #region статик
        static int Counter;//статический
        public static int GetCounter()
        { return Counter; }

        static DateTime Expiration;//статический
        public static DateTime GetExpiration()
        { return Expiration; }

        #endregion

        #region конструкторы
        //значения по умолчания
        public Card() { Type = "Дебетовая"; Counter++; ExpirationMethod(); }

        /// <summary>
        /// объект с номером и фамилией
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="clientFIO">фамилия</param>
        public Card(ulong number, string clientFIO)
        {
            Number = number;
            ClientFIO = clientFIO;
            Counter++; 
            ExpirationMethod();
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
            Counter++;
            ExpirationMethod();
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
            Counter++;
            ExpirationMethod();
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
            Counter++;
            ExpirationMethod();
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

        private void ExpirationMethod() 
        {
            Expiration = (Validity.Year == DateTime.Now.Year ? Expiration : Validity);
        }
        #endregion
    }
}
Исправь программу на c# так, чтобы программа правильно отображала год у карты, а не выводила 01.01.0001













using System;
using System.Collections.Generic;
using System.Linq;

// Перечисление для типа вопроса
public enum QuestionDifficulty
{
    Easy,
    Hard
}

// Класс вопроса
public class Question
{
    public string Text { get; set; }
    public List<string> Answers { get; set; }
    public int CorrectAnswerIndex { get; set; }
    public QuestionDifficulty Difficulty { get; set; }

    public Question(string text, List<string> answers, int correctAnswerIndex, QuestionDifficulty difficulty)
    {
        Text = text;
        Answers = answers;
        CorrectAnswerIndex = correctAnswerIndex;
        Difficulty = difficulty;
    }
}

// Статический класс викторины
public static class Quiz
{
    public static List<Question> Questions { get; private set; } = new List<Question>();

    // Метод для генерации вопросов (заполнения списка)
    public static void GenerateQuestions()
    {
        // Примеры вопросов (добавьте свои)
        Questions.Add(new Question("2 + 2 = ?", new List<string> { "3", "4", "5", "6" }, 1, QuestionDifficulty.Easy));
        Questions.Add(new Question("Столица Франции?", new List<string> { "Берлин", "Рим", "Париж", "Лондон" }, 2, QuestionDifficulty.Easy));
        Questions.Add(new Question("Что такое фотосинтез?", new List<string> { "...", "...", "..." }, 0, QuestionDifficulty.Hard));
        Questions.Add(new Question("Формула площади круга?", new List<string> { "...", "...", "..." }, 1, QuestionDifficulty.Hard));
         Questions.Add(new Question("Сколько океанов на Земле?", new List<string> { "3", "4", "5", "7" }, 2, QuestionDifficulty.Easy));
        Questions.Add(new Question("В каком году началась Вторая мировая война?", new List<string> { "1914", "1939", "1945", "1941" }, 1, QuestionDifficulty.Hard));

    }


    // Добавление нового вопроса
    public static void AddQuestion(Question question)
    {
        Questions.Add(question);
    }

    // Изменение правильного ответа
    public static void ChangeCorrectAnswer(int questionIndex, int newCorrectAnswerIndex)
    {
        if (questionIndex >= 0 && questionIndex < Questions.Count)
        {
            Questions[questionIndex].CorrectAnswerIndex = newCorrectAnswerIndex;
        }
        else
        {
            Console.WriteLine("Ошибка: индекс вопроса некорректен.");
        }
    }

    // Запуск викторины
    public static void StartQuiz()
    {
        Random random = new Random();
        List<Question> quizQuestions = Questions.Where(q => q.Difficulty == QuestionDifficulty.Hard).OrderBy(x => random.Next()).Take(3).ToList();
        quizQuestions.AddRange(Questions.Where(q => q.Difficulty == QuestionDifficulty.Easy).OrderBy(x => random.Next()).Take(7).ToList());
        quizQuestions = quizQuestions.OrderBy(x => random.Next()).ToList();


        int correctAnswers = 0;
        int score = 0;


        foreach (Question question in quizQuestions)
        {
            Console.ForegroundColor = question.Difficulty == QuestionDifficulty.Easy ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(question.Text);
            Console.ResetColor();

            for (int i = 0; i < question.Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
            }

            Console.Write("Ваш ответ: ");
            if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer > 0 && userAnswer <= question.Answers.Count)
            {
                if (userAnswer - 1 == question.CorrectAnswerIndex)
                {
                    correctAnswers++;
                    score += question.Difficulty == QuestionDifficulty.Easy ? 1 : 5;
                    Console.WriteLine("Верно!");
                }
                else
                {
                    Console.WriteLine($"Неверно. Правильный ответ: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
    









































Требования к выполнению:
1. Каждый класс / перечисление в отдельном файле
2. Наименование переменных / методов отражают их назначение
3. Пользователю выводятся информационные сообщения о необходимых действиях 
4. Консольный вывод логически разделен на блоки, удобен для чтения.
5. Осуществить хранение всех данных объектов в сериализированном виде в текущей папке проекта. При старте приложения, данные должны восстанавливаться из файлов сохранений

Создать перечисление для типа вопроса викторины (легкий, сложный)

         * Создать класс вопроса со следующими значениями (текст вопроса, список вариантов ответа (от 3 до 5), правильный ответ(в виде индекса списка)
         * Создать статический класс викторины, в котором содержится список вопросов.Заполнить его через специальный метод-генератор.
         * 
         * В классе викторины реализовать следующие методы:
         * 
         * 1. Добавление нового вопроса
         * 2. Изменение правильного ответа в конкретном вопроск
         * 3. Запуск режима прохождения викторины
         *      a)  При каждом запуске случайным образом выбираются 3 сложных и 7 легких вопросов из словаря
         *      b)	поочередно задаются вопросы, пользователь отвечает через ввод номера правильного по его мнению ответа,
         *      c)	Сложные вопросы выводятся красным цветом, легкие зеленым.
         *      d)  После очередного ответа пользователя консоль очищается
         *      e)	программа введет подсчет правильных ответов и в конце прохождения теста выводит результат) 
         *     
         * Рапределение баллов:
         * Легкий вопрос - 1 балл
         * Сложный - 5 баллов

Написать на языке С#, без использования try – catch,без LINQ. Пиши код простой и понятный





            
