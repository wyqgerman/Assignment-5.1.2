namespace Assignment_5._1._2
{
    internal class Program
    {
        public static int SumOfDigits(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                sum += number % 10; 
                number /= 10;   
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int result = SumOfDigits(num);
            Console.WriteLine($"The sum of the digits of the number {num} is: {result}");
        }
    }
}
