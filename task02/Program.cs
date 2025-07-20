using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task02
{
    internal class Program
    {
        public static void Print(List<int> nums)
        {
            if (nums.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < nums.Count; i++)
                {
                    Console.Write($" {nums[i]} ");
                }
                Console.WriteLine("]");
            }
        }

        public static void Add(List<int> nums)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (nums.Contains(number))
            {
                Console.WriteLine("You already addedd this number before");
            }
            else
            {
                nums.Add(number);
                Console.WriteLine("Number added suucessfully !!");
            }
        }

        public static void Mean(List<int> nums)
        {
            double sum = 0;
            double total = 0;
            if (nums.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    sum += nums[i];
                }
                total = sum / nums.Count;
                Console.WriteLine($"Sum is: {sum}");

                Console.WriteLine($"Mean is: {total}");
            }
        }

        public static void Smallest(List<int> nums)
        {
            if (nums.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            }
            else
            {
                int minNum = nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] < minNum)
                        minNum = nums[i];
                }

                Console.WriteLine($"The largest number is: {minNum}");

            }
        }

        public static void Largest(List<int> nums)
        {
            if (nums.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
            }
            else
            {
                int maxNum = nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] > maxNum)
                        maxNum = nums[i];
                }

                Console.WriteLine($"The largest number is: {maxNum}");
            }
        }

        public static void Find(List<int> nums)
        {
            if (nums.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.WriteLine($"Write the number to find it.");
                int findNum = Convert.ToInt32(Console.ReadLine());
                if (nums.Contains(findNum))
                {

                    for (int i = 0; i < nums.Count; i++)
                    {
                        Console.WriteLine($"{findNum} is in the list.");

                        if (nums[i] == findNum)
                        {
                            Console.WriteLine($"{findNum} index number is {i}");
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"{findNum} is NOT in the list.");
                }
            }
        }

        public static void Clear(List<int> nums)
        {
            nums.Clear();
            Console.WriteLine("List empty");
        }

        static void Main(string[] args)
        {

            bool checkLetter = true;
            List<int> nums = new List<int>();

            do
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("P - Print Numbers");
                Console.WriteLine("A - Add number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largets number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear the whole list");
                Console.WriteLine("Q - Quit");

                char letter = Convert.ToChar(Console.ReadLine().ToUpper());


                if (letter == 'P')
                {
                    Print(nums);
                }
                else if (letter == 'A')
                {
                    Add(nums);
                }
                else if (letter == 'M')
                {


                }
                else if (letter == 'S')
                {
                    Smallest(nums);
                }
                else if (letter == 'L')

                {
                    Largest(nums);

                }


                else if (letter == 'F')
                {
                    Find(nums);
                }

                else if (letter == 'C')
                {
                    Clear(nums);
                }
                else if (letter == 'Q')
                {

                    checkLetter = false;

                }
            } while (checkLetter);











        }
    }
}
