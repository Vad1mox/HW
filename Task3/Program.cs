Random rnd = new Random();

Console.WriteLine("Введите размер массива");
string input = Console.ReadLine()!;
int size = Convert.ToInt32(input);

int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = rnd.Next(1, 99);
}
for (int i = 0; i < size; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine(" ");

int n = arr.Length - 1;
int target(int[] arr, int n)
{    
    
    if (n == 0)
    {
        return arr[0];
    }
    Console.Write($"{arr[n]} ");
    return target(arr, n - 1);
    
}
Console.Write($"{target(arr, n)} ");