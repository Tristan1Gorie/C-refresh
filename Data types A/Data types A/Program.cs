namespace Data_types_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SphereDimensions();
            BasicCalc();
        }


        public static void SphereDimensions()
        {
            Console.WriteLine("Enter radius: ");
            float radius = Convert.ToSingle(Console.ReadLine());
            float pi = 3.1415926535f;

            float surface = 4 * pi * (radius * radius);
            float volume = 4 / 3 * pi * (radius * radius * radius);

            Console.WriteLine("Surface: " + surface);
            Console.WriteLine("Volume: " + volume);
        }

        public static void BasicCalc()
        {
            Console.WriteLine("Enter num1: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }
    }
}