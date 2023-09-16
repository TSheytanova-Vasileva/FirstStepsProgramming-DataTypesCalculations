namespace interest_rate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double totalamount = amount + (months * ((amount * interest/100) / 12));
            Console.WriteLine(totalamount);
        }
    }
}

    
    

            