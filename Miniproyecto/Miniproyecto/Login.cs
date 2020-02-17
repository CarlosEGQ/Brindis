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
    public partial class Login : Form
    {
        MiniproyectoEntities BD = new MiniproyectoEntities();
        Users user;

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Users GetUser(string nickname,string password)
        {
            Users user = BD.Users.FirstOrDefault(x => x.Nickname == nickname && x.Password == password);
            return user;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Favor de espeficiar la contraseña"); 
                txtPassword.Focus(); 
                return;
            }
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Favor de espeficiar el nombre de usuario");
                txtUserName.Focus();
                return;
            }
            try
            {
                user = new Users();
                user.Nickname = txtUserName.Text;
                user.Password = txtPassword.Text;
                Cursor.Current = Cursors.WaitCursor; 
                user = GetUser(user.Nickname, user.Password);
                if(user == null)
                {
                    MessageBox.Show("No se ha encontrado el usuario");
                    return;
                }
                Program.GlobalUser = user;
                MessageBox.Show("Bienvenidx " + user.Nickname);
                Visualizacion visualizacion = new Visualizacion();
                Cursor.Current = Cursors.Default;
                this.Hide();
                visualizacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
