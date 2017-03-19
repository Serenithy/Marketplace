using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace
{
    class Persistencia
    {
        public static ToolStripButton tsbActive;
        public static ulong priceTotal = 0;
        public static string balance = "";
        public static List<Fila.ItemBuy> lista = new List<Fila.ItemBuy>();
    }
}
