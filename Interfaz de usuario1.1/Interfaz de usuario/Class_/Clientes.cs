using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_de_usuario.Class_
{
    public class Clientes
    {
        int idcliente;
        string Nombre;
        string Apellidos;
        string Direccion;
        DateTime FechaNac;
        string e_mail;
        string Tel;
        string RFC;
        string DomFiscal;
        string RazonSocial;
        string CP;
        string Pais;
        string Estado;
        string Municipio;
        float Saldo;

        public Clientes(int idcliente, string Nombre, string Apellidos, DateTime FechaNac, float Saldo)
        {
            this.idcliente = idcliente;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.FechaNac = FechaNac;
            this.Saldo = Saldo;
        }

        public int cidcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public string cNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string cApellido
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }

        public string cDireccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public DateTime cFechaNac
        {
            get { return FechaNac; }
            set { FechaNac = value; }
        }

        public string cE_mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }

        public string cTel
        {
            get { return Tel; }
            set { Tel = value; }
        }

        public string cRFC
        {
            get { return RFC; }
            set { RFC = value; }
        }

        public string cDomFiscal
        {
            get { return DomFiscal; }
            set { DomFiscal = value; }
        }

        public string cRazonSocial
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }

        public string cCP
        {
            get { return CP; }
            set { CP = value; }
        }

        public string cPais
        {
            get { return Pais; }
            set { Pais = value; }
        }

        public string cEstado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public string cMunicipio
        {
            get { return Municipio; }
            set { Municipio = value; }
        }

        public float cSaldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
    }
}
