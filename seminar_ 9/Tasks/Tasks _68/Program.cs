//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int ReadInt(string text)

{
        int result;
        while (!int.TryParse(System.Console.ReadLine(), out result) || result <= 0)
        {
            System.Console.WriteLine("Ошибка ввода. введите натуральное число > 0.");
            System.Console.Write(text);
        }
        return result;
}

    int Acker(int M, int N)
    {
        if (M == 0)
            return N + 1;
        else if (N == 0)
            return Acker(M - 1, 1);
        else
            return Acker(M - 1, Acker(M, N - 1));
    }

        System.Console.Write("Введите M:");
        int numM = ReadInt("Введите число M:");

        System.Console.Write("Введите N:");
        int numN = ReadInt("Введите число N:");;

        int result = Acker(numM, numN);

        System.Console.WriteLine($"A({numM}, {numM}) = {result}");