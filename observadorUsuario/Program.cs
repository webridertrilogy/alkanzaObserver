using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observadorUsuario
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create Cliente
            Cliente cliente = new Cliente("Pepito", "Perez", 20);
            cliente.Attach(new Cuenta("login1"));
            cliente.Attach(new Cuenta("login2"));

            cliente.Nombre = "Pepita";
            cliente.Apellido = "Pepota";
            cliente.Edad = 25;

            Console.ReadKey();            

        }


    }
}
