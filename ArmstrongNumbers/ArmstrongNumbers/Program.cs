internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz:");

        int number = Convert.ToInt32(Console.ReadLine());
        int number2 = number;
        int sum = 0;
        int powNumber;

        while (number > 0)
        {
            powNumber = number % 10;
            sum = sum + (powNumber * powNumber * powNumber);
            number = number / 10;
        }

        if (number2 == sum)
        {
            Console.WriteLine("Girdiğiniz sayı bir Armstrong sayıdır.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı bir Armstrong sayı değildir.");
        }
    }
}