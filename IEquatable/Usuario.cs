using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable
{
    public class Usuario : IEquatable<Usuario>
    {
        public string Nombre;
        public string PalabraDePaso;
        public Usuario(string nombre, string palabraDePaso)
        {
            this.Nombre = nombre;
            this.PalabraDePaso = palabraDePaso;
        }

        public bool Equals(Usuario? otroUsuario)
        {
            if (otroUsuario is null) return false;
            return (this.Nombre.Equals(otroUsuario.Nombre));

        }

        // Se debe reemplazar Object.Equals y Object.GetHashCode y sobrecargar == !=

    }
}
