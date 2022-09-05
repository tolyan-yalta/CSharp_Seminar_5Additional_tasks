// Сгенерировать массив из N случайных натуральных чисел. 
// Определить, сколько в нем подъемов.
// Под подъемом в массиве будем понимать его подпоследовательность из
// двух и более элементов, которая не убывает. Подъем заканчивается, если
// встретился элемент, меньший предыдущего или достигнут конец массива.

int random_number(int min, int max)
{
    int number = new Random().Next(min, max);
    return number;
}

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество элементов в массиве N: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];
Console.Write("array[i]: ");

array[0] = random_number(min, max);
Console.Write($"{array[0]} ");

array[1] = random_number(min, max);
Console.Write($"{array[1]} ");

int count = 0;
int temp1 = array[0];
int temp2 = array[1];

if(temp2 > temp1) 
{
    count = 1;
}

for(int i = 2; i < length; i++)
{
    array[i] = random_number(min, max);
    Console.Write($"{array[i]} ");
    if(temp1 > temp2 && temp2 < array[i]) count += 1;

    temp1 = temp2;
    temp2 = array[i];
}

Console.WriteLine("\nВ массиве " + count + " подъемов");

