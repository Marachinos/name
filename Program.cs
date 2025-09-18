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
        Console.WriteLine(FormatName("Sandra", "Jonsson", true)); 
        }
    }
}
