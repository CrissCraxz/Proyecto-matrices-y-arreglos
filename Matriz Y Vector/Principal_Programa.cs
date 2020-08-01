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
    public partial class Principal_Programa : Form
    {
        public Principal_Programa()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Opcion_Matrices ob = new Opcion_Matrices();
            ob.ShowDialog();
        }
    }
}
