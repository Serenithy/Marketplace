using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{
    class Item
    {
        // Grados de los Items
        public static readonly Color GWHITE = Color.FromArgb(255, 255, 255, 255);
        public static readonly Color GGREEN = Color.FromArgb(255, 59, 132, 67);
        public static readonly Color GBLUE = Color.FromArgb(255, 3, 145, 196);
        public static readonly Color GGOLD = Color.FromArgb(255, 246, 194, 50);
        public static readonly Color GORANGE = Color.FromArgb(255, 211, 99, 18);
        // Categorias de los Items
        public static readonly string GENERAL = "tsbGeneral";
        public static readonly string ORES = "tsbOres";
        public static readonly string PLANTS = "tsbPlants";
        public static readonly string SEEDS = "tsbSeeds";
        public static readonly string HIDE = "tsbHide";
        public static readonly string SEA = "tsbSea";
        public static readonly string WEAPON = "tsbWeapon";
        public static readonly string SWEAPON = "tsbSecondWeapon";
        public static readonly string ARMOR = "tsbArmor";
        public static readonly string ACCESSORIES = "tsbAccessories";
        public static readonly string BLACKSTONE = "tsbBlackstone";
        public static readonly string CRYSTAL = "tsbCrystal";
        public static readonly string POTION = "tsbPotion";
        public static readonly string FOOD = "tsbFood";
        public static readonly string MATERIAL = "tsbMaterial";
        public static readonly string DYE = "tsbDye";
        public static readonly string HOUSE = "tsbHouse";
        public static readonly string MOUNT = "tsbMount";
        public static readonly string PETS = "tsbPets";
        // Atributos
        private Image mImagen;
        private string mNombre;
        private int mUnidades;
        private string mPrecio;
        private Color mGrado;
        private string mCategoria;

        public Item(Image imagen, string nombre, int unidades, string precio, Color grado, string categoria)
        {
            this.mImagen = imagen;
            this.mNombre = nombre;
            this.mUnidades = unidades;
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

        public int unidades
        {
            get { return mUnidades; }
            set { this.mUnidades = value; }
        }

        public string precio
        {
            get { return mPrecio; }
            set { this.mPrecio = value; }
        }

        public Color grado
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
