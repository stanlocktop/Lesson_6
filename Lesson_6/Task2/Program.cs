
// 2) Знайти добуток елементів масиву, які більші за задане число.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        const int maxNumber = 10;
        int[] A = new int[maxNumber];
        int number;
        int i;
        int result;
        for (i = 0; i < maxNumber; i++)
        {
            A[i] = i;
        }
        number = 5;
        Console.WriteLine("Задане число: " + number);
        result = 1;
        for (i = 0; i < maxNumber; i++)
            if (A[i] > number)
                result = result * A[i];
        Console.WriteLine("Результат добутку елементів масиву, які більше за задане число: " + result);
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}
