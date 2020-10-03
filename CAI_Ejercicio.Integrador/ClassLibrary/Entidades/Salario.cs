using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public sealed class Salario:Empleado
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double Bruto
        {
            get { return this._bruto; }
            set { this._bruto = value; }
        }

        public string CodigoTransaferencia
        {
            get { return this._codigoTransferencia; }
            set { this._codigoTransferencia = value; }
        }

        public double Descuentos
        {
            get { return this._descuentos; }
            set { this._descuentos = value; }
        }

        public DateTime Fecha
        {
            get { return this._fecha; }
            set { this._fecha = value; }
        }

        public Salario(double bruto)
        {
            this._bruto = bruto;
            this._descuentos = bruto * 0.17;
            this._fecha = DateTime.Now;
            this._codigoTransferencia = _fecha.Ticks.ToString();
        }

        public double GetSalarioNeto()
        {
            return this._bruto - this._descuentos;
        }
    }
}
