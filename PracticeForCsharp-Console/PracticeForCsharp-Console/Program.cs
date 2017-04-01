using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForCsharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(21,32);
            Console.WriteLine("面积为"+rectangle.CalcArea());
            Console.WriteLine("周长为"+rectangle.CalcCircumfer()); 
            
            
        }
    }

    class Rectangle
    {
        public int length;
        public int width;
        private int area;
        public Rectangle()
        {
            length = 0;
            width = 0;
        }
        public Rectangle(int length , int width)
        {
            this.length = length;
            this.width = width;
        }
        public int line = 0;
        public Rectangle(int area)
        {
            this.area = area;
            line = Convert.ToInt32(Math.Sqrt(area));
            while (1 == 1)
            {
                if (area / line * line == area)
                    break;
                --line;
            }
        }
        public bool IsSquare()
        {
            if (length == width)
                return true;
            return false;
        }
        public int CalcCircumfer()
        {
            return length * 2 + width * 2;
        }
        public int CalcArea()
        {
            return length * width;
        }
    }

}
