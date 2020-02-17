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
    public partial class CRUD_Cliente : Form
    {
        public CRUD_Cliente()
        {
            InitializeComponent();
        }

        private void CRUD_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Mensaje, Segurx de Cerrar?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
