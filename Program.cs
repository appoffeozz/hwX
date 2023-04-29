/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.WriteLine("Введите N:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN) { Console.WriteLine("Ошибка ввода, введено не число"); return; }
Print(n);
void Print(int n, int start = 1)
{
    if (start > n) { return; }
    Console.WriteLine(start);
    start++;
    
    Print(n, start);
}


/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите начало диапазона:");
bool isParsedStart = int.TryParse(Console.ReadLine(), out int start);
Console.WriteLine("Введите конец диапазона:");
bool isParsedStop = int.TryParse(Console.ReadLine(), out int stop);
if (!isParsedStart || !isParsedStop) { Console.WriteLine("Ошибка ввода, введено не число"); return;}
Print(stop);
void Print(int n)
{
    if (start > stop) { return; }
    Console.WriteLine(start);
    start++;
    
    Print(n);
}


/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/

Console.WriteLine("Введите число:");
bool isParsedn = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedn) { Console.WriteLine("Ошибка ввода, введено не число"); return;}
int result = SummElement(n);
Console.WriteLine(result);

int SummElement(int n)
{
    if (n <= 0) { return 0; }
    int summ = n % 10;
    n = n / 10;
    return SummElement(n) + summ;
}


/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/

Console.WriteLine("Введите число:");
int a = IsParsedInt();

Console.WriteLine("Введите его степень:");
int b = IsParsedInt();

int result = PowElement(a, b);

Console.WriteLine(result);


int PowElement(int a, int b)
{
    if (b <= 0) { return 1; }

    b--;

    return PowElement(a, b) * a;

}


int IsParsedInt()
{
        
    bool status = int.TryParse(Console.ReadLine(), out int a);
    if (status) {return a;}
    
    if (!status)
    {
        Console.WriteLine("Введено не число, повторите ввод");
    }

    return IsParsedInt();

}