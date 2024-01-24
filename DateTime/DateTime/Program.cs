using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimee
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Назначение структуры DateTime
            //Для работы с датой и временем язык C# предусматривает структуру DateTime, описанную в пространстве имен System.Она представляет дату и время от 00:00:00 1 января 0001 года до 23:59:59 31 декабря 9999 года.
            //Пример. Создание нового объекта DateTime с помощью конструктора без параметров
            DateTime dateTime = new DateTime();
            //Способы вывода
            Console.WriteLine(dateTime);//01.01.0001 0:00:00
            //Метод ToString() System.Object возвращает символьную строку, содержащую описание того объекта, для которого он вызывается
            Console.WriteLine(dateTime.ToString());//01.01.0001 0:00:00
            //MinValue – наименьшее значение типа DateTime
            Console.WriteLine($"Наименьшее значение типа DateTime - {DateTime.MinValue}");//01.01.0001 0:00:00
            //MaxValue – наибольшее значение типа DateTime
            Console.WriteLine($"Наибольшее значение типа DateTime-{ DateTime.MaxValue}");//31.12.9999 23:59:
            //2. Установка необходимой даты с использованием конструктора с параметрами
            DateTime dateTime1 = new DateTime(1965, 12, 30);//Сначала год, потом месяц и день
            Console.WriteLine(dateTime1.ToString());//30.12.1965 0:00:00
            DateTime dateTime2 = new DateTime(1989, 01, 27, 8, 30, 45); //27.01.1989 8:30:45
            Console.WriteLine(dateTime2.ToString());
            //3. Свойства структуры DateTime
            /*1) Date – собственно структура типа DateTime.
              2) DayOfWeek – день недели(члены перечисления DayOfWeek Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,Sunday).
              3) DayOfYear – целочисленное значение дня заданного года от 1 до 366.
              4) Hour – количество часов заданного дня от 0 до 23.
              5) Kind – представляет собой значение, указывающее, какое время указано текущим экземпляром структуры DateTime, является перечисления Kind:
                 Local – местное время
                 Utc – время представлено стандартомUTC.
                 Unspecified – время не определено ни как местное, ни как UTC.
              6) Millisecond – количество миллисекунд заданной даты от 0 до 999.
              7) Minute – количество минут заданной даты от 0 до 59.
              8) Month – значение месяца заданной даты от 1 до 12.
              9) Second – количество секунд заданной даты от 0 до 59.
              10) Year – год заданной даты от 0001 до 9999.
              11) TimeOfDay – время дня для заданной даты(с точностью до 100 наносекунд).
              12) Ticks – число 100 - наносекундных тактов в формате Int64 начиная с 00:00:00 1 января 0001 года.
              Статические свойства и поля, возвращающие текущую дату или время:
              1) Now – представляет собой свойство DateTime, содержащее текущую дату и время данного компьютера в формате местного времени;
              2) Today – представляет собой текущую дату;
              3) UtcNow - представляет собой свойство DateTime, содержащее текущую дату и время данного компьютера в формате UTC;
              4) MinValue – наименьшее значение типа DateTime;
              5) MaxValue – наибольшее значение типа DateTime
              6) IsLeapYear(Int32 year) – возвращает логическое значение true, если переданный год является високосным и false в противном случае
              7) DaysInMonth(Int32 year, Int32 month) – возвращает количество дней в указанном месяце указанного года*/
            DateTime today = DateTime.Now;
            Console.WriteLine($"Текущая дата и время: {today}");//19.01.2024 10:40:36
            Console.WriteLine($"Год:{today.Year}");//Год: 2024
            Console.WriteLine($"Месяц: {today.Month}");//Месяц: 1
            Console.WriteLine($"День: {today.Day}");//День: 19
            Console.WriteLine($"День недели: {today.DayOfWeek}");//День недели: Friday
            Console.WriteLine($"День года: {today.DayOfYear}");//День недели: Friday
            //4. Операции с DateTime
            /*Для добавления дат используется ряд методов:
               Add(TimeSpan value): добавляет к дате значение TimeSpan
               AddDays(double value): добавляет к текущей дате несколько дней
               AddHours(double value): добавляет к текущей дате несколько часов
               AddMinutes(double value): добавляет к текущей дате несколькоминут
               AddMonths(int value): добавляет к текущей дате несколькомесяцев
               AddYears(int value): добавляет к текущей дате несколько лет*/
            DateTime myValue1 = DateTime.Now;
            Console.WriteLine(myValue1.ToString());
            Console.WriteLine(myValue1.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue1.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue1.AddDays(-3).ToLongDateString());
            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
            Console.WriteLine(date1.Subtract(date2)); // 03:00:00
            //5. Форматирование дат и времени с использованием строковых форматов
            DateTime now = DateTime.Now;
            Console.WriteLine($"D: {now.ToString("D")}");//полный формат даты
            Console.WriteLine($"d: {now.ToString("d")}");//краткий формат даты
            Console.WriteLine($"F: {now.ToString("F")}");//полный формат даты и времени
            Console.WriteLine($"f: {now.ToString("f")}");//полный формат даты и краткий формат времени
            Console.WriteLine($"G: {now.ToString("G")}");//краткий формат даты и полный формат времени
            Console.WriteLine($"g: {now.ToString("g")}");//краткий формат даты и времени
            Console.WriteLine($"M: {now:M}");//формат дней месяца
            Console.WriteLine($"O: {now:O}");//формат обратного преобразования даты и времени
            Console.WriteLine($"o: {now:o}");//формат обратного преобразования даты и времени
            Console.WriteLine($"R: {now:R}");//время по Гринвичу
            Console.WriteLine($"s: {now:s}");//сортируемый формат даты и времени
            Console.WriteLine($"T: {now:T}");//полный формат времени
            Console.WriteLine($"t: {now:t}");//краткий формат времени
            Console.WriteLine($"U: {now:U}");//полный универсальный полный формат даты и времени
            Console.WriteLine($"u: {now:u}");//краткий универсальный полный формат даты и времени
            Console.WriteLine($"Y: {now:Y}");//формат года
            Console.ReadLine();







        }
    }
}
