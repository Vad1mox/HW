internal class Program
{
    private static void Main(string[] args)
    {
        int A = 161;

        int mult7 = A % 7;
        int mult23 = A % 23;

        if (mult7 == 0)
        {
            if (mult23 == 0)
            {
                Console.WriteLine("Кратно");
            }
            else
            {
                Console.WriteLine("Не_кратно");
            }
        }
        else
        {
            Console.WriteLine("Не_кратно");
        }
    }
}

internal class Program2
{
    private static void Main2(string[] args)
   {
         int X = 2;
        int Y = -3;

        if (X < 0)
        {
            if (Y < 0)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(2);
            }
         }
     else
     {
            if (Y < 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}