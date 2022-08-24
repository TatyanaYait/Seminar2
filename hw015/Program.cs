Console.WriteLine("Введите число от 1 до 7 ");
int a = int.Parse(Console.ReadLine());

while ( a <= 0 || a >= 8)
    {
    Console.WriteLine("Введите число от 1 до 7 ");
    a = int.Parse(Console.ReadLine());
    }

if (a > 0 && a <= 5)
{
Console.WriteLine(a + " это рабочий день");
}
else 
{
Console.WriteLine(a + " это выходной день");
}  
    