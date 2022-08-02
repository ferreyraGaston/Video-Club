using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Producto
    {

        /***************DEFINO LOS ATRIBUTOS*******************/

        //agrego el modificador de acceso private para resetar el 
        //encapsulamiento de los objetos
        private int codigo;
        private string descripcion;
        private int stock;
        private double precio;

        /**********DEFINO EL CONSTRUCTOR POR DEFECTO**********/
        // por lo general son publicos y llevan el nombre de la clase

        public Producto()
        {
        }

        /**********DEFINO EL CONSTRUCTOR**********/
        // los contructor sirve para inicializar los objetos

        public Producto(int codigo, string descripcion, int precio)
        {
            this.codigo = codigo;          
            this.descripcion = descripcion;
            this.precio = precio;   

        }

    }
}
