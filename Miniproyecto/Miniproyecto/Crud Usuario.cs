using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproyecto
{
    public partial class Crud_Usuario : Form
    {
        public Crud_Usuario()
        {
            InitializeComponent();
        }

        private void Crud_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Mensaje, Segurx de Cerrar?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
