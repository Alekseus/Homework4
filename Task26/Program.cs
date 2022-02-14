// Возведите число А в натуральную степень B, используя цикл.

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int b = Int32.Parse(Console.ReadLine());

int result = a;

for(int i = 1; i < b; i++)
{
    result = result * a;
}

System.Console.WriteLine($"{a} ^ {b} = {result}");
System.Console.WriteLine();