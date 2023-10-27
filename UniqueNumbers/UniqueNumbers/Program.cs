internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz.");
        string text = Console.ReadLine().ToLower();

        bool isUnique = true;

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = i + 1; j < text.Length; j++)
            {
                if (text[i] == text[j])
                {
                    Console.WriteLine("notUnique");
                    return;
                }

            }
        }

        Console.WriteLine("Unique");
    }
}