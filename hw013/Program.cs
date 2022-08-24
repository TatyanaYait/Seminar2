/*Console.WriteLine("Введите число ");
string a = Console.ReadLine();

if (a.Length >= 3)
{
     string b = a.Substring(2,1);
     Console.WriteLine (b);
}
else 
{
   Console.WriteLine ("третьей цифры нет ");
}*/

void FillArray(int[] numbA)
{
    int length = numbA.Length;
    int index = 0;
    while (index < length)
    {
        numbA[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] numbB)
{
    int count = numbB.Length;
    int posit = 0;
    while (posit < count)
    {
        Console.Write(numbB[posit]);
        posit++;
    }

}

Console.Write("Введите число X, определяющее размер массива: "); // x определяет сколькизначное число будет сгенерировано
int X = int.Parse(Console.ReadLine());

int[] array = new int[X];
FillArray(array);
PrintArray(array);
Console.WriteLine();

if (X >= 3)
{
    Console.WriteLine("третий элемент массива = " + array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}

