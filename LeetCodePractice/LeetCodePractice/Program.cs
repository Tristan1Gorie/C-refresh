namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock();
        }

        /// <summary>
        /// Two sum problem
        /// </summary>
        public static void TwoSum()
        {
            int target = 18;
            int[] nums = { 2, 7, 11, 15 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"Target achived using: [{i},{j}]");
                        break;
                    }
                }
            }
        }


        public static void Stock()
        {
            int[] prices = { 7, 6, 4, 3, 1 };
            int max = prices.Max();
            int maxIndex= prices.ToList().IndexOf(max);
            int min = prices.Min();

            if (prices == null || prices.Length <= 1)
            {
                Console.WriteLine("0");
                return;
            }

            for(int i =0; i< prices.Length; i++)
            {
                if (prices[i]< max && prices.ToList().IndexOf(i)< maxIndex)
                {
                    Console.WriteLine(prices[i]);
                    break;
                }
            }
        }
    }
}