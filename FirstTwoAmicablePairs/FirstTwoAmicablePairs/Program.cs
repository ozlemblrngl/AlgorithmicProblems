internal class Program
{
    private static void Main(string[] args)
    {
        int sum1 = 0;
        int sum2 = 0;
        int sayac = 2;
        for (int i = 2; ; i++)
        {
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                    sum1 += j;
            }

            for (int k = 2; k < i; k++)
            {
                for (int l = 1; l < k; l++)
                {
                    if (k % l == 0)
                        sum2 += l;
                }

                if (sum1 == k && sum2 == i)
                {
                    Console.WriteLine($"{i}, {k}");
                    sayac--;
                }

                sum2 = 0;
            }

            sum1 = 0;
            if (sayac == 0)
                break;
        }
    }
}
