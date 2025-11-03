using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubApp
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;
        private string email;

        public Persona(string nombre, string apellido, string dni, string telefono, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public string GetDni()
        {
            return dni;
        }
        public string GetTelefono()
        {
            return telefono;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }


    }
}
