using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplesHW
{
    internal class Program
    {
        static void Main()
        {
            // Пример 1: Тернарный оператор с условием внутри
            int x = 5;
            int y = 10;
            int result = (x > y) ? (x * 2) : (y / 2);

            // Пример 2: Побитовые операторы
            int a = 7;
            int b = 12;
            int result2 = (a & b) | (a << 2);

            // Пример 3: Использование оператора возведения в степень
            double baseNumber = 2.5;
            int exponent = 3;
            double result3 = Math.Pow(baseNumber, exponent);

            // Пример 4: Операторы инкремента и декремента в выражении
            int count = 5;
            int result4 = (++count * 3) + (count--);

            // Пример 5: Сложное условие с использованием логических операторов
            int num1 = 8;
            int num2 = 12;
            bool condition = (num1 > 5) && (num2 < 15) || (num1 % 2 == 0);

            // Пример 6: Использование оператора switch с выражением
            int dayOfWeek = 3;
            string dayName = GetDayName(dayOfWeek);

            // Пример 7: Сложные математические операции
            double a7 = 3.5;
            double b7 = 2.2;
            double result7 = Math.Sqrt(a7 * a7 + b7 * b7) / (a7 + b7);

            // Пример 8: Оператор приведения типа с использованием as
            object someObject = "Это строка";
            string stringValue = someObject as string ?? "По умолчанию";

            // Пример 9: Использование условного оператора с null-объединением
            string username = GetUser() ?? "Гость";

            // Пример 10: Оператор объединения null-условий с логическим оператором
            int? nullableValue = GetNullableValue();
            bool condition10 = nullableValue.HasValue && (nullableValue.Value > 0);
        }

        // Допустим, это функции, которые используются в коде выше
        static string GetUser()
        {
            // Возвращаем имя пользователя или null, если пользователя нет
            return "Пользователь";
        }

        static int? GetNullableValue()
        {
            // Возвращаем значение или null, если его нет
            return 42;
        }

        // Дополнительная функция для Примера 6
        static string GetDayName(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                default: return "День недели";
            }
        }
    }
}
