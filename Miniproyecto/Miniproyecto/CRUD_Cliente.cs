using System;
using Data;
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
        MiniproyectoEntities BD = new MiniproyectoEntities();
        Clients client;
        public CRUD_Cliente()
        {
            InitializeComponent();
        }
        Clients GetClient(int id)
        {
            Clients client = BD.Clients.Find(id);
            return client;
        }

        private void CRUD_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Mensaje, Segurx de Cerrar?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        void Clean()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            dateTimePicker1.Text = "";
            txtRFC.Text = "";
            txtIdCategoria.Text = "";
            cbCategoria.Text = "";
          
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar ID");
                txtID.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar el nombre");
                txtNombre.Focus();
                return;
            }
            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar la Direccion");
                txtDireccion.Focus();
                return;
            }
            if (txtRFC.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar el RFC");
                txtRFC.Focus();
                return;
            }
            if (txtIdCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar el ID de categoria");
                txtIdCategoria.Focus();
                return;
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
