//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
void FillArray(int[] array)
{
    int length = array.Length;

    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(1, 100);// так как в условии задачи программа задает числа, поэтому я взял рандом от 1 до 99.
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write(col[position] + "  ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);