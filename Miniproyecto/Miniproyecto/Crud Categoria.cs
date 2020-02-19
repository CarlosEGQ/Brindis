using Data;
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
    public partial class Crud_Categoria : Form
    {
        MiniproyectoEntities BD = new MiniproyectoEntities();
        Category category;
        public Crud_Categoria()
        {
            InitializeComponent();
        }

        private void Crud_Categoria_Load(object sender, EventArgs e)
        {
            gridLoad();
        }
        void gridLoad()
        {
            CategoryGrid.DataSource = BD.Category.ToList();
        }
        Category GetCategory(int id)
        {
            Category category = BD.Category.Find(id);
            return category;
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if(txtClave.Text.Trim() != "")
            {
                Category cat = GetCategory(Convert.ToInt32(txtClave.Text));
                if (cat == null)
                    return; 
                txtClave.Text = cat.Id.ToString();
                txtDes.Text = cat.Description;
                txtClave.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clean();
        }
        void clean()
        {
            txtClave.Text = "";
            txtDes.Text = "";
            txtClave.Enabled = true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if(txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar clave");
                txtClave.Focus();
                return;
            }
            if (txtDes.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar la descripcion");
                txtDes.Focus();
                return;
            }
            if (!int.TryParse(txtClave.Text, out temp))
            {
                MessageBox.Show("Favor de coloca numeros");
                txtClave.Focus();
                return;
            }
            try
            {
				if (!txtClave.Enabled)
				{
					category = GetCategory(Convert.ToInt32(txtClave.Text));
					if (category == null)
					{
						MessageBox.Show("Ocurrio un fallo");
						return;
					}
					category.Description = txtDes.Text;
					//BD.Category.Add(category);
					BD.SaveChanges();
					MessageBox.Show("Categoria guardado exitosamente");
					txtClave.Enabled = true;
					gridLoad();
					clean();
				}
				else
				{
					category = new Category();
					category.Id = Convert.ToInt32(txtClave.Text);
					category.Description = txtDes.Text;
					BD.Category.Add(category);
					BD.SaveChanges();
					MessageBox.Show("Categoria guardado exitosamente");
					txtClave.Enabled = true;
					gridLoad();
					clean();
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguente error"+ex.ToString());
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() == "")
                return;
            category = GetCategory(Convert.ToInt32(txtClave.Text));
            try
            {
                BD.Category.Remove(category);
                BD.SaveChanges();
                category = null;
                MessageBox.Show("Se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridLoad();
                clean();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" +ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
