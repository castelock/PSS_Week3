using IEquatable;
using System.Collections;

namespace Equals
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Usuario usuario1 = new("pedro", "miclave");
            Usuario usuario2 = new("pedro", "otraclave");

            // ESCENARIO 1: True (correcto)
            Console.WriteLine("usuario1.Equals(usuario2): {0}", usuario1.Equals(usuario2));

            // ESCENARIO 2: False (posible error)
            Object obj = usuario2;
            Console.WriteLine("usuario1.Equals(obj): {0}", usuario1.Equals(obj));            
            
            // ESCENARIO 3: False (posible error)          
            ArrayList listaA = new();
            listaA.Add(usuario1);
            Console.WriteLine("lista.Contains(usuario2): {0}", listaA.Contains(usuario2));

            // ESCENARIO 4: True (correcto)
            List<Usuario> listaB = new List<Usuario>();
            listaB.Add(usuario1);
            Console.WriteLine("listaB<Usuario>.Contains(usuario2): {0}", listaB.Contains(usuario2));




        }

    }
}