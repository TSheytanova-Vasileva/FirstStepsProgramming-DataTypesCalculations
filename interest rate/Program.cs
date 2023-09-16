namespace interest_rate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deposit = int.Parse(Console.ReadLine());
            int mount = int.Parse(Console.ReadLine());
            double annual = double.Parse(Console.ReadLine());

            double amount = deposit  + mount *(deposit  * annual) / 12;

            Console.WriteLine(amount);


        }
    }
}