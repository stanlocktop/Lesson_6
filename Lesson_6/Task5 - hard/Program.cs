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
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int numberOfSubjects = 4;
        double[] grades = new double[numberOfSubjects];
        string[] subjects = { "Математика", "Історія", "Англійська мова", "Інформатика" };
        for (int i = 0; i < numberOfSubjects; i++)
        {
            Console.Write($"Введіть оцінку студента Пирогов з предмету - {subjects[i]}: ");
            grades[i] = double.Parse(Console.ReadLine());
        }
    //average
        double sum = 0;
        for (int i = 0; i < numberOfSubjects; i++)
        {
            sum += grades[i];
        }
        double averageGrade = sum / numberOfSubjects;
        Console.WriteLine($"Середня оцінка студента Пирогов: {averageGrade:F2}");
        Console.ReadKey();
    }
}
