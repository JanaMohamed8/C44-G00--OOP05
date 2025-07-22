namespace ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            //Output: Hours: 1, Minutes: 10, Seconds: 15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            //Output: Hours: 1, Minutes: 0, Seconds: 0

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            //Output: Hours: 2, Minutes: 10, Seconds: 0

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            //Output: Minutes: 11, Seconds: 6

            #region overloading 
            D3 = D1 + D2;
            Duration.normalize(D3);
            Console.WriteLine($"D3 after D1 + D2 {D3.ToString()}");
            D3 = D1 + 7800;
            Duration.normalize(D3);
            Console.WriteLine($"D3 after D1 + 7800 {D3.ToString()}");
            D3 = 666 + D3;
            Duration.normalize(D3);
            Console.WriteLine($"D3 after 666 + D3 {D3.ToString()}");
            D3 = ++D1;
            Duration.normalize(D3);
            Console.WriteLine($"D3 after ++D1 {D3.ToString()}");
            D3 = --D2;
            Duration.normalize(D3);
            Console.WriteLine($"D3 after --D2 {D3.ToString()}");
            D1 = D1 - D2;
            Duration.normalize(D1);
            Console.WriteLine($"D3 after D1 - D2 {D3.ToString()}");
           	if(D1 > D2)
            {
                Console.WriteLine("D1 > D2");
            }
            if (D1 <= D2)
            {
                Console.WriteLine("D1 <= D2");
            }

           	if(D1)
            {
                Console.WriteLine("valid D1");
            }
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);

            #endregion

        }
    }
}
