
//1) Знайти суму елементів масиву, які розміщуються на парних індексах
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Масив: ");
        Console.WriteLine(String.Join(",", numbers));
        Console.ResetColor(); // сбрасываем в стандартный
        int sum = 0;
        for (int i = 0; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Сума елементів на парних індексах: " + sum);
        Console.ReadKey();
    }
}
