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
    public partial class Ingresar_Valores : Form
    {
        public Ingresar_Valores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Ingresar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
         
       
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
