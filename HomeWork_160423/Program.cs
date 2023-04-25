using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_160423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*        Можно раскомментировать строку для пропуска задачи
            //Здесь закомментировал вывод на английском языке (в моей версии почему-то не выводятся русские символы)
            Console.WriteLine("\n\t\t*** Задание 1. Задача 1. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 1. ***\n");
            Console.WriteLine("\nПользователь вводит с клавиатуры число в диапазоне от 1 до 100.\n" +
                "Если число кратно 3(делится на 3 без остатка) нужно вывести слово Fizz.\n" +
                "Если число кратно 5 нужно вывести слово Buzz.\n" +
                "Если число кратно 3 и 5 нужно вывести Fizz Buzz.\n" +
                "Если число не кратно не 3 и 5 нужно вывести само число.\n" +
                "Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.\n");
            Console.WriteLine("Введите число в диапазоне от 1 до 100: ");
            //Console.Write("Input number from 1 to 100: ");
            int number = 0;
            do
            {
                if (number != 0)
                {
                    Console.WriteLine("Error! Ошибка! Введено число, не входящее в диапазон от 1 до 100. Попробуйте еще раз.");
                }
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 1 || number > 100);
            //Здесь и далее закомментировал строки первой версии решения, строки, относящиеся только ко второй версии отмечены символом '//'
            //bool output = false;
            string output = "";//
            if (number % 3 == 0)
            {
                output += "Fizz ";//
                //Console.Write("Fizz ");
                //output = true;
            }
            if (number % 5 == 0)
            {
                output += "Buzz";//
                //Console.Write("Buzz");
                //output = true;
            }
            if (output.Length == 0)//(output == false)
            {
                output += number;//
                //Console.Write(number);
            }
            //Console.WriteLine();
            Console.WriteLine(output);//
            //*/

            //////////////////////////////////////////////////////////////////////////////////////////////

            ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 1. Задача 2. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 2. ***\n");
            Console.WriteLine("\nПользователь вводит с клавиатуры два числа." +
                "Первое число — это значение, второе число процент, который необходимо посчитать." +
                "Например, мы ввели с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90." +
                "Результат: 9.\n");
            //Console.WriteLine("Input two numbers, first number: ");
            Console.WriteLine("Введите два числа, первое (число, проценты от которого нужно вычислить): ");
            int first = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second number: ");
            Console.WriteLine("Второе число (проценты, которые нужно вычислить от первого числа): ");
            int second = Convert.ToInt32(Console.ReadLine());
            double result = first * 0.01 * second;
            Console.WriteLine(result);
            //*/

            //////////////////////////////////////////////////////////////////////////////////////////////

            ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 1. Задача 3. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 3. ***\n");
            Console.WriteLine("\nПользователь вводит с клавиатуры четыре цифры. " +
                "Необходимо создать число, содержащее эти цифры. " +
                "Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.\n");
            Console.Write("Введите 4 цифры: ");
            int first_symbol = Convert.ToInt32(Console.ReadLine());
            int second_symbol = Convert.ToInt32(Console.ReadLine());
            int third_symbol = Convert.ToInt32(Console.ReadLine());
            int fourth_symbol = Convert.ToInt32(Console.ReadLine());
            int res = first_symbol * 1000 + second_symbol * 100 + third_symbol * 10 + fourth_symbol;
            Console.WriteLine(res);
            //*/

            //////////////////////////////////////////////////////////////////////////////////////////////

            ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 1. Задача 4. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 4. ***\n");
            Console.WriteLine("\nПользователь вводит шестизначное число." +
                "После чего пользователь вводит номера разрядов для обмена цифр." +
                "Например, если пользователь ввёл один и шесть — это значит, " +
                "что надо обменять местами первую и шестую цифры." +
                "Число 723895 должно превратиться в 523897." +
                "Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.\n");
            int input = 0;
            int size = 6;//принцип "Magic"
            Console.Write($"Введите {size}-значное число: ");
            do
            {
                if (input != 0)
                {
                    Console.WriteLine($"Error! Ошибка! Вы ввели не {size}-значное число. Попробуйте ещё раз.");
                }
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < 100000 || input > 999999);
            Console.WriteLine("Введите номер первого разряда, который желаете поменять: ");
            int digit_1 = 0, digit_2 = 0;
            do
            {
                if (digit_1 != 0)
                {
                    Console.WriteLine($"Error! Ошибка! Вы ввели номер несуществующего разряда. Введите число от 1 до {size}:");
                }
                digit_1 = Convert.ToInt32(Console.ReadLine());
            } while (digit_1 < 1 || digit_1 > size);
            Console.WriteLine("Введите номер второго разряда, который желаете поменять: ");
            do
            {
                if (digit_2 == digit_1)
                {
                    Console.WriteLine("Вы ввели номер разряда, который уже выбран. Нельзя поменять цифру саму с собой.");
                    digit_2 = 0;
                }
                if (digit_2 != 0)
                {
                    Console.WriteLine($"Error! Ошибка! Вы ввели номер несуществующего разряда. Введите число от 1 до {size}:");
                }
                digit_2 = Convert.ToInt32(Console.ReadLine());
            } while (digit_1 == digit_2 || digit_2 < 1 || digit_2 > 6);
            int[] output2 = new int[size];
            for (int i = size - 1; i >= 0; i--)
            {
                output2[i] = input % 10;
                input /= 10;
            }
            for (int i = 0; i < size; i++)
            {
                int buffer;
                if (i == digit_1 - 1)
                {
                    buffer = output2[digit_1 - 1];
                    output2[i] = output2[digit_2 - 1];
                    output2[digit_2 - 1] = buffer;
                }
            }
            int result3 = 0;
            for (int i = 0; i < size; i++)
            {
                result3 *= 10;
                result3 += output2[i];
            }
            Console.WriteLine(result3);
            //*/

            //////////////////////////////////////////////////////////////////////////////////////////////

            ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 1. Задача 5. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 5. ***\n");
            Console.WriteLine("\nПользователь вводит с клавиатуры дату." +
                "Приложение должно отобразить название сезона и дня недели." +
                "Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday\n");
            Console.WriteLine("Введите дату в формате DD.MM.YYYY: ");
            string input_date = Console.ReadLine();
            string[] date = input_date.Split('.', ',', ':');
            int[] int_date = new int[date.Length];
            for (int i = 0; i < date.Length; i++)
            {
                int_date[i] = Convert.ToInt32(date[i]);
            }
            switch (int_date[1])
            {
                case 1:
                case 2:
                case 12:
                    Console.Write("Зима (Winter) ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("Весна (Spring) ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Лето (Summer) ");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Осень (Autumn) ");
                    break;
                default:
                    Console.Write("Дата указана неверно.");
                    break;
            }
            DateTime dateValue = new DateTime(int_date[2], int_date[1], int_date[0]);
            Console.WriteLine(dateValue.ToString("dddd"));
            //*/

            //////////////////////////////////////////////////////////////////////////////////////////////

            ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 1. Задача 6. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 6. ***\n");
            Console.WriteLine("\nПользователь вводит с клавиатуры показания температуры." +
                "В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.\n");
            Console.WriteLine("Введите показания температуры: ");
            double input_temperature = Convert.ToDouble(Console.ReadLine());
            Console.Write("Выберите шкалу Цельсия или Фаренгейта: ");
            char scale = Convert.ToChar(Console.ReadLine());
            double output_temperature;
            bool farengeit = false;
            switch (scale)
            {
                case 'Y':
                case 'y':
                case 'C':
                case 'c':
                case 'ц':
                case 'Ц':
                case '1':
                    output_temperature = (input_temperature + 32) * 9 / 5;
                    break;
                default:
                    output_temperature = (input_temperature - 32) * 5 / 9;
                    farengeit = true;
                    break;
            }
            Console.WriteLine($"Температура {output_temperature:0.##}" + "градусов " + (farengeit ? "Фаренгейта" : "Цельсия"));
            //*/

            //////////////////////////////////////////////////////////////////////////////////////////////

            ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 1. Задача 7. ***\n");
            //Console.WriteLine("\n\t\t*** Task 1. Task 7. ***\n");
            Console.WriteLine("\nПользователь вводит с клавиатуры два числа. " +
                "Нужно показать все четные числа в указанном диапазоне. " +
                "Если границы диапазона указаны неправильно, требуется произвести нормализацию границ." +
                "Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.\n");
            Console.WriteLine("Введите начало и конец диапазона для показа четных чисел: ");
            int begin, end, input_1, input_2;
            input_1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                input_2 = Convert.ToInt32(Console.ReadLine());
                if (input_2 == input_1)
                {
                    Console.WriteLine("Error! Ошибка! Диапазон не может заканчиваться там же, где и начинается.");
                }
            } while (input_1 == input_2);
            if (input_1 < input_2)
            {
                begin = input_1;
                end = input_2;
            }
            else
            {
                begin = input_2;
                end = input_1;
            }
            Console.Write($"Четные числа диапазона от {begin} до {end} включительно: ");
            for (int i = begin; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    if (i == end || i == end - 1)
                    {
                        Console.WriteLine('.');
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            }
            //*/
        }
    }
}
