using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{
    /// <summary>
    /// Clase Item, molde del objeto Item, del cual se crearan multiples instancias
    /// </summary>
    class Item
    {
        // Grados de los Items -> color que luego se establecera al nombre o precio del item
        /// <summary>
        /// Color blanco, grado de item mas pequeño
        /// </summary>
        public static readonly Color GWHITE = Color.FromArgb(255, 255, 255, 255);
        /// <summary>
        /// Color verde, siguiente grado despues del blanco
        /// </summary>
        public static readonly Color GGREEN = Color.FromArgb(255, 59, 132, 67);
        /// <summary>
        /// Color azul, siguiente grado despues del verde
        /// </summary>
        public static readonly Color GBLUE = Color.FromArgb(255, 3, 145, 196);
        /// <summary>
        /// Color amarillo, siguiente grado despues del azul
        /// </summary>
        public static readonly Color GGOLD = Color.FromArgb(255, 246, 194, 50);
        /// <summary>
        /// Color naranja, siguiente grado despues del amarillo, y mas alto grado
        /// </summary>
        public static readonly Color GORANGE = Color.FromArgb(255, 211, 99, 18);

        // Categorias de los Items - Servira para la clasificacion de los Items
        /// <summary>
        /// Categoria general, a esta categoria pertenecen todos los items, 
        /// aunque no se determine en el objeto, ya que pertenece a ella por defecto
        /// </summary>
        public static readonly string GENERAL = "tsbGeneral";
        /// <summary>
        /// Categoria ores, a ella pertenecen todos los items que sean minerales
        /// </summary>
        public static readonly string ORES = "tsbOres";
        /// <summary>
        /// Categoria plantas, a ella pertenecen todos los items que sean plantas
        /// </summary>
        public static readonly string PLANTS = "tsbPlants";
        /// <summary>
        /// Categoria semillas, a ella pertenecen todos los items que sean semillas
        /// </summary>
        public static readonly string SEEDS = "tsbSeeds";
        /// <summary>
        /// Categoria pieles, a ella pertenecen todos los itens que sean pieles
        /// </summary>
        public static readonly string HIDE = "tsbHide";
        /// <summary>
        /// Categoria mar, en esta se incluye todo lo relacionado con la pesca, 
        /// menos los barcos, que estan en la categoria de montura
        /// </summary>
        public static readonly string SEA = "tsbSea";
        /// <summary>
        /// Categoria armas, estan todos los tiems que sean armas
        /// </summary>
        public static readonly string WEAPON = "tsbWeapon";
        /// <summary>
        /// Categoria armas secundarias, estan todos los items en la mano secundaria, 
        /// desde escudos, hasta dagas
        /// </summary>
        public static readonly string SWEAPON = "tsbSecondWeapon";
        /// <summary>
        /// Categoria armaduras, incluye todo tipo de armaduras, desde placas, cuero y tela
        /// </summary>
        public static readonly string ARMOR = "tsbArmor";
        /// <summary>
        /// Categoria accesorios, incluye los anillos, pendientes, collares y cinturones
        /// </summary>
        public static readonly string ACCESSORIES = "tsbAccessories";
        /// <summary>
        /// Categoria piedras negras, en esta clase incluyen las piedras especiales para 
        /// mejorar las armas, armaduras, accesorios...
        /// </summary>
        public static readonly string BLACKSTONE = "tsbBlackstone";
        /// <summary>
        /// Categoria cristales, incluye todo tipo de cristales que se le pueden añadir
        /// a la armadura, armas, accesorios...
        /// </summary>
        public static readonly string CRYSTAL = "tsbCrystal";
        /// <summary>
        /// Categoria pociones, incluye tanto desde elixires para el aumento de la pesca
        /// como la recuperacion de vida o mana
        /// </summary>
        public static readonly string POTION = "tsbPotion";
        /// <summary>
        /// Categoria comida, incluye todo tipo de items fabricados con la profesion de
        /// cocina
        /// </summary>
        public static readonly string FOOD = "tsbFood";
        /// <summary>
        /// Categoria material, incluye todos los items que son utilizados para la 
        /// fabricacion de otros items
        /// </summary>
        public static readonly string MATERIAL = "tsbMaterial";
        /// <summary>
        /// Categoria tintes, incluye todo tipo de tintes distintos, para las armaduras
        /// </summary>
        public static readonly string DYE = "tsbDye";
        /// <summary>
        /// Categoria casas, incluye todas las casas que estan disponibles
        /// </summary>
        public static readonly string HOUSE = "tsbHouse";
        /// <summary>
        /// Categoria montura, incluye toda clase de montiras, desde caballos
        /// hasta barcos
        /// </summary>
        public static readonly string MOUNT = "tsbMount";
        /// <summary>
        /// Categoria mascotas, incluye todas las mascotas disponibles
        /// </summary>
        public static readonly string PETS = "tsbPets";

        // Atributos
        /// <summary>
        /// Variable miembro que guarda la imagen
        /// </summary>
        private Image mImagen;
        /// <summary>
        /// Variable miembro que guarda el nombre del item
        /// </summary>
        private string mNombre;
        /// <summary>
        /// Variable miembro que guarda las unidades disponibles del item
        /// </summary>
        private int mUnidades;
        /// <summary>
        /// Variable miembro que guarda el precio del item
        /// </summary>
        private string mPrecio;
        /// <summary>
        /// Variable miembro que guarda el grado, es decir, en este caso, el color que se 
        /// establecera al nombre o precio
        /// </summary>
        private Color mGrado;
        /// <summary>
        /// Variable miembro que guarda la categoria, es decir, el nombre del 
        /// ToolStripMenu al que pertenece, para establecer los filtros
        /// </summary>
        private string mCategoria;

        /// <summary>
        /// Constructor donde de establecen todas las variables miembro
        /// </summary>
        /// <param name="imagen"></param>
        /// <param name="nombre"></param>
        /// <param name="unidades"></param>
        /// <param name="precio"></param>
        /// <param name="grado"></param>
        /// <param name="categoria"></param>
        public Item(Image imagen, string nombre, int unidades, string precio, Color grado, string categoria)
        {
            this.mImagen = imagen;
            this.mNombre = nombre;
            this.mUnidades = unidades;
            this.mPrecio = precio;
            this.mGrado = grado;
            this.mCategoria = categoria;
        }

        /// <summary>
        /// Property - devuelve o establece la imagen del objeto Item
        /// </summary>
        public Image imagen
        {
            get { return mImagen; }
            set { this.mImagen = value; }
        }

        /// <summary>
        /// Property - devuelve o establece el nombre del objeto Item
        /// </summary>
        public string nombre
        {
            get { return mNombre; }
            set { this.mNombre = value; }
        }

        /// <summary>
        /// Property - devuelve o establece las unidades del objeto Item
        /// </summary>
        public int unidades
        {
            get { return mUnidades; }
            set { this.mUnidades = value; }
        }

        /// <summary>
        /// Property - devuelve o establece el precio del objeto Item
        /// </summary>
        public string precio
        {
            get { return mPrecio; }
            set { this.mPrecio = value; }
        }

        /// <summary>
        /// Property - devuelve o establece el grado del objeto Item
        /// </summary>
        public Color grado
        {
            get { return mGrado; }
            set { this.mGrado = value; }
        }

        /// <summary>
        /// Property - devuelve o establece la categoria del objeto Item
        /// </summary>
        public string categoria
        {
            get { return mCategoria; }
            set { this.mCategoria = value; }
        }
    }
}
