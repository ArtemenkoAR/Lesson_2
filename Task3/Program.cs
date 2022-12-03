// 1. Возмем метод, заполним его массивом из случайных чисел и выведем в терминал.

void FillArray (int[] fill)
{
    int length = fill.Length;
    int index = 0;
    while (index < length)
    {
        fill[index] = new Random().Next(1, 10);
        index++;
    }
}  

void PrintArray (int[] print)
{
    int count = print.Length;
    int i = 0;
        while (i < count)
    {
        Console.WriteLine(print[i]);
        i++;
    }
}

int IndexOf(int[] fill, int find)
{
    int n = fill.Length;
    int index = 0;
    int x = 0;

    while (index < n)
    {
        if (fill[index] == find)
        {
            x = index;
        }
        break;
        index++;
    }
    return x;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 6);
Console.WriteLine(pos);
