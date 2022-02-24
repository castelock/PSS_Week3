namespace Equals
{
    public class Program
    {
        struct Valor
        {
            public int A { set; get; }
        }
        class Referencia
        {
            public int A { get; set; }
        }


        public static void Main(string[] args)
        {

            Valor valor1 = new() { A = 2 + 3 };
            Valor valor2 = new() { A = 5 };
            Console.WriteLine("Tipo de valor - valor1.Equals(valor2) " + valor1.Equals(valor2));
            Console.WriteLine("Tipo de valor - Valor.Equals(valor1, valor2) " + Valor.Equals(valor1, valor2));
            Console.WriteLine("Tipo de valor - Valor.ReferenceEquals(valor1, valor2)) " + Valor.ReferenceEquals(valor1, valor2));           
            Console.WriteLine("Tipo de valor - (object)valor1 == (object)valor2 " + ((object)valor1 == (object)valor2));
            Console.WriteLine("Tipo de valor - valor1 is { A: 5 } " + (valor1 is { A: 5 }));

            Referencia referencia1 = new() { A = 2 + 3 };
            Referencia referencia2 = new() { A = 5 };
            Console.WriteLine("Tipo de referencia: referencia1.Equals(referencia2) " + referencia1.Equals(referencia2));
            Console.WriteLine("Tipo de referencia: Referencia.Equals(referencia1, referencia2) " + Referencia.Equals(referencia1, referencia2));
            Console.WriteLine("Tipo de referencia: Referencia.ReferenceEquals(referencia1, referencia2) " + Referencia.ReferenceEquals(referencia1, referencia2));
            Console.WriteLine("Tipo de referencia: referencia1 == referencia2 " + (referencia1 == referencia2));
            Console.WriteLine("Tipo de referencia: referencia1 is { A: 5 } " + (referencia1 is { A: 5 }));



        }

    }
}