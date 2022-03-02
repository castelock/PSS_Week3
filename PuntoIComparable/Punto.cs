using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoIComparable
{
    public class Punto:IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override int GetHashCode()
        {
            return X ^ Y;
        }

        public override bool Equals(Object? obj)
        {
            if (obj is not Punto p) return false; // otro tipo o null
            return (X == p.X) && (Y == p.Y);
        }

        public static bool operator ==(Punto obj1, Punto obj2)
        {
            return (obj1.X == obj2.X) && (obj1.Y == obj2.Y);
        }
        public static bool operator !=(Punto obj1, Punto obj2)
        {
            return !(obj1 == obj2);
        }

        public int CompareTo(Object? obj)
        {
            if (obj == null) return 1;
            if (obj is Punto punto2)
            {
                double dis1 = Math.Sqrt(Math.Pow(this.X, 2.0) + Math.Pow(this.Y, 2.0));
                double dis2 = Math.Sqrt(Math.Pow(punto2.X, 2.0) + Math.Pow(punto2.Y, 2.0));
                return dis1.CompareTo(dis2);  // se compara la distancia al origen
            }
            throw new ArgumentException("El objeto no es Punto");
        }

        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }

    }
}
