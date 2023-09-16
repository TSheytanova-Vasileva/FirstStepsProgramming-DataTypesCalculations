namespace basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double year = double.Parse(Console.ReadLine());

            double sneakers = year - (year * 0.4);
            double team = sneakers - (sneakers * 0.2);
            double basketball = team * 25 /100;
            double accessories = basketball * 20 / 100;
            double totalprice = (sneakers + team + basketball + accessories + year);
            Console.WriteLine(totalprice);
        }
    }
}