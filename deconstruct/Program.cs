using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deconstruct
{
    public static class DateTimeExtension
    {
        public static void Deconstruct(this DateTime dt, out int year, out int month, out int day, out int hour, out int min, out int sec, out DateTime now)
        {
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
            hour = dt.Hour;
            min = dt.Minute;
            sec = dt.Second;
            now = DateTime.Now;
        }
    }
    public struct Coordinates
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public int CoordZ { get; set; }
        public double Length;
        public void Deconstruct(out int x, out int y, out int z, out double len)
        {
            x = CoordX;
            y = CoordY;
            z = CoordZ;
            len = Length;
        }
        public  Coordinates(int x, int y, int z, double lenght)
        {
            CoordX = x;
            CoordY = y;
            CoordZ = z;
            Length = lenght;
        }
    }
    class Program
    {
        
        public static double Calc(Coordinates vec)
        {
            var (x, y, z, len) = vec;
            len = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0) + Math.Pow(z, 2.0));
            return len;
        }

        static void Main(string[] args)
        {
            DateTime fff = new DateTime(1999, 3, 13, 3, 57, 32);
            
            var (year, month, day, hour, min, sec, now) = fff;
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(now);

            Coordinates crd = new Coordinates(2, 4, 6, 999);
            double ff = Calc(crd);
            Console.WriteLine("Test  " + ff);
            Console.WriteLine(crd.Length);


            Console.ReadLine();
        }
    }
}
