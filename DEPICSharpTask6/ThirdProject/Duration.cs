using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask6.ThirdProject
{
    public class Duration
    {
        // 1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        //3. Define All Required Constructors to Produce this output
        //  Constructor: Hours, Minutes, Seconds given directly
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        //  Constructor: total seconds only, converted into Hours/Minutes/Seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        // Default constructor, chains to the (hours, minutes, seconds) constructor
        public Duration() : this(0, 0, 0)
        {
        }

        // Helper used internally for comparisons (Equals, GetHashCode)
        private int TotalSeconds => Hours * 3600 + Minutes * 60 + Seconds;

        // 2. Override All System.Object Members
        //ToString()
        public override string ToString()
        {
            if (Hours > 0)
                return "Hours: " + Hours + ", Minutes :" + Minutes + ", Seconds :" + Seconds;
            else
                return "Minutes :" + Minutes + ", Seconds :" + Seconds;
        }

        // Equals() 
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
                return this.TotalSeconds == other.TotalSeconds;

            return false;
        }

        //  GetHashCode() 
        public override int GetHashCode()
        {
            return TotalSeconds.GetHashCode();
        }
    }
}
