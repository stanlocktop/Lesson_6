using System;
using System.Collections.Generic;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> grades = new Dictionary<string, double>();
            int choice;

            do
            { 
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
                Console.WriteLine("Оберіть опцію:");
                Console.WriteLine("1. Ввести оцінки для студента Пирогов.");
                Console.WriteLine("2. Переглянути введені оцінки студента Пирогов.");
                Console.WriteLine("3. Обчислити середню оцінку предметів студента Пирогов.");
                Console.WriteLine("4. Вийти з програми.");
                Console.ResetColor(); // сбрасываем в стандартный
                Console.ForegroundColor = ConsoleColor.Magenta; // устанавливаем цвет
                Console.Write("Ваш вибір: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                    Console.ResetColor(); // сбрасываем в стандартный
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                {
                    Console.WriteLine("Некоректний ввід. Будь ласка, введіть число від 1 до 4.");
                }
                switch (choice)
                {
                    case 1:
                        InputGrades(grades);
                        break;
                    case 2:
                        DisplayGrades(grades);
                        break;
                    case 3:
                        CalculateAverage(grades);
                        break;
                    case 4:
                        Console.WriteLine("Вихід!");
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір. Будь ласка, оберіть опцію від 1 до 4.");
                        break;
                }

            } while (choice != 4);
        }

        static void InputGrades(Dictionary<string, double> grades)
        {
            string[] subjects = { "Математика", "Історія", "Інформатика", "Англійська мова" };

            foreach (string subject in subjects)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
                Console.Write($"Введіть оцінку для предмету '{subject}': ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 1 && grade <= 12)
                    {
                        grades[subject] = grade;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некоректний ввід. Будь ласка, введіть дійсне число від 1 до 12.");
                        Console.Write($"Введіть оцінку для предмету '{subject}': ");
                    }
                }
            }
        }

        static void DisplayGrades(Dictionary<string, double> grades)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine("Введені оцінки:");
            foreach (var input in grades)
            {
                Console.WriteLine($"{input.Key}: {input.Value}");
                Console.ResetColor(); // сбрасываем в стандартный
            }
        }

        static void CalculateAverage(Dictionary<string, double> grades)
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("Немає введених оцінок для обчислення середньої оцінки.");
                return;
            }

            double sum = 0;
            foreach (var input in grades)
            {
                sum += input.Value;
            }
            double averageGrade = sum / grades.Count;

            Console.WriteLine($"Середня оцінка: {averageGrade:F2}");
        }
    }
}
