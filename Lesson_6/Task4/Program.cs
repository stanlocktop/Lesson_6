using System;
// 4) Відсортуйте введений список прізвищ за алфавітом та виведіть його на екран.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        string[] array = { "Пирогов", "Шемет", "Козаченко", "Бекіров", "Абдураімов" };
        Console.WriteLine("Початковий список прізвищ, який будемо сортувати за алфавітом: ");
        Console.WriteLine(String.Join(", ", array));
        Console.ResetColor(); // сбрасываем в стандартный
        Array.Sort(array);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Список прізвищ, відсортований за алфавітом: ");
        Console.WriteLine(String.Join(", ", array));
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}
