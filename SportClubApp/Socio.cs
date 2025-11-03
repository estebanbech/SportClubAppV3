using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubApp
{
    internal class Socio : Persona
    {
        private int nroSocio;
        private DateTime fechaAlta;
        private bool habilitado;
        private bool aptoFisico;
        public Socio(string nombre, string apellido, string dni, string telefono, string email,
                     int nroSocio, DateTime fechaAlta, bool habilitado, bool aptoFisico)
            : base(nombre, apellido, dni, telefono, email)
        {
            this.nroSocio = nroSocio;
            this.fechaAlta = fechaAlta;
            this.habilitado = habilitado;
            this.aptoFisico = aptoFisico;
        }
        public int GetNumeroSocio()
        {
            return nroSocio;
        }
        public DateTime GetFechaAlta()
        {
            return fechaAlta;
        }
        public bool IsHabilitado()
        {
            return habilitado;
        }
        public bool IsAptoFisico()
        {
            return aptoFisico;
        }
        public void SetNumeroSocio(int nroSocio)
        {
            this.nroSocio = nroSocio;
        }
        public void SetFechaAlta(DateTime fechaAlta)
        {
            this.fechaAlta = fechaAlta;
        }
        public void SetHabilitado(bool habilitado)
        {
            this.habilitado = habilitado;
        }
        public void SetAptoFisico(bool aptoFisico)
        {
            this.aptoFisico = aptoFisico;
        }
    }
}
