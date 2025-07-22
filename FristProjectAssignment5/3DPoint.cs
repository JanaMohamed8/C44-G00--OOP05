using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FristProjectAssignment5
{
    internal class _3DPoint:IComparable,ICloneable
    {
        #region property
        public double X { get; set; }
        public double Y { get; set; }

        public double Z { get; set; } 
        #endregion
        #region Define 3D Point Class and the basic Constructors
        //1.Define 3D Point Class and the basic Constructors(use chaining in constructors).

        public _3DPoint(double _X, double _Y, double _Z)
        {
            X = _X;
            Y = _Y;
            Z = _Z;
        }
        public _3DPoint(double _X, double _Y) : this(_X, _Y, 0)
        { }

        #endregion

        #region Override the ToString Function
        //2.Override the ToString Function to produce this output:
        //Point3D P = new Point3D(10, 10, 10);
        //Console.WriteLine(P.ToString( ));
        //Output: “Point Coordinates: (10, 10, 10)”.
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            _3DPoint ComparedPoint = (_3DPoint?) obj;
            if(this.X < ComparedPoint?.X && this.Y < ComparedPoint?.Y && this.Z < ComparedPoint?.Z)
                return -1;
            else if (this.X > ComparedPoint?.X && this.Y > ComparedPoint?.Y && this.Z > ComparedPoint?.Z)
                return 1;
            else 
                return 0;

        }

        public object Clone()
        {
           return new _3DPoint(X, Y, Z);
        }
        #endregion
    }
}
