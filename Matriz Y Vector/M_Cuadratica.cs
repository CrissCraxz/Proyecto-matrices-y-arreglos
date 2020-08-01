using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Y_Vector
{
    public partial class M_Cuadratica : Form
    {
        public M_Cuadratica()
        {
            InitializeComponent();
        }
        Clase_Matrices ob = new Clase_Matrices();
        private void button11_Click(object sender, EventArgs e)
        {
            //patalla1 es la fila , pantalla2 es columna 
            ob.matriz_normal(pantalla1);
            ob.mostrar_matriz(Tabla);

          
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            ob.diagonal_principal_mayor(Tabla);


        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            ob.ImprimirMayor();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ob.matriz_nula(Tabla);
            ob.mostrar_matriz(Tabla);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ob.matriz_opuesta(Tabla);
          //  ob.mostrar_matriz(Tabla);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ob.Triangulo_superior_mayor(Tabla);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ob.Triangulo_inferior_mayor(Tabla);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }



        public void color_Tabala(DataGridView Tb)
        {
            Tb.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            Tb.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void M_Cuadratica_Load(object sender, EventArgs e)
        {
            color_Tabala(Tabla);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ob.Eliminar_Fila_Matriz(Tabla);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            ob.Ascendente_Diagonal(Tabla);
        }
    }
}
