internal class Program
{
    private static void Main(string[] args)
    {
        decimal number1 = 0;
        decimal number2 = 1;
        decimal number3;


        for (int i = 1; i < 100; i++)
        {

            number3 = number1 + number2;
            number1 = number2;
            number2 = number3;

            Console.WriteLine(i + 1 + ". sayı " + number3 + "-");
        }



        // 0,1,1,2,3,5,8,13,21
       
        Console.ReadLine();
    }
}