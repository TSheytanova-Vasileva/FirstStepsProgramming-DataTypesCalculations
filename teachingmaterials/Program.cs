namespace teachingmaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageofPen = double.Parse(Console.ReadLine());
            double packageofmarkets = double.Parse(Console.ReadLine());
            double boardclearner = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double totalprice =( packageofPen * 5.8 + packageofmarkets * 7.2 + boardclearner * 1.2) - ((packageofPen * 5.8 + packageofmarkets * 7.2 + boardclearner * 1.2)* discount / 100);
            Console.WriteLine(totalprice);

        }
    }
}