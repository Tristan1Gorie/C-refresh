namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sums();
            //SumOfThreeFactors();
            //DivisionBy0();
            //Operations();
            ValofFunctions();
        }

        public static void Sums()
        {
            Console.WriteLine("Enter integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            SumsSquared s = new SumsSquared(x);
        }

        public static void SumOfThreeFactors()
        {
            Console.WriteLine("Enter first num: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third num: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            ThreeFactors s = new ThreeFactors(x1,x2,x3);
        }

        public static void Division()
        {
            Console.WriteLine("Enter num: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
        }

        public static void DivisionBy0()
        {
            Console.WriteLine("Enter num: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num: ");
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("{0}/{1}= {2}", x, y, x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0");
            }
        }

        public static void Operations()
        {
            Console.WriteLine("Enter num: ");
            int x= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-6 + {0} x 5 = {1}",x, -6+x*5);
            Console.WriteLine("(13 - 2)x{0} = {1}", x, (13 - 2)*x);
            Console.WriteLine("({0} + -2) x (20 / 10) = {1}", x, (x + -2) * (20 / 10));
            Console.WriteLine("(12 + {0}) / (5 - 4) = {1}", x, (12 + x) / (5 - 4));
        }

        public static void ValofFunctions()
        {
            Console.WriteLine("Enter min range: ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max range: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            int y;
            for (int x = r1; x<=r2;x++)
            {
                y = x * x - 2 * x + 1;
                Console.Write("{0} ", y);
            }
        }
    }
}