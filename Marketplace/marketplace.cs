﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace
{
    /// <summary>
    /// Clase del formulario principal
    /// </summary>
    public partial class marketplace : Form
    {
        /// <summary>
        /// Alto del UserControl ListaFila
        /// </summary>
        private readonly int mheight = 61;
        /// <summary>
        /// Alto del UserControl ItemBuy
        /// </summary>
        private readonly int mheightBuy = 50;
        /// <summary>
        /// ToolStripButton activo
        /// </summary>
        private ToolStripButton tsbActive;
        /// <summary>
        /// Precio total de compra
        /// </summary>
        private long priceTotal = 0;
        /// <summary>
        /// N veces que se ha borrado un item del carrito de la compra
        /// </summary>
        private int undoCount = 0;

        /// <summary>
        /// Constructor del formulario principal
        /// </summary>
        public marketplace()

        {
            InitializeComponent();

            // Menu Item por defecto
            menuItemDefective();

            // Establece los fondos, y deshabilida los botones deshacer y rehacer
            ucPrecio.setPrecio("5000000");
            tsbUndo.Enabled = false;
            tsbRedo.Enabled = false;

            // Cargar items
            loadItems();
        }

        /// <summary>
        /// Captura el evento del boton ToolStripButton del Menu, permite saber el boton pulsado
        /// </summary>
        /// <param name="toolStripButton"></param>
        /// <param name="e"></param>
        public void searchItems (object toolStripButton, EventArgs e)
        {
            ToolStripButton tsb = (ToolStripButton)toolStripButton;

            if (tsbActive.Name.CompareTo(tsb.Name) != 0)
            {
                tsbSelected(tsb, false);
                tsbSelected(tsbActive, true);
                tsbActive = tsb;
                loadItems();
            }
        }

        /// <summary>
        /// Busca que ToolStripButton que es, y cambia la imagen si esta activo o no el boton
        /// gracias a la variable menuActive
        /// </summary>
        /// <param name="tsb"></param>
        /// <param name="menuActive"></param>
        private void tsbSelected (ToolStripButton tsb, bool menuActive)
        {
            switch (tsb.Name)
            {
                case "tsbGeneral":
                    changeImage(menuActive, tsb, Marketplace.Menu._1, Marketplace.Menu._1On);
                    break;
                case "tsbOres":
                    changeImage(menuActive, tsb, Marketplace.Menu._2, Marketplace.Menu._2On);
                    break;
                case "tsbPlants":
                    changeImage(menuActive, tsb, Marketplace.Menu._3, Marketplace.Menu._3On);
                    break;
                case "tsbSeeds":
                    changeImage(menuActive, tsb, Marketplace.Menu._4, Marketplace.Menu._4On);
                    break;
                case "tsbHide":
                    changeImage(menuActive, tsb, Marketplace.Menu._5, Marketplace.Menu._5On);
                    break;
                case "tsbSea":
                    changeImage(menuActive, tsb, Marketplace.Menu._6, Marketplace.Menu._6On);
                    break;
                case "tsbWeapon":
                    changeImage(menuActive, tsb, Marketplace.Menu._7, Marketplace.Menu._7On);
                    break;
                case "tsbSecondWeapon":
                    changeImage(menuActive, tsb, Marketplace.Menu._8, Marketplace.Menu._8On);
                    break;
                case "tsbArmor":
                    changeImage(menuActive, tsb, Marketplace.Menu._9, Marketplace.Menu._9On);
                    break;
                case "tsbAccessories":
                    changeImage(menuActive, tsb, Marketplace.Menu._10, Marketplace.Menu._10On);
                    break;
                case "tsbBlackstone":
                    changeImage(menuActive, tsb, Marketplace.Menu._11, Marketplace.Menu._11On);
                    break;
                case "tsbCrystal":
                    changeImage(menuActive, tsb, Marketplace.Menu._12, Marketplace.Menu._12On);
                    break;
                case "tsbPotion":
                    changeImage(menuActive, tsb, Marketplace.Menu._13, Marketplace.Menu._13On);
                    break;
                case "tsbFood":
                    changeImage(menuActive, tsb, Marketplace.Menu._14, Marketplace.Menu._14On);
                    break;
                case "tsbMaterial":
                    changeImage(menuActive, tsb, Marketplace.Menu._15, Marketplace.Menu._15On);
                    break;
                case "tsbDye":
                    changeImage(menuActive, tsb, Marketplace.Menu._16, Marketplace.Menu._16On);
                    break;
                case "tsbHouse":
                    changeImage(menuActive, tsb, Marketplace.Menu._17, Marketplace.Menu._17On);
                    break;
                case "tsbMount":
                    changeImage(menuActive, tsb, Marketplace.Menu._18, Marketplace.Menu._18On);
                    break;
                case "tsbPets":
                    changeImage(menuActive, tsb, Marketplace.Menu._19, Marketplace.Menu._19On);
                    break;
            }
        }

        /// <summary>
        /// Permite cambiar la imagen del ToolStripButton
        /// </summary>
        /// <param name="menuActive"></param>
        /// <param name="tsb"></param>
        /// <param name="imageOF"></param>
        /// <param name="imageON"></param>
        private void changeImage (bool menuActive, ToolStripButton tsb, Image imageOF, Image imageON)
        {
            if (menuActive)
                tsb.Image = imageOF;
            else
                tsb.Image = imageON;
        }

        /// <summary>
        /// Pone el 1º ToolStripButton activo
        /// </summary>
        private void menuItemDefective ()
        {
            changeImage(false, tsbGeneral, Marketplace.Menu._1, Marketplace.Menu._1On);
            tsbActive = tsbGeneral;
        }

        /// <summary>
        /// Limpia el panel y carga los Item segun el filtro o opcion seleccionala en el menu
        /// </summary>
        private void loadItems()
        {
            pnlLista.Controls.Clear();
            Item[] items = AltasDefectivas.altasProductos();
            pnlListaBuy.AllowDrop = true;

            int n = 0;
            foreach (Item item  in items)
            {
                if (tsbActive.Name.CompareTo("tsbGeneral") == 0)
                {
                    loadItemPanel(item, n);
                    n++;
                }
                else if (tsbActive.Name.CompareTo(item.categoria) == 0)
                {
                    loadItemPanel(item, n);
                    n++;
                }
                
            }
        }

        /// <summary>
        /// Configura el UserControl y lo añade al panel
        /// </summary>
        /// <param name="item"></param>
        private void loadItemPanel (Item item, int n)
        {
            Fila.ListaFila fila = new Fila.ListaFila();
            fila.Size = new Size(pnlLista.Width, mheight);
            fila.Location = new Point(0, mheight * n);
            fila.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            fila.setImageItem(item.imagen);
            fila.setNombreItem(item.nombre);
            fila.setPrecioItem(item.precio);
            fila.setColorItem(item.grado);
            fila.setToolTip(item.nombre);
            pnlLista.Controls.Add(fila);
        }

        /// <summary>
        /// Determina que el efecto de arrastrar sea de tipo copia, es decir
        /// los datos de origen se copian al destino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlListaBuy_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; 
        }

        /// <summary>
        /// Creamos con los datos arrastrados un UserControl, y se lo añadimos al panel de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlListaBuy_DragDrop(object sender, DragEventArgs e)
        {
            int n = pnlListaBuy.Controls.Count;
            Fila.ItemBuy itemBuy= new Fila.ItemBuy();
            itemBuy.Size = new Size(pnlListaBuy.Width, mheightBuy);
            itemBuy.Location = new Point(0, mheightBuy * n);
            itemBuy.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            List<object> itemDates = (List<object>)e.Data.GetData(typeof(List<object>));
            for (int i = 0; i < itemDates.Count; i++)
            {
                switch(i)
                {
                    case 0:
                        itemBuy.setImageItem((Image)itemDates[i]);
                        break;
                    case 1:
                        itemBuy.setPrecioItem((string)itemDates[i]);
                        break;
                    case 2:
                        itemBuy.setColorItem((Color)itemDates[i]);
                        break;
                }
            }
            priceTotal += Convert.ToInt64(itemBuy.getPrecioItem());
            ucPrecioBuy.setPrecio(Convert.ToString(priceTotal));
            Persistencia.lista.Add(itemBuy);
            tsbUndo.Enabled = true;
            pnlListaBuy.Controls.Add(itemBuy);
        }

        /// <summary>
        /// Boton de compra, comprobamos que se puede realizar la compra, y en ese caso, restamos de
        /// los fondos, y eliminamos el objeto del carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            long precio = Convert.ToInt64(ucPrecio.getPrecio()) - Convert.ToInt64(ucPrecioBuy.getPrecio());
            if (precio > 0)
            {
                ucPrecio.setPrecio(Convert.ToString(precio));
                priceTotal = 0;
                ucPrecioBuy.setPrecio(Convert.ToString(priceTotal));
                Label shopList = lblShoppingList;
                pnlListaBuy.Controls.Clear();
                pnlListaBuy.Controls.Add(shopList);
            }
        }

        /// <summary>
        /// Establece el idioma al ingles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiIngles_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            catch (CultureNotFoundException ex){}
            catch (ArgumentException ex){}
            inicialize();
        }

        /// <summary>
        /// Establece el idioma al Español
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEspañol_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            }
            catch (CultureNotFoundException ex){}
            catch (ArgumentException ex){
            }
            inicialize();
        }

        /// <summary>
        /// Guarda el estado de los componentes necesarios, para al restablecer el idioma
        /// la interfaz quede como estaba
        /// </summary>
        private void inicialize ()
        {
            // persistenciaEstado
            Persistencia.tsbActive = tsbActive.Name;
            Persistencia.priceTotal = priceTotal;
            Persistencia.balance = ucPrecio.getPrecio();
            Persistencia.tsbRedo = tsbRedo.Enabled;
            Persistencia.tsbUndo = tsbUndo.Enabled;
            Persistencia.undoCount = undoCount;
            this.Controls.Clear();
            InitializeComponent();
            // Cargar items
            loadItems();
            this.WindowState = FormWindowState.Normal;
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripButton)
                {
                    if (item.Name == Persistencia.tsbActive)
                    {
                        tsbActive = (ToolStripButton)item;
                    }
                }
            }
            priceTotal = Persistencia.priceTotal;
            ucPrecio.setPrecio(Persistencia.balance);
            tsbSelected(tsbActive, false);
            tsbRedo.Enabled = Persistencia.tsbRedo;
            tsbUndo.Enabled = Persistencia.tsbUndo;
            undoCount = Persistencia.undoCount;
            for (int i = 0; i < Persistencia.lista.Count-undoCount; i++)
            {
                pnlListaBuy.Controls.Add(Persistencia.lista[i]);
            }
        }
        
        /// <summary>
        /// Deshacer - Borra del carrito de compra los items añadidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUndo_Click(object sender, EventArgs e)
        {
            pnlListaBuy.Controls.Remove(Persistencia.lista[Persistencia.lista.Count-undoCount-1]);
            ucPrecioBuy.setPrecio(Convert.ToString(Convert.ToInt64(ucPrecioBuy.getPrecio()) - Convert.ToInt64(Persistencia.lista[Persistencia.lista.Count - undoCount - 1].getPrecioItem())));
            if (pnlListaBuy.Controls.Count == 1)
            {
                tsbUndo.Enabled = false;
            }
            tsbRedo.Enabled = true;
            ++undoCount;
        }
        
        /// <summary>
        /// Rehacer - Añade al carrito de compra los items borrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRedo_Click(object sender, EventArgs e)
        {
            pnlListaBuy.Controls.Add(Persistencia.lista[Persistencia.lista.Count - undoCount]);
            ucPrecioBuy.setPrecio(Convert.ToString(Convert.ToInt64(ucPrecioBuy.getPrecio()) + Convert.ToInt64(Persistencia.lista[Persistencia.lista.Count - undoCount].getPrecioItem())));
            --undoCount;
            if (undoCount == 0)
            {
                tsbRedo.Enabled = false;
                tsbUndo.Enabled = true;
            }
        }
    }
}
