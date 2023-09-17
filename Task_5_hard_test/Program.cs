using System;
// Створіть програму, яка дозволяє вводити оцінки студента з різних предметів та обчислювати середню оцінку. Використовуйте масиви для зберігання оцінок. 
// Завдання повинно включати такі етапи:

//- Введення оцінок студента з різних предметів (наприклад, математика, історія, фізика).
//- Збереження цих оцінок у масивах.
//- Обчислення середньої оцінки студента на основі введених даних.
//- Виведення середньої оцінки на екран.
//- Масиви використовуються для зберігання оцінок студента, і програма має виводити результат на консоль.
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("""
                    1. Option 1
                    2. Option 2
                    3. Option 3
                    4. Exit
                    Choose an option:
                    """);
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Option 1 selected");
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    int numberofsubjects = 4;
                    double[] grades = new double[numberofsubjects];
                    string[] subjects = { "математика", "історія", "англійська мова", "інформатика" };
                    for (int i = 0; i < numberofsubjects; i++)
                    {
                        Console.Write($"введіть оцінку студента пирогов з предмету - {subjects[i]}: ");
                        grades[i] = double.Parse(Console.ReadLine());
                    }
                    break;
                case "2":
                    Console.WriteLine("Option 2 selected");
                    Console.WriteLine(grades[i]);
                    break;
                case "3":
                    Console.WriteLine("Option 3 selected");
                    // code for option 3
                    break;
                case "4":
                    Console.WriteLine("Exiting program");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
        //    Console.OutputEncoding = System.Text.Encoding.Unicode;
        //    int numberOfSubjects = 4;
        //    double[] grades = new double[numberOfSubjects];
        //    string[] subjects = { "Математика", "Історія", "Англійська мова", "Інформатика" };
        //    for (int i = 0; i < numberOfSubjects; i++)
        //    {
        //        Console.Write($"Введіть оцінку студента Пирогов з предмету - {subjects[i]}: ");
        //        grades[i] = double.Parse(Console.ReadLine());
        //    }
        ////average
        //    double sum = 0;
        //    for (int i = 0; i < numberOfSubjects; i++)
        //    {
        //        sum += grades[i];
        //    }
        //    double averageGrade = sum / numberOfSubjects;
        //    Console.WriteLine($"Середня оцінка студента Пирогов: {averageGrade:F2}");
        //    Console.ReadKey();
    }
}
