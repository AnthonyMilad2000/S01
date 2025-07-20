namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the word");

            string word = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'o' || word[i] == 'e' || word[i] == 'i' || word[i] == 'u')
                {
                    sum++;
                }
                
            }
         Console.WriteLine(sum);
        }
    }
}
