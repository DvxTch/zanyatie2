using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace занятие2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *** задание 1

            Console.WriteLine("Введите первое число:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine($"Сумма:{first + second}");
            Console.WriteLine($"Разность:{first - second}");
            Console.WriteLine($"Произведение:{first * second}");

            *** задание 2

            Console.WriteLine("Введите длину комнаты:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину комнаты:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine($"Площадь комнаты:{length * width}");
            Console.WriteLine($"Периметр комнаты:{2 * (length + width)}");

            *** задание 3

            Console.WriteLine("Сделал д/з? (true/false):");
            bool homework = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("сколько потратил минут на подготовку?:");
            int preparation = Convert.ToInt32(Console.ReadLine());
            double hours = Convert.ToDouble(preparation / 60);
            Console.WriteLine();
            
            Console.WriteLine($"Дз выполнено:{homework}");
            Console.WriteLine($"Время подготовки:{preparation} минут");
            Console.WriteLine($"Время в часах:{hours}");

            *** задание 4

            Console.WriteLine("Введите любое целое число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if (number == 0)
            {
                Console.WriteLine("Число равно нулю");
            }
            else if (number < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else if (number > 0)
            {
                Console.WriteLine("Число положительное");
            }

            *** задание 5

            Console.WriteLine("Введите любое целое число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if ((number % 2) == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }

            *** задание 6

            Console.WriteLine("Напишите свой возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if (age > 13)
            {
                Console.WriteLine("Вы можете записать на курс C#");
            }
            else
            {
                Console.WriteLine("вы пока не можете записаться на этот курс");
            }

            *** задание 7

            Console.WriteLine("Напишите первое число:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите второе число:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if (first == second)
            {
                Console.WriteLine("Числа равны");
            }
            else if (first > second)
            {
                Console.WriteLine("Первое число больше чем второе");
            }
            else
            {
                Console.WriteLine("Второе число больше первого");
            }

            *** задание 8

            Console.WriteLine("Введите количество баллов:");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if (mark > -1 && mark < 50)
            {
                Console.WriteLine("Оценка 2");
            }
            else if (mark > 49 && mark < 70)
            {
                Console.WriteLine("Оценка 3");
            }
            else if (mark > 69 && mark < 90)
            {
                Console.WriteLine("Оценка 4");
            }
            else if (mark > 89 && mark < 101)
            {
                Console.WriteLine("Оценка 5");
            }
            else
            {
                Console.WriteLine("Не балуйся мне тут!");
            }

            *** задание 9

            Console.WriteLine("День недели(Номер)?:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            switch (day)
            {
                case 1:
                    string WeekDay = "понедельник";
                    break;
            
                case 2:
                    string WeekDay = "вторник";
                    break;
            
                case 3:
                    string WeekDay = "среда";
                    break;
            
                case 4:
                    string WeekDay = "четверг";
                    break;
            
                case 5:
                    string WeekDay = "пятница";
                    break;
            
                case 6:
                    string WeekDay = "суббота";
                    break;
            
                case 7:
                    string WeekDay = "воскресенье";
                    break;
            }
            
            if (day > 7 || day < 1)
            {
                Console.WriteLine("Ошибка");
            }
            else 
            {
                Console.WriteLine($"Сегодня {WeekDay}");
            }   
            */
    }
}
