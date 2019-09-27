using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observadorUsuario
{
    class Cuenta : ICuenta
    {
        private string descripcion;
        private Usuario usuario;

        // Constructor

        public Cuenta(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void Update(Usuario usuario)
        {
            Console.WriteLine("Push Notification {0} " +
               "change to nombre: {1} - apellido: {2} - edad: {3} ", this.descripcion, usuario.Nombre, usuario.Apellido, usuario.Edad);
        }

        // Gets or sets the stock

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
