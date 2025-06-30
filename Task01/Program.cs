namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Islam's Carpet Cleaning Service!\n");
            Console.WriteLine("Charges:\n");
            Console.WriteLine("$25 per small\n");
            Console.WriteLine("$35 per large\n");
            Console.WriteLine("Sales tax rate is 6%\n");
            Console.WriteLine("Estimates are valid for 30 days\n");

            Console.WriteLine("Number of small carpets");
            int numberOfSmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets");
            int numberOfLargeCarpet = Convert.ToInt32(Console.ReadLine());

            int smallCarpetPrice = 25;

            int largeCarpetPrice = 35;

            double tax = 0.06;

            Console.WriteLine($"\nNumber of small carpets: {numberOfSmallCarpet} \n");
            Console.WriteLine($"Number of large carpets: {numberOfLargeCarpet} \n");
            Console.WriteLine($"Price per small room: {smallCarpetPrice} \n");
            Console.WriteLine($"Price per large room: {largeCarpetPrice} \n");
            
            int cost = smallCarpetPrice *numberOfSmallCarpet + largeCarpetPrice * numberOfLargeCarpet;

            Console.WriteLine($"Cost: {cost} \n");

            Console.WriteLine($"Tax: {tax * 100}% \n");
            Console.WriteLine("===============================\n");
            double totalEstimate = cost * tax + cost ;
            Console.WriteLine($"Total estimate: {totalEstimate} \n");
            Console.WriteLine("This estimate is valid for 30 days\n");






        }
    }
}
