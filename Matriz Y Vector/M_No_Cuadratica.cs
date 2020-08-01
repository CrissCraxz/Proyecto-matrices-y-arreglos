using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Y_Vector
{
    public partial class M_No_Cuadratica : Form
    {
        Clase_Matrices ob = new Clase_Matrices();
        Ingresar_Valores ob1 = new Ingresar_Valores();
        public M_No_Cuadratica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //boton ramdon
            ob.matriz_normal_no_cuadratica(pantalla1_,pantalla2_);
            ob.mostrar_matriz_no_cuadratica(Tabla1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.ImprimirMayor_No_Cuadratico();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ob1.ShowDialog();
        }

        private void Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Ingresar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
