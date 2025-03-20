Авторизация будет перенаправлять на
http://127.0.0.1:62050

\




Задание:
1.	Создайте класс следуя своему варианту. (в отдельном файле, имя файла класса и название класса должны быть идентичными)
2.	Создать несколько конструкторов класса, предусмотрев варианты с возможностью инициализации объектов разным количеством параметров, предусмотреть значения по умолчанию.
3.	В точке входа (методе Main) создайте несколько объектов данного класса (минимум 4) используя конструкторы с различными параметрами.
4.	Проверьте работу метода класса применительно к каждому объекту.
5.	Создайте диаграмму класса в соответствии с теоретической частью 

18	вариант
Создать класс Card описывающий банковскую карту как сущность в приложении

Член класса	название	особенности
поле	number	Номер карты
поле	clientFIO	Фио клиента
поле	validity	Срок действия
поле	secureCode	Код безопасности
поле	type	Дебетовая/кредитная
метод	PrintInfo()	выводит описание текущего объекта


















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_02_01.Publications
{
    /// <summary>
    ///  класс Card описывающий банковскую карту как сущность 
    ///  в приложении c данными:
    ///  Номер карты, Фио клиента, Срок действия, Код безопасности, Дебетовая/кредитная
    /// </summary>
    internal class Card
    {
        #region поля
        public string Number { get; set; }
        public string ClientFIO { get; set; }
        public string Validity { get; set; }
        public string SecureCode { get; set; }
        public string Type { get; set; }
        #endregion

        #region конструкторы
        public Card() { Number = "-"; Validity = "-"; ClientFIO = "-"; Type = "Дебетовая"; SecureCode = "-"; } //по умолчанию 

        /// <summary>
        /// объект с номером и фамилией
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="surname">фамилия</param>
        public Card(string number, string clientFIO)
        {
            Number = number;
            ClientFIO = clientFIO;
        }

        /// <summary>
        /// объект с номером фамилией сроком действия
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="surname">фамилия</param>
        /// <param name="validity">срок</param>
        public Card(string number, string clientFIO, string validity)
        {
            Number = number;
            ClientFIO = clientFIO;
            Validity = validity;
        }
        /// <summary>
        /// объект с номером фамилией сроком действия кодом безопасности
        /// </summary>
        /// <param name="number">номер</param>
        /// <param name="surname">фамилия</param>
        /// <param name="validity">срок</param>
        /// <param name="secureCode">код безопасности</param>
        public Card(string number, string clientFIO, string validity, string secureCode)
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
        /// <param name="surname">фамилия</param>
        /// <param name="validity">срок</param>
        /// <param name="secureCode">код безопасности</param>
        /// <param name="type">тип</param>
        public Card(string number, string clientFIO, string validity, string secureCode, string type)
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




using pz_02_01.Publications;

namespace pz_02_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Создание объектов класса Card с использованием разных конструкторов
            Card card1 = new Card();
            Card card2 = new Card("5417154375654135", "Robert Ozerov E.");
            Card card3 = new Card
            {
                Number = "4938081338899957",
                ClientFIO = "Shanty Johansen",
                Validity = "03/2026",
                SecureCode = "292",
            };
            Card card4 = new Card("5164512248133840", "Ginevra Eisenhower O.", "06/2030", "941", "Кредитная");

            card1.PrintInfo();
            card2.PrintInfo();
            card3.PrintInfo();
            card4.PrintInfo();

        }
    }
}




















