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
    public partial class Opcion_Matrices : Form
    {
        public Opcion_Matrices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            M_Cuadratica ob = new M_Cuadratica();
            ob.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_No_Cuadratica ob = new M_No_Cuadratica();
            ob.ShowDialog();
        }
    }
}
