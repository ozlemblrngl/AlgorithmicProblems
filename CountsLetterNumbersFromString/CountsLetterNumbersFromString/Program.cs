internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("bir metin giriniz");
        string text = Console.ReadLine();

        Console.WriteLine("bir metin giriniz");
        string text2 = Console.ReadLine();



        char[] dizi1 = text.ToCharArray();
        char[] dizi2 = text2.ToCharArray();


        Array.Sort(dizi1);
        Array.Sort(dizi2);



        bool dogrumu = true;

        for (int i = 0; i < text.Length; i++)
        {
            if (dizi1[i] != dizi2[i])
            {
                dogrumu = false;
            }



        }
        if (dogrumu == true)
        {
            Console.WriteLine("Metinler Anagramdır");

        }
        else
        {
            Console.WriteLine("Metinler Anagram değildir");

        }
    }
}