// Имеется одномерный массив array из n элементов. Требуется найти элемент массива, равный find.

int[] array = {23, 4, 6, 146, 3058, 6, 4983, 343, 398};
int n = array.Length;
int index = 0;
int find = 6;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
        
    }
    index++;
      
    
    
    
}

Console.WriteLine("Индеса с таким элементом нет");