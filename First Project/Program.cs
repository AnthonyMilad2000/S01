namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            System.Console.WriteLine("Enter Your favorite number from 1 to 100: ");

            //output
            int favNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"No really!!, {favNumber} is my favorite number!");
        }
    }
}
