namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chiken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vege = double.Parse(Console.ReadLine());

            double totalprice = chiken * 10.35 + fish * 12.40 + vege * 8.15;
            double dessert = totalprice * 20 / 100;
            double grandtotal = totalprice + dessert +2.5;
            Console.WriteLine(grandtotal);


        }
    }
}