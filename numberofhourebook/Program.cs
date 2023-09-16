namespace numberofhourebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            int totalhour = (page / day) / hour;
            Console.WriteLine(totalhour);
        }
    }
}