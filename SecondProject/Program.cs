namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsParsed;
            double FristValue, SecondValue;
            do
            {
                Console.WriteLine("Enter Value 1 : ");
                IsParsed = double.TryParse(Console.ReadLine(), out FristValue);
            } while (!IsParsed);
            do
            {
                Console.WriteLine("Enter Value 2 : ");
                IsParsed = double.TryParse(Console.ReadLine(), out SecondValue);
                if(SecondValue == 0 && IsParsed == true)
                {
                    IsParsed = false;
                    Console.WriteLine("Can not Divide by 0");
                }
            } while (!IsParsed);

            Console.WriteLine($"The result of {FristValue} + {SecondValue} = {Maths.Add(FristValue, SecondValue)}");
            Console.WriteLine($"The result of {FristValue} - {SecondValue} = {Maths.Subtract(FristValue, SecondValue)}");
            Console.WriteLine($"The result of {FristValue} / {SecondValue} = {Maths.Divide(FristValue, SecondValue)}");
            Console.WriteLine($"The result of {FristValue} * {SecondValue} = {Maths.Multiply(FristValue, SecondValue)}");

        }
    }
}
