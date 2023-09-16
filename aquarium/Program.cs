namespace aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volofaqua = (length * width * height) * .001;
            double totalper = percentage / 100;
            double reqlit = volofaqua * (1-totalper);
            Console.WriteLine($"{reqlit:f2}") ;

        }
    }
}