//Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInt(string text)
        {
            int result;
            while (!int.TryParse(System.Console.ReadLine(), out result) || result <= 0)
            {
                System.Console.WriteLine("Ошибка ввода. Dведите натуральное число > 0.");
                System.Console.Write(text);
            }
            return result;
        }


        int SumNumbers(int M, int N)
        {
            int sum = 0;

            for (int i = M; i <= N; i++)
            {
                sum += i;
            }

            return sum;
        }

        System.Console.WriteLine("Введите начальное число M:");
        int numM = ReadInt("Введите натуральное число M:");
        Console.WriteLine("Введите конечное число N:");
        int numN = ReadInt("Введите натуральное число N:");
        if (numM > numN)
        {
            Console.WriteLine($"Ошибка: начальное число M > числа N");
            return;
        }

        System.Console.WriteLine($"Сумма чисел от M до N  {SumNumbers(numM, numN)}");
    }
}