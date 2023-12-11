using static System.Net.Mime.MediaTypeNames;

namespace Geometary_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 25; // Replace this with the integer for which you want to find the square root

            int result = MySqrt(x);

            Console.WriteLine($"Square root of {x} (floor): {result}");
        }

        public static void DrawSquare()
        {
            Console.WriteLine("Enter Number: ");
            string num= Console.ReadLine();
            Console.WriteLine("Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<=width; i++)
            {
                for (int j = 0; j<=width-1; j++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
            }
        }

        public static void DrawRectangle()
        {
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}{0}{0}", num);
            }
        }

        public static void DrawTriangle()
        {
            Console.WriteLine("Enter Number: ");
            string num = Console.ReadLine();
            Console.WriteLine("Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= width -1 ; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                width--;
            }
        }

        public static void DrawEastTriangle()
        {
            Console.WriteLine("Enter Width: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int width = 0;
            int max = height;

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(" ");
                }

                for (int symbols = 0; symbols < max; symbols++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                width++;
                max--;
            }
        }

        public static void StringTriangle()
        {
            Console.WriteLine("Enter String: ");

            string word= Console.ReadLine();
            int j = 1;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word.Substring(i, j));
                j++;
            }
        }

        public static void FunctionGraphic()
        {
            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int symbolCount = (i - 4) * (i - 4);
                
                for (int j = symbolCount; j!= 0;j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }

        public static void Square()
        {
            int n = 5;
            int[] arr = { 1, 2, 3, -2, 5 };

            int max_current = arr[0];
            int max_global = arr[0];

            for (int i = 1; i < n; i++)
            {
                // Update max_current to be the maximum of the current element and the sum so far
                max_current = Math.Max(arr[i], max_current + arr[i]);

                // Update max_global to be the maximum of its current value and max_current
                max_global = Math.Max(max_global, max_current);
            }

            Console.WriteLine($"Maximum subarray sum: {max_global}");
        }

        public static int MySqrt(int x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }

            double sqrtResult = Math.Sqrt(x);
            return (int)Math.Floor(sqrtResult);
        }
    }
}