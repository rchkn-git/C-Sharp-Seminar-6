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
    Console.WriteLine($"[{String.Join(",", FibArray)}]");
    break;
}