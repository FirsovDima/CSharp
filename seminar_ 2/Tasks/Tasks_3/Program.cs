//Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.Write ("Введите номер дня недели: ") ;
int day = Convert.ToInt32(Console.ReadLine()) ;
if ( day >= 1 && day <= 5) 
{
    Console.WriteLine(" будний день") ;
}
else if ( day == 6) 
{
    Console.WriteLine($"{day} день недели - суббота - выходной") ;
}
else if ( day == 7) 
{
    Console.WriteLine($"{day} день недели - воскоесенье - выходной") ;
}
else
{
    Console.WriteLine(" В неделе  7 дней.") ;
}
    

