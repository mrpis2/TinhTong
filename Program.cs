class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[5];
        numbers[0] = 3;
        numbers[1] = 7;
        numbers[2] = 9;
        numbers[3] = 11;
        numbers[4] = 15;
        int tong = 0;
        for (int i = 0; i <= numbers.Length-1; i++)
        {
            tong += numbers[i];
        }
        Console.WriteLine(tong);
    }
}