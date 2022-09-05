// Реализовать алгоритм, который выводит на экран возрастающую
// последовательность случайных чисел от 1 до 1000. Как только сумма цифр
// очередного числа в последовательности достигнет 26, остановить генерацию,
// вывести на экран сообщение «Stop».

int random_number()
{
    int number = new Random().Next(1, 1000);
    return number;
}

int sum_digit(int number)
{
    int digit1 = number % 10;
    number = number / 10;
    int digit2 = number % 10;
    number = number / 10;
    int digit3 = number % 10;
    int sum = digit1 + digit2 + digit3;
    return sum;
}

int sum = 0;
int temp = 0;
while(sum < 26)
{
    int number = random_number();
    if(number > temp) 
    {
        Console.Write(number + " ");
        temp = number;
        sum = sum_digit(number);
        
    }
}

Console.Write("Stop");

