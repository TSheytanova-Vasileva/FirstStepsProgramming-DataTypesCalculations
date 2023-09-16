namespace craftmanhour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double paintthinner = double.Parse(Console.ReadLine());
            double craftmanhour = double.Parse(Console.ReadLine());

            double totalnaylon = (nylon + 2) * 1.5;
            double totalpaint = (paint + (paint * 0.1))* 14.5;
            double totalpaintthinner = paintthinner * 5;
            double material = (totalnaylon + totalpaint + totalpaintthinner + 0.4);
            double totalcraftman = material * 30/100 * craftmanhour;
            double totalprice = material+ totalcraftman;
            Console.WriteLine(totalprice);

            
        }
    }
}