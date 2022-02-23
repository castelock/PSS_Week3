using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Square : IPolygon
    {
        public void calculateArea()
        {
            int l = 30;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }
}
