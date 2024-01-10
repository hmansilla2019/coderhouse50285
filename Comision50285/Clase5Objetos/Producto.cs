using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Objetos
{
    internal class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;

        public int Codigo
        {
            get // getter lectura
            {
                // Logica
                return _codigo;
            }
            set // setter escritura
            {
                // Logica
                _codigo = value;
            }
        }

        public string Descripcion
        {
            get // getter lectura
            {
                // Logica
                return _descripcion;
            }
            set // setter escritura
            {
                // Logica
                _descripcion = value;
            }
        }
        public double PrecioCompra
        {
            get // getter lectura
            {
                // Logica
                return _precioCompra;
            }
            set // setter escritura
            {
                // Logica
                _precioCompra = value;
            }
        }

        public double PrecioVenta
        {
            get // getter lectura
            {
                // Logica
                return _precioVenta;
            }
            set // setter escritura
            {
                // Logica
                _precioVenta = value;
            }
        }

        // Propiedad de solo lectura
        public string Categoria
        {
            get // getter lectura
            {
                // Logica
                if (!string.IsNullOrEmpty(this.Categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "Sin Categoria";
                }
                
            }
         
        }

        // propiedad autoimplementada
        public string Color { get; set; }

        public string Modelo { get;  }

        public Producto()
        {
            _codigo = 0;
            _descripcion = String.Empty;
            _precioCompra = 0;
            _precioVenta = 0;
            _categoria = String.Empty;
        }

        public Producto(int codigo, string descripcion, double precioCompra,double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            this._categoria = categoria;
        }

        public bool HayPreciodeVenta()
        {
            return this._precioVenta > 0;
        }



    }

}
