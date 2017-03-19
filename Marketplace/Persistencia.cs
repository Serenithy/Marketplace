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
        public ToolStripButton tsbActive;
        public ulong priceTotal = 0;
        public List<Fila.ItemBuy> lista = new List<Fila.ItemBuy>();
    }
}
