namespace Finding_the_unique_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to be stored in the array : ");
            int amount = int.Parse(Console.ReadLine());

            int[] numbers = new int[amount];
            int[] freq = new int[amount];

            // Input
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Element {i + 1} :");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Count frequencies
            for (int i = 0; i < amount; i++)
            {
                if (freq[i] == -1)
                    continue;

                int count = 1;

                for (int j = i + 1; j < amount; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        freq[j] = -1;
                    }
                }

                freq[i] = count;
            }

            // Print unique elements
            Console.WriteLine("The unique numbers in your array are : ");
            for (int i = 0; i < amount; i++)
            {
                if (freq[i] == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}

