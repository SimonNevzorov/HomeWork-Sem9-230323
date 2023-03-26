// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a<b)
{
    int temp1 = a;
    a = b;
    a = temp1;
}

 int CountNumbers(int a, int b )
{   
    int result =a;
    if (a==b)
        return 0;
        else 
        {
         a++;
         result = a+ CountNumbers(a,b);
        return result;
        }
}


Console.WriteLine(CountNumbers(a-1,b));