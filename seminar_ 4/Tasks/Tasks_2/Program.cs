//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInt(string text)
        {
            Console.Write(text);
            return Math.Abs(Convert.ToInt32(Console.ReadLine()));
        }


        int Sum(int number)
        {
            int sum = 0;
            int remind;

            while (number > 0)
            {
                remind = number % 10;
                sum += remind;
                number /= 10;
            }

            return sum;
        }


        int number = ReadInt("Введите число: ");

        int sum = Sum(number);

        Console.WriteLine($"Сумма цифр  {number} = {sum}");
    }
}