/*Console.Write("Введите стороны треугольника через пробел: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if(IsTriangle(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2])))
{   
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool IsTriangle(int a, int b, int c)
{
        return (((a+b) >  c) && ((b+c) > a) && ((a+c) > b));
}
*/
/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string str1 = Convert.ToString(number, 2);

Console.WriteLine(number + " в двоичном виде = " + str1);
*/
/*
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8
int size = ReadInt("Введине, сколько первых чисел ряда Фибоначчи показать: ");
int[] FibArray = new int [size];
FibArray = getFib(FibArray);

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] getFib(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

switch (size)
{
    case 1:
    Console.WriteLine(FibArray[0]);
    break;
    case 2:
    Console.WriteLine($"[{String.Join(",", FibArray)}]");
    break;
    case <= 0:
    Console.WriteLine("Неверное значение массива.");
    break;
    default:
    Console.WriteLine($"[{String.Join(", ", FibArray)}]");
    break;
}
*/

// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

//генерируем рандомный массив
/*
int[] arrayNew = GetRandomArray(6, -10, 10);
Console.WriteLine($"[{String.Join(", ", arrayNew)}]");
Console.WriteLine($"[{String.Join(", ", CopyMyArray(arrayNew))}]");
*/

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


int[] CopyMyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// Решить 2 способами: 1) менять числа местами в исходном массиве;
// 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

int[] arrayA = GetRandomArray(6, -10, 10);
Console.WriteLine($"[{String.Join(", ", arrayA)}]");
//Console.WriteLine($"[{String.Join(", ", ArrayBackwardVar1(arrayA))}]");
Console.WriteLine($"[{String.Join(", ", ArrayBackwardVar2(arrayA))}]");

int[] ArrayBackwardVar1(int[] array)
{
    int len = array.Length;
    int buff = array[0];
    for(int i = 1; i <= (array.Length / 2); i++)
    {
        buff = array[len - i];
        array[len - i] = array[i - 1];
        array[i - 1] = buff;
    }
    return array;
}

int[] ArrayBackwardVar2(int[] array)
{
    int len = array.Length;
    int[] ArrayBackward = new int[len];
    for(int i = 0; i < len; i++)
    {
        ArrayBackward[i] = array[len - (i + 1)];
    }
    return ArrayBackward;
}