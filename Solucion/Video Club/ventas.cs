using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Video_Club
{
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

    

        private void agregar_Click(object sender, EventArgs e)
        {
            /**********DECLARO LA CLASE**********/
     
            Producto NuevoProd;

            /**********DEFINO EL CONSTRUCTOR**********/
            // el contructor espera un entero pero el textbox
            // devuelve un String hay que convertirlo a numero con int.Parse(textbox.text)

            NuevoProd = new Producto(int.Parse(textCodigo.Text), textDescripcion.Text, int.Parse(textPrecio.Text));

            MessageBox.Show("Producto instanciado");

            lbl_codigo.Text = "Código: " + NuevoProd.p_codigo.ToString();
            lbl_descripcion.Text = "Descripción: " + NuevoProd.p_descripcion;
            lbl_sotck.Text="Stock: " + NuevoProd.p_precio.ToString();


        }

  
    }
}
