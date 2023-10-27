internal class Program
{
    private static void Main(string[] args)
    {
        //tobeto
        Console.WriteLine("Bir yazı giriniz.");
        string text = Console.ReadLine();

        var harfler = text.GroupBy(group => group);

        foreach (var group in harfler)
        {
            Console.WriteLine(group.Count() + " adet " + group.Key);

        }

        Console.ReadLine();
    }
}