/* Найти максимум из 9 чисел */

// 1. Первый способ. Стихийно.

/* int a1 = 23;
int a2 = 34;
int a3 = 276;
int a4 = 18;
int a5 = 0;
int a6 = 23;
int a7 = 2222;
int a8 = 15;
int a9 = 501;

int max = a1;

if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (a4 > max) max = a4;
if (a5 > max) max = a5;
if (a6 > max) max = a6;
if (a7 > max) max = a7;
if (a8 > max) max = a8;
if (a9 > max) max = a9;

Console.WriteLine(max); */

// 2. Второй способ. С помощью массива.

/* int[] array = { 23, 45, 6, 73, 8, 91, 2, 5, 27 }; */
/* int max = array[0];
int n = array.Length;
int index = 1;
while (index < n)
{
    if (array[index] > max)
    max = array[index];
    
index++;
}
Console.WriteLine (max); */

// 3. Третий способ. С помощью массива и функции. 

int Max(int a1,int a2,int a3)         // Max - функция, которая находит максимальное значение из 3-ч целых чисел
{
    int result = a1;
    if (a2 > result) result = a2;
    if (a3 > result) result = a3;
    return result;
}


int[] array = { 23, 45, 1006, 73, 8, 91, 2, 5, 27 };

/* int max1 = Max( array[0], array[1], array[2] ); 
int max2 = Max( array[3], array[4], array[5] );
int max3 = Max( array[6], array[7], array[8] ); */  // Это более длинная форма написания

int max = Max(
          Max( array[0], array[1], array[2] ),
          Max( array[3], array[4], array[5] ),
          Max( array[6], array[7], array[8] ));     // Форма записи покороче

Console.WriteLine(max);



