using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observadorUsuario
{
    class Cliente : Usuario
    {
        public Cliente(string nombre, string apellido, int edad)
          : base(nombre, apellido, edad)
        {

        }
    }
}
