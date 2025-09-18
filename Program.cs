namespace namn
{
    internal class Program
    {
        static string FormatName(string first, string third)
        {
            return $"{first} {third}";
        }
        static string FormatName(string first, string second, string third)
        {
            return $"{first} {second} {third}";
        }
        static string FormatName(string first, string third, bool uppercase)
        {
            var full = $"{first} {third}";
            return uppercase ? full.ToUpper() : full;
        }
        static void Main(string[] args)
        {
            //skriver ut namnen i 3 olika format
         Console.WriteLine(FormatName("Sandra", "Jonsson"));
            Console.WriteLine(FormatName("Sandra", "Elisabet Maria", "Jonsson"));
                Console.WriteLine(FormatName("Sandra", "Jonsson\n", true));
            //skriver ut 3 nya namn i 3 olika format
        Console.WriteLine(FormatName("Martin", "Jonsson"));
            Console.WriteLine(FormatName("Martin", "Helmer", "Jonsson"));
                Console.WriteLine(FormatName("Martin", "Jonsson\n", true));
            //skriver ut ytterligare 3 nya namn i 3 olika format
        Console.WriteLine(FormatName("Evelina", "Jonsson"));
            Console.WriteLine(FormatName("Evelina", "Maria", "Jonsson"));
                Console.WriteLine(FormatName("Evelina", "Jonsson\n", true));
        }
    }
}
