using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observadorUsuario
{
    abstract class Usuario

    {
        private string nombre;
        private string apellido;
        private int edad;
        private List<ICuenta> iCuentas = new List<ICuenta>();

        // Constructor

        public Usuario(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public void Attach(ICuenta cliente)
        {
            iCuentas.Add(cliente);
        }

        public void Detach(ICuenta cliente)
        {
            iCuentas.Remove(cliente);
        }

        public void Notify()
        {
            foreach (ICuenta cliente in iCuentas)
            {
                cliente.Update(this);
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set

            {
                if (this.nombre != value)
                {
                    this.nombre = value;
                    Notify();
                }
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set

            {
                if (this.apellido != value)
                {
                    this.apellido = value;
                    Notify();
                }
            }
        }

        public int Edad
        {
            get { return this.edad; }
            set

            {
                if (this.edad != value)
                {
                    this.edad = value;
                    Notify();
                }
            }
        }
    }
}
