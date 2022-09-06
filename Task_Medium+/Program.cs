// С клавиатуры вводится натуральное число N (N>100). 
// Выяснить, сколько «подчисел» имеет число N, а также сколько из них являются простыми.
// Введем понятие «подчисло». «Подчислом» числа N назовем число M, 
// которое составлено из его цифр, путем отсекания одной или более цифр справа или слева.

Console.WriteLine("Введите натуральное число N (N>100): ");
int number = Convert.ToInt32(Console.ReadLine());

int amount_digits(int number)   // Количество цифр в числе
{
    int amount = 1;
    int temp = 9;
    while(temp < number)
    {
        if (number > temp)
        {
            amount++;
        }
        temp = temp * 10 + 9;
    }
    return amount;
}

bool simple_number(int number)  // Проверка простое ли число
{
    bool result = false;
    for(int i = 2; i < number; i++)    
    { 
        if(number % i == 0) break;
        else if(i == number - 1)
        {
            result = true;
        }
    }
    return result;
}



int length = amount_digits(number);     // Определяем размер массива
int temp = length;
for(int i = 1; i < amount_digits(number) - 1; i++)
{
    length = length + (temp - i);
}

int[] array = new int [length];

int amount = amount_digits(number);
int amount1 = 1;
temp = number;
for(int i = 0; i < length; i++)     // Заполняем массив подчислами
{
    array[i] = temp % Convert.ToInt32(Math.Pow(10, amount1));
    temp = temp / 10;
    if(temp < Convert.ToInt32(Math.Pow(10, amount1 - 1))) 
    {
        amount1 += 1;
        temp = number;
    }
    if(amount1 == amount) break;
}

for(int i = 0; i < length; i++)     // Для наглядности выводим получившийся массив
{
    Console.Write(array[i] + " ");
}

for(int i = 0; i < length; i++)             // Проверка чисел на повторы
{
    for(int j = i + 1; j < length; j++)
    {
        if(array[i] == array[j]) array[j] = -1;
    }  
}

Console.WriteLine(" ");

for(int i = 0; i < length; i++)     // Для наглядности выводим получившийся массив 
{                                   // с повторами замененными на -1
    Console.Write(array[i] + " ");
}

int count1 = 0;
int count2 = 0;
bool result =false;
for(int i = 0; i < length; i++)     // Подсчет количества подчисел и прстых чисел
{
    if(array[i] >= 0) count1 += 1;
    result = simple_number(array[i]);
    if(result == true) count2 += 1;
    result =false;
}

Console.WriteLine("\nЧисло N имеет " + count1 + " подчисел, из них " + count2 + " являются простыми.");
