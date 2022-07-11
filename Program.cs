Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB){
    Console.WriteLine("numberA максимальное");
}
else
{
    Console.WriteLine("numberB максимальное");
}

if (numberB > numberC){
    Console.WriteLine("numberB максимальное");
}
else
{
    Console.WriteLine("numberC максимальное");
}
    if (numberC > numberA){
    Console.WriteLine("numberC максимальное");
    }
    else
{
    Console.WriteLine("numberA максимальное");
}
Console.WriteLine();