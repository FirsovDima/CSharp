Console.Write ("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ( 99 < a && a < 1000) 
{
    Console.WriteLine($"{(a / 10)%10} - вторая цифра в числе {a}");
}
else 
{
    Console.WriteLine(" Число не трёхзначное");
}