using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace
{
    /// <summary>
    /// Clase donde se guarda las variables para el guardado correcto del estado 
    /// de la aplicacion al efectuar el cambio de idioma y el DragandDrop
    /// </summary>
    class Persistencia
    {
        /// <summary>
        /// Guarda el nombre del boton que esta activo
        /// </summary>
        public static string tsbActive;
        /// <summary>
        /// Guarda el precio total de la lista de la compra
        /// </summary>
        public static long priceTotal = 0;
        /// <summary>
        /// Guarda los fondos
        /// </summary>
        public static string balance = "";
        /// <summary>
        /// Guarda la lista completa de la compra
        /// </summary>
        public static List<Fila.ItemBuy> lista = new List<Fila.ItemBuy>();
        /// <summary>
        /// Guarda el estado del boton deshacer
        /// </summary>
        public static bool tsbUndo;
        /// <summary>
        /// Guarda el estado del boton rehacer
        /// </summary>
        public static bool tsbRedo;
        /// <summary>
        /// Guarda el n veces que has deshecho, es decir, que has borrado un item de la lista de la compra
        /// </summary>
        public static int undoCount = 0;
    }
}
