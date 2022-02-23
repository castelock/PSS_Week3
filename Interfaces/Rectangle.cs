using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Rectangle : IPolygon
    {
        public void calculateArea()
        {
            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
