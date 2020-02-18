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
    public partial class Crud_Usuario : Form
    {
        MiniproyectoEntities BD = new MiniproyectoEntities();
        Users user;
        public Crud_Usuario()
        {
            InitializeComponent();
        }
        Users GetUser(int id)
        {
            Users user = BD.Users.Find(id);
            return user;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

			user = GetUser(Convert.ToInt32(txtClave.Text));

			if (user != null)
			{
				if (user.Id == Program.GlobalUser.Id && opNormal.Checked == true)
				{
					MessageBox.Show("No te puedes dejar de ser administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar clave");
                txtClave.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar el nombre");
                txtNombre.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar la contraseña");
                txtPassword.Focus();
                return;
            }
            if (txtPassword2.Text.Trim() == "")
            {
                MessageBox.Show("Favor de especificar la contraseña");
                txtPassword2.Focus();
                return;
            }
            if(opAdmin.Checked == false && opNormal.Checked == false)
            {
                MessageBox.Show("Favor de elegir un rol");
                return;
            }
            if (txtPassword2.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
			try
            {
				if (!txtClave.Enabled)
				{
					user.Nickname = txtNombre.Text;
					user.Password = txtPassword.Text;
					BD.Users.Add(user);
					BD.SaveChanges();
					MessageBox.Show("Usuario guardado exitosamente");
					txtClave.Enabled = true;
					GridLoad();
					Clean();
				}
				else
				{
					user = new Users();
					user.Id = Convert.ToInt32(txtClave.Text);
					user.Nickname = txtNombre.Text;
					user.Password = txtPassword.Text;
					if (opAdmin.Checked == true)
						user.Rol = 1;
					else
						user.Rol = 2;
					BD.Users.Add(user);
					BD.SaveChanges();
					MessageBox.Show("Usuario guardado exitosamente");
					txtClave.Enabled = true;
					GridLoad();
					Clean();
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguente error" + ex.ToString());
            }
			txtClave.Enabled = true;
        }

        private void Crud_Usuario_Load(object sender, EventArgs e)
        {
            this.GridLoad();
        }
        void GridLoad()
        {
            Grid.DataSource = BD.Users.ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clean();
            txtClave.Enabled = true;
        }
        void Clean()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            opAdmin.Checked = false;
            opNormal.Checked = false;     
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (txtClave.Text.Trim() == "")
                return;
            user = GetUser(Convert.ToInt32(txtClave.Text));
            if(user.Id == Program.GlobalUser.Id)
            {

                MessageBox.Show("No te puedes elminiar a ti mismo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                BD.Users.Remove(user);
                BD.SaveChanges();
                user = null;
                MessageBox.Show("Se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridLoad();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
			txtClave.Enabled = true;
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if(txtClave.Text.Trim() != "")
            {
                Users user = GetUser(Convert.ToInt32(txtClave.Text));
                if (user == null)
                    return;
                txtClave.Text = user.Id.ToString();
                txtNombre.Text = user.Nickname;
                txtPassword.Text = user.Password;
                if (user.Rol == 1)
                    opAdmin.Checked = true;
                else
                    opNormal.Checked = true;
				txtClave.Enabled = false;
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
    }
}
