using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace FristProjectAssignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  First Project:

            #region 2.Override the ToString Function
            _3DPoint P = new _3DPoint(20, 10, 10);
            Console.WriteLine(P.ToString());

            #endregion
            #region 3.Read from the User the Coordinates for 2 points P1, P2
            ////3.Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //bool IsParsed;
            //double X,Y,Z;
            //do
            //{
            //    Console.WriteLine("Enter X for point 1 : ");
            //    IsParsed = double.TryParse(Console.ReadLine(), out X);
            //}while (!IsParsed);
            //do
            //{
            //    Console.WriteLine("Enter Y for point 1 : ");
            //    IsParsed = double.TryParse(Console.ReadLine(), out Y);
            //} while (!IsParsed);
            //do
            //{
            //    Console.WriteLine("Enter Z for point 1 : ");
            //    IsParsed = double.TryParse(Console.ReadLine(), out Z);
            //} while (!IsParsed);
            //_3DPoint point1 = new _3DPoint(X, Y, Z);

            //do
            //{
            //    Console.WriteLine("Enter X for point 2 : ");
            //    IsParsed = double.TryParse(Console.ReadLine(), out X);
            //} while (!IsParsed);
            //do
            //{
            //    Console.WriteLine("Enter Y for point 2 : ");
            //    IsParsed = double.TryParse(Console.ReadLine(), out Y);
            //} while (!IsParsed);
            //do
            //{
            //    Console.WriteLine("Enter Z for point 2 : ");
            //    IsParsed = double.TryParse(Console.ReadLine(), out Z);
            //} while (!IsParsed);
            //_3DPoint point2 = new _3DPoint(X, Y, Z);
            //Console.WriteLine(point1);
            //Console.WriteLine(point2);
            #endregion
            #region 4.Try to use ==
            //If(P1 == P2)   Does it work properly? 
            // Does not work becouse p1 is object and p2 is object cannot 
            //compare thier values but compare refrences values at heap where
            //p1 location is not p2 location 
            #endregion
            #region 5.Define an array of points and sort this array based on X & Y coordinates.
            _3DPoint[] array3D =
            {
                new _3DPoint(70, 80, 90),
                new _3DPoint(10, 20, 30),
                  new _3DPoint(40, 50, 60)
                    
            };
            Array.Sort(array3D);
            foreach (var point in array3D)
            {
                Console.WriteLine(point);
            }
            #endregion
            #region 6.Implement ICloneable interface to be able to clone the object.
            _3DPoint MainPoint = new _3DPoint(100, 200, 300);
            _3DPoint SecondPoint = (_3DPoint) MainPoint.Clone();
            Console.WriteLine(MainPoint);
            Console.WriteLine(SecondPoint);
            #endregion

            #endregion
        }
    }
}
