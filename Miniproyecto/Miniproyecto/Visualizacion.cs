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
    public partial class Visualizacion : Form
    {
        public Visualizacion()
        {
            InitializeComponent();
        }
        private void btnCategories_Click_1(object sender, EventArgs e)
        {
            this.pControl.Controls.Clear();
            Crud_Categoria crud_Categoria = new Crud_Categoria()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            crud_Categoria.FormBorderStyle = FormBorderStyle.None;
            this.pControl.Controls.Add(crud_Categoria);
            crud_Categoria.Show();
        }

        private void Visualizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.pControl.Controls.Clear();
            Crud_Usuario crud_Usuario = new Crud_Usuario()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            crud_Usuario.FormBorderStyle = FormBorderStyle.None;
            this.pControl.Controls.Add(crud_Usuario);
            crud_Usuario.Show();
        }

        private void Visualizacion_Load(object sender, EventArgs e)
        {
            if(Program.GlobalUser.Rol != 1)
            {
                this.btnUsers.Visible = false;
                this.btnClients.Visible = false;
            }
        }
    }
}
