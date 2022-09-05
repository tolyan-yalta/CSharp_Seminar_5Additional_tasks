// С клавиатуры вводится натуральное число N (N>100). 
// Выяснить, сколько «подчисел» имеет число N, а также сколько из них являются простыми.
// Введем понятие «подчисло». «Подчислом» числа N назовем число M, 
// которое составлено из его цифр, путем отсекания одной или более цифр справа или слева.

Console.WriteLine("Введите натуральное число N (N>100): ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0;

int array_length(int number)
{
    int length = 2;
    int temp = 99;
    while(temp < number)
    {
        if (number > temp)
        {
            length++;
        }
        temp = temp * 10 + 9;
    }
    return length;
}

int length1 = array_length(N);
int length2 = Math.Pow(length1);
int[,] array = new int [length1, length];

int category_numbers = 1;                       // Заполняем массив цифрами из числа
for(int i = 0; i < length1; i++)
{
    if(i = 0) array[i] = number % 10;
    category_numbers = category_numbers * 10;
    array[i] = number / category_numbers % 10;
}

