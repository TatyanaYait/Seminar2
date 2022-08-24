Console.WriteLine("Введите трехзначное число ");
int a = int.Parse(Console.ReadLine());
//int N = a / 100;

while (a < 100 || a >= 1000)
{
    Console.WriteLine("Введите трехзначное число ");
    a = int.Parse(Console.ReadLine());
}

int num1 = a / 10;
int num2 = num1 % 10;

Console.WriteLine("Второй символ числа " + num2);
