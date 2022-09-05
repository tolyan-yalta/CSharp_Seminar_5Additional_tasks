// Михаил интересуется созданием простых чисел. Его интересуют
// простые числа с некоторыми характеристиками:
// • число сгенерировано случайным образом;
// • его квадрат не оканчивается на 1;
// • сумма его цифр лежит в диапазоне от 10 до 20
// Сгенерировать пять простых чисел, удовлетворяющих пожеланиям Михаила, 
// и вывести их на экран.

int random_number()
{
    int number = new Random().Next(1, 1000);
    return number;
}

int random_simple_number()
{
int simple_number = 0;
bool result = false;

while(result != true)
{
    int number = random_number();
    for(int i = 2; i < number; i++)    
    { 
        if(number % i == 0) break;
        else if(i == number - 1)
            {
                result = true;
                simple_number = number;
            }
    }
    
}
return simple_number;
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


for(int i = 0; i < 5;)
{
    bool condition1 = false;
    bool condition2 = false;

    int simple_number = random_simple_number();

    int square = simple_number * simple_number;
    int last_digit = square % 10;
    if(last_digit != 1) condition1 = true;

    int sum = sum_digit(simple_number);
    if(sum > 10 && sum < 20)   condition2 = true;

    if(condition1 == true && condition2 == true)
    {
        //Console.WriteLine("Простое число: " + simple_number + " (его квадрат " + square + " , сумма цифр: " +sum + " )");
        Console.Write($"{simple_number} ");
        i += 1;
    }
}

