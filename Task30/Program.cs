// Покать кубы чисел, заканчивающихся на четную цифру.

Console.Write("Введите число, чтобы задать ряд натуральных чисел от 1 до N для возведения в куб: ");
int N = Int32.Parse(Console.ReadLine());


for (int i = 1; i <= N; i++)
{
    {
        Console.WriteLine();
        Console.Write(i + " ");
        if(i * i * i % 2 == 0) Console.Write(i * i * i + " ");
    }
}