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
        }
    }
}