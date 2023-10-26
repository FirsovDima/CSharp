// Задание 1:Напишите программу которая на вход принимает два числа и выдает какое число больше, а какое меньше
// a=5; b=7; max = 7
// a=2; b=10; max = 10
// a=-9; b=-3; max = -3

System.Console.WriteLine("В ведите первое число");
    int a  = Convert.ToInt32 (Console.ReadLine ());
System.Console.WriteLine("В ведите  второе число");
    int b  = Convert.ToInt32 (Console.ReadLine ());
    if ( a>b )
    {
        System.Console.WriteLine("первое число max");
    }
    else
    {
        System.Console.WriteLine("второе число max");
    }