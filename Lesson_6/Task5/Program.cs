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
                Console.WriteLine("Оберіть опцію:");
                Console.WriteLine("1. Ввести оцінки");
                Console.WriteLine("2. Переглянути введені оцінки");
                Console.WriteLine("3. Обчислити середню оцінку");
                Console.WriteLine("4. Вийти");
                Console.Write("Ваш вибір: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
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
                        Console.WriteLine("Дякуємо за використання програми!");
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
                Console.Write($"Введіть оцінку для предмету '{subject}': ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
                    {
                        grades[subject] = grade;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некоректний ввід. Будь ласка, введіть дійсне число від 0 до 100.");
                        Console.Write($"Введіть оцінку для предмету '{subject}': ");
                    }
                }
            }
        }

        static void DisplayGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine("Введені оцінки:");
            foreach (var kvp in grades)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
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
            foreach (var kvp in grades)
            {
                sum += kvp.Value;
            }
            double averageGrade = sum / grades.Count;

            Console.WriteLine($"Середня оцінка: {averageGrade:F2}");
        }
    }
}
