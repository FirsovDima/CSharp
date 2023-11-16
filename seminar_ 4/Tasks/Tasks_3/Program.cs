//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

internal class Program
{
    private static void Main(string[] args)
    {
        int[] Array()
        {
            int[] numbers = new int[8];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число для элемента {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numbers;
        }


        int[] numbers = Array();

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i] + "," + " + "}");
        }
    }
}