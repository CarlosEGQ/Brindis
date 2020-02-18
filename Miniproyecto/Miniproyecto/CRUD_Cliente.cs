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
            dtFecha.Text = "";
            txtRFC.Text = "";
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
            try
            {
                if (!txtID.Enabled)
                {
                    client.Name = txtNombre.Text;
                    client.Address = txtDireccion.Text;
                    client.BirthDate = dtFecha.Value.Date;
                    client.RFC = txtRFC.Text;
                    client.CategoryId = Convert.ToInt32(this.cbCategoria.GetItemText(this.cbCategoria.SelectedValue));
                    BD.SaveChanges();
                    MessageBox.Show("Cliente guardado exitosamente");
                    txtID.Enabled = true;
                    //GridLoad();
                    Clean();
                }
                else
                {
                    client = new Clients();
                    client.Name = txtNombre.Text;
                    client.Address = txtDireccion.Text;
                    client.BirthDate = dtFecha.Value.Date;
                    client.RFC = txtRFC.Text;
                    client.CategoryId = Convert.ToInt32(this.cbCategoria.GetItemText(this.cbCategoria.SelectedValue));
                    BD.Clients.Add(client);
                    BD.SaveChanges();
                    MessageBox.Show("Cliente guardado exitosamente");
                    txtID.Enabled = true;
                    //GridLoad();
                    Clean();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguente error" + ex.ToString());
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = BD.Category.ToList();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Description";
            GridLoad();
        }
        void GridLoad()
        {
            Grid.DataSource = BD.Clients.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
                return;
            client = GetClient(Convert.ToInt32(txtID.Text));
            try
            {
                BD.Clients.Remove(client);
                BD.SaveChanges();
                client = null;
                MessageBox.Show("Se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridLoad();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            txtID.Enabled = true;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text.Trim() != "")
            {
                Clients clients = GetClient(Convert.ToInt32(txtID.Text));
                if (clients == null)
                    return;
                txtID.Text = clients.Id.ToString();
                txtNombre.Text = clients.Name;
                txtDireccion.Text = clients.Address;
                txtRFC.Text = clients.RFC;
                cbCategoria.SelectedItem = clients.CategoryId;
                txtID.Enabled = false;
            }
        }
    }
}
