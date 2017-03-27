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
            Rectangle rectangle = new Rectangle(30);
            int line = rectangle.SquArea();
            Console.WriteLine("面积为30的矩形最近分解为{0}和{1}",line,30/line);
            
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
        public Rectangle(int area)
        {
            this.area = area;
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
        public int SquArea()
        {
            int line = Convert.ToInt32(Math.Sqrt(area));
            while(1==1)
            {
                if (area / line * line == area)
                    break;
                --line;
            }
            return line;
        }
    }

}
