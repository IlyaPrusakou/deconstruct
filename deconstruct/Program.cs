using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deconstruct
{
    public static class DateTimeExtension //L9-P-EX-2/2. DateTime
    {
        public static void Deconstruct(this DateTime dt, out int year, out int month, out int day, out int hour, out int min, out int sec, out DateTime now) //L9-P-EX-2/2. DateTime
        {
            year = dt.Year; //L9-P-EX-2/2. DateTime
            month = dt.Month; //L9-P-EX-2/2. DateTime
            day = dt.Day; //L9-P-EX-2/2. DateTime
            hour = dt.Hour; //L9-P-EX-2/2. DateTime
            min = dt.Minute; //L9-P-EX-2/2. DateTime
            sec = dt.Second; //L9-P-EX-2/2. DateTime
            now = DateTime.Now; //L9-P-EX-2/2. DateTime
        }
    }
    public struct Coordinates //L9-P-EX-1/2.
    {
        public int CoordX { get; set; }  //L9-P-EX-1/2.
        public int CoordY { get; set; }  //L9-P-EX-1/2.
        public int CoordZ { get; set; }  //L9-P-EX-1/2.
        public double Length { get; set; }  //L9-P-EX-1/2. 
        public void Deconstruct(out int x, out int y, out int z, out double len)  //L9-P-EX-1/2.
        {
            x = CoordX; //L9-P-EX-1/2.
            y = CoordY; //L9-P-EX-1/2.
            z = CoordZ; //L9-P-EX-1/2.
            len = Length; //L9-P-EX-1/2.
        }
        public  Coordinates(int x, int y, int z, double lenght) //L9-P-EX-1/2.
        {
            CoordX = x; //L9-P-EX-1/2.
            CoordY = y; //L9-P-EX-1/2.
            CoordZ = z; //L9-P-EX-1/2.
            Length = lenght; //L9-P-EX-1/2.
        }
    }
    class Program
    {
        
        public static double Calc(Coordinates vec) //L9-P-EX-1/2.
        {
            var (x, y, z, len) = vec; //L9-P-EX-1/2.
            len = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0) + Math.Pow(z, 2.0)); //L9-P-EX-1/2.
            return len; //L9-P-EX-1/2.
        }

        static void Main(string[] args)
        {
            DateTime fff = new DateTime(1999, 3, 13, 3, 57, 32); //L9-P-EX-2/2. DateTime

            var (year, month, day, hour, min, sec, now) = fff; //L9-P-EX-2/2. DateTime
            Console.WriteLine(year); //L9-P-EX-2/2. DateTime
            Console.WriteLine(month); //L9-P-EX-2/2. DateTime
            Console.WriteLine(DateTime.Now); //L9-P-EX-2/2. DateTime
            Console.WriteLine(now); //L9-P-EX-2/2. DateTime

            Coordinates crd = new Coordinates(2, 4, 6, 999); //L9-P-EX-1/2.
            double ff = Calc(crd); //L9-P-EX-1/2.
            Console.WriteLine("Test  " + ff); //L9-P-EX-1/2.
            Console.WriteLine(crd.Length); //L9-P-EX-1/2.


            Console.ReadLine();
        }
    }
}
