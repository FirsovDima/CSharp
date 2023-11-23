// Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInt(string text)
        {
            int result;
            while (!int.TryParse(System.Console.ReadLine(), out result) || result <= 0)
            {
                System.Console.WriteLine("Ошибка ввода,введите  число > 0.");
                System.Console.Write(text);
            }
            return result;
        }

        void ShowNum(int num)
        {
            if (num == 0) return;
            System.Console.Write(num + ", ");
            ShowNum(num - 1);
        }

        //-----------------------------------------------------

        System.Console.WriteLine("Введите число N:");

        int number = ReadInt("Введите натуральное число N: ");

        ShowNum(number);
    }
}