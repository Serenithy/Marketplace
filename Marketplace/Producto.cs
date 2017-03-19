using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{
    class Producto
    {
        private Image mImagen;
        private string mNombre;
        private string mDescripcion;
        private string mPrecio;
        private string mGrado;
        private string mCategoria;

        public Producto(Image imagen, string nombre, string descripcion, 
            string precio, string grado, string categoria)
        {
            this.mImagen = imagen;
            this.mNombre = nombre;
            this.mDescripcion = descripcion;
            this.mPrecio = precio;
            this.mGrado = grado;
            this.mCategoria = categoria;
        }

        public Image imagen 
        {
            get { return mImagen; }
            set { this.mImagen = value; }
        }

        public string nombre
        {
            get { return mNombre; }
            set { this.mNombre = value; }
        }

        public string descripcion
        {
            get { return mDescripcion; }
            set { this.mDescripcion = value; }
        }

        public string precio
        {
            get { return mPrecio; }
            set { this.mPrecio = value; }
        }

        public string grado
        {
            get { return mGrado; }
            set { this.mGrado = value; }
        }

        public string categoria
        {
            get { return mCategoria; }
            set { this.mCategoria = value; }
        }
    }
}
