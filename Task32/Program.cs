// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран


Console.Clear();

int[] array = new int[8];


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();