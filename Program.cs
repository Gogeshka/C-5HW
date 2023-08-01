/* Task 1

Console.Write("Какой будет размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandomNum(num);
PrintArray(num);
int count = 0;

for (int i = 0; i < num.Length; i++)
if (num[i] % 2 ==0 )
count++;
void RandomNum (int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine($"Чисел {num.Length}, {count} четных");
*/

/* Task 2
Console.Write("Какой будет размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandomNum(num);
PrintArray(num);
int count = 0;

for (int i = 0; i < num.Length; i+=2)
  count = count + num[i];

void RandomNum (int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine($"Чисел {num.Length}, сумма нечетных чисел - {count}");
*/

/* Task 3

Console.Write("Какой будет размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
RandomNum(num);
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max) max = num[i];

    if (num[i] < min) min = num[i];
}
void RandomNum (double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine($"Чисел {num.Length}. Максимальное - {max}, Минимальное - {min}");
Console.WriteLine($"Разница между ними = {max - min}");
*/