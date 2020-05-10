using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_numero_2
{
    class Dato
    {
        string nit;
        string nombre;
        string direccion;
        string placa;
        string fechaA;
        string fechaV;
        Double total;
        Double kilometro;

        public string Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Placa { get => placa; set => placa = value; }
        public string FechaA { get => fechaA; set => fechaA = value; }
        public double Total { get => total; set => total = value; }
        public double Kilometro { get => kilometro; set => kilometro = value; }
    }
}
