// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        int[] CreateArray()
        {
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число для элемента {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numbers;
        }
        int CountArray(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) count++;
            }
            return count;
        }


        int[] numbers = CreateArray();
        int zero = CountArray(numbers);


        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i] + "," + "  "}");
        }

        Console.WriteLine($"Количество элементов  больше ноля = {zero}");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}