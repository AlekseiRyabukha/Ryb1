using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryb1
{
    public class Rectangle
    {
        double s1;
        double s2;
        public Rectangle(double s1, double s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }
        public double Area(double s1,double s2)
        {,
            return s1 * s2;
        }
        public double Perimetr(double s1, double s2)
        {
            return 2*(s1 + s2);
        }
        public double AreaCalc
        {
            get { return Area(s1, s2); }
        }

        public double PerimetrCalc
        {
            get { return Perimetr(s1, s2); }
        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            double s1;
            double s2;
            Console.WriteLine("Ведите длину: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину: ");
            s2 = Convert.ToDouble(Console.ReadLine());
            var Rec = new Rectangle(s1, s2);
            Console.WriteLine("Площадь равна: " + Rec.AreaCalc);
            Console.WriteLine("Периметр равен: " + Rec.PerimetrCalc);

            Console.ReadKey();

        }
    }
}
