
// 3) Задано квадратну матрицю цілих чисел. Підрахуйте кількість негативних та позитивних елементів.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        int size = 5;
        Random random = new Random();
        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(-100, 101);
            }
        }
        int positiveCount = 0;
        int negativeCount = 0;

        // проходимо по всім елементам матриці
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int element = matrix[i, j];

                // перевірка на негативні на позитивні елементи матриці
                if (element > 0)
                {
                    positiveCount++;
                }
                else if (element < 0)
                {
                    negativeCount++;
                }
            }
        }

        Console.WriteLine("Матриця створена за допомогою Random: ");

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ResetColor(); // сбрасываем в стандартный
        Console.WriteLine();
        // Виводимо результати
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Кількість позитивних елементів матриці: " + positiveCount);
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
        Console.WriteLine("Кількість негативних елементів матриці: " + negativeCount);
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}
