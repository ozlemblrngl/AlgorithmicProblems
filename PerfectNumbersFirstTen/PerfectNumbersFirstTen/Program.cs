using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //decimal sum = 0;
        //int sayac = 0;
        //decimal i = 1;


        //decimal[] dizi = new decimal[10];

        //while (sayac <5 )
        //{

        //    i++;

        //    for (decimal j = 1;  j < i; j++)
        //    {

        //        if (i % j == 0) 
        //        {
        //            sum += j;    
        //        }

        //    }

        //     if( i == sum)
        //    {

        //        dizi[sayac] = sum;
        //        sayac++;
        //    }

        //    sum = 0;
        //}

        //foreach (decimal k in dizi)
        //{
        //    Console.WriteLine(k);
        //}

        //Console.ReadLine();

        BigInteger p = 2;
        BigInteger sayac = 1;
        while (sayac <= 10)
        {
            if (p == 2 || p % 2 == 1)
            {
                Console.WriteLine(PerfectFormula(p));
                p++;
                sayac++;
            }
            else
            {
                p++;
                continue;
            }
        }
    }
    static BigInteger PerfectFormula(BigInteger p)
    {
        return UsAlma(2, p - 1) * (UsAlma(2, p) - 1);
    }
    static BigInteger UsAlma(BigInteger taban, BigInteger us)
    {
        BigInteger sonuc = 1;
        for (BigInteger i = 0; i < us; i++)
        {
            sonuc *= taban;
        }
        return sonuc;


    }
}
