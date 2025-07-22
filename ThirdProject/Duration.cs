using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class Duration
    {
        //1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds
        #region Attributes
        private int Hours, Minutes, Seconds;
        #endregion

        #region 3.Define All Required Constructors to Produce this output:

        #region paramless
        public Duration()
        {
            
        }
        #endregion

        #region EX1
        //Duration D1 =new  Duration (1,10,15);
        //D1.ToString(); 
        //Output: Hours: 1, Minutes :10, Seconds :15

        public Duration(int _Hours, int _Minutes, int _Seconds)
        { 
            Minutes = _Minutes ;
            Seconds = _Seconds;
            Hours = _Hours;           
        }
        #endregion
        #region EX2
        //Duration D1 = new Duration(3600);
        //D1.ToString(); 
        //Output: Hours: 1, Minutes :0, Seconds :0
        public Duration(int _Seconds)
        {
            Hours = _Seconds / (60 * 60);
            _Seconds = _Seconds % (60 * 60);
            Minutes = _Seconds / 60;
            Seconds = _Seconds % 60;
        }
        #endregion

        #endregion

        #region 2.Override All System.Object Members (ToString, Equals,GetHasCode) .
        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
        
            else
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            Duration Compared = (Duration?)obj;
            if (Compared.Hours == this.Hours && Compared.Minutes == this.Minutes && Compared.Seconds == this.Seconds)
                return true;
            else return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region 4.Implement All required Operators overloading to enable this Code:
        #region Binary OverLoading

        public static Duration operator +(Duration frist , Duration second)
        {
            return new Duration()
            {
                Hours = (frist?.Hours??0) + (second?.Hours?? 0),
                Seconds = (frist?.Seconds?? 0 ) + (second?.Seconds?? 0),
                Minutes = (frist?.Minutes?? 0 ) + (second?.Minutes?? 0)
            };
        }

        public static Duration operator -(Duration frist, Duration second)
        {
            return new Duration()
            {
                //null? if null hours = 0
                Hours = (frist?.Hours ?? 0) - (second?.Hours ?? 0),
                Seconds = (frist?.Seconds ?? 0) - (second?.Seconds ?? 0),
                Minutes = (frist?.Minutes ?? 0) - (second?.Minutes ?? 0)
            };
        }

        public static Duration operator +(Duration frist, int seconds)
        {
            return new Duration()
            {
                //null? if null hours = 0
                Hours = (frist?.Hours ?? 0),
                Seconds = (frist?.Seconds ?? 0) + seconds,
                Minutes = (frist?.Minutes ?? 0) 
            };
        }

        public static Duration operator +( int seconds,Duration frist)
        {
            return new Duration()
            {
                //null? if null hours = 0
                Hours = (frist?.Hours ?? 0),
                Seconds = (frist?.Seconds ?? 0) + seconds,
                Minutes = (frist?.Minutes ?? 0)
            };
        }

        #endregion
        #region Unary OverLoading

        public static Duration operator ++(Duration frist)
        {
            return new Duration()
            {
                Hours = (frist?.Hours ?? 0),
                Seconds = (frist?.Seconds ?? 0) ,
                Minutes = (frist?.Minutes ?? 0) + 1
            };
           
        }

        public static Duration operator --(Duration frist)
        {
            return new Duration()
            {
                //null? if null hours = 0
                Hours = (frist?.Hours ?? 0) ,
                Seconds = (frist?.Seconds ?? 0),
                Minutes = (frist?.Minutes ?? 0) - 1
            };
        }
        #endregion
        #region Relational OverLoading 
        public static bool operator >(Duration frist, Duration second)
        {
            if(frist?.Hours > second?.Hours)
                return true;
            if (frist?.Hours == second?.Hours)
            {
                if(frist?.Minutes > second?.Minutes)
                {
                    return true;
                }
                else if (frist?.Minutes == second?.Minutes)
                {
                    if (frist?.Seconds > second?.Seconds)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool operator <(Duration frist, Duration second)
        {
            if (frist?.Hours < second?.Hours)
                return true;
            if (frist?.Hours == second?.Hours)
            {
                if (frist?.Minutes < second?.Minutes)
                {
                    return true;
                }
                else if (frist?.Minutes == second?.Minutes)
                {
                    if (frist?.Seconds < second?.Seconds)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool operator >=(Duration frist, Duration second)
        {
            if (frist?.Hours >= second?.Hours)
                return true;
           else
            return false;

        }
        public static bool operator <=(Duration frist, Duration second)
        {
            if (frist?.Hours <= second?.Hours)
                return true;
            else
                return false;

        }
        #endregion
        #region casting OverLoading
        public static explicit operator DateTime(Duration duration)
        {
            return DateTime.Today
         .AddHours(duration.Hours)
         .AddMinutes(duration.Minutes)
         .AddSeconds(duration.Seconds);
        }
        #endregion
        #region Boolean 
        public static bool operator true(Duration d)
        {
           return d.Hours != 0 && d.Minutes != 0 && d.Seconds != 0;
        }

        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }
        #endregion
        #endregion

        #region Normalize
        public static void normalize(Duration d)
        {
            d.Hours = d.Seconds / (60 * 60);
            d.Seconds = d.Seconds % (60 * 60);
            d.Minutes = d.Seconds / 60;
            d.Seconds = d.Seconds % 60;
        }
        #endregion
    }
}
