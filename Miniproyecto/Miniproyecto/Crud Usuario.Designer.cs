namespace Miniproyecto
{
    partial class Crud_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud_Usuario));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPassword2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.opAdmin = new System.Windows.Forms.RadioButton();
			this.opNormal = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Grid = new System.Windows.Forms.DataGridView();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnDelete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(448, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNew
			// 
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(62, 22);
			this.btnNew.Text = "&Nuevo";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(69, 22);
			this.btnSave.Text = "&Guardar";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(70, 22);
			this.btnDelete.Text = "&Eliminar";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtPassword2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtClave);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(4, 61);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(438, 166);
			this.panel1.TabIndex = 2;
			// 
			// txtPassword2
			// 
			this.txtPassword2.Location = new System.Drawing.Point(310, 67);
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.PasswordChar = '*';
			this.txtPassword2.Size = new System.Drawing.Size(100, 20);
			this.txtPassword2.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(201, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Confirmar Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(95, 67);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Password:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.opAdmin);
			this.panel2.Controls.Add(this.opNormal);
			this.panel2.Location = new System.Drawing.Point(95, 93);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(171, 26);
			this.panel2.TabIndex = 10;
			// 
			// opAdmin
			// 
			this.opAdmin.AutoSize = true;
			this.opAdmin.Location = new System.Drawing.Point(3, 3);
			this.opAdmin.Name = "opAdmin";
			this.opAdmin.Size = new System.Drawing.Size(88, 17);
			this.opAdmin.TabIndex = 5;
			this.opAdmin.TabStop = true;
			this.opAdmin.Text = "Administrador";
			this.opAdmin.UseVisualStyleBackColor = true;
			// 
			// opNormal
			// 
			this.opNormal.AutoSize = true;
			this.opNormal.Location = new System.Drawing.Point(97, 3);
			this.opNormal.Name = "opNormal";
			this.opNormal.Size = new System.Drawing.Size(58, 17);
			this.opNormal.TabIndex = 6;
			this.opNormal.TabStop = true;
			this.opNormal.Text = "Normal";
			this.opNormal.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Rol:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(95, 41);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nickname:";
			// 
			// txtClave
			// 
			this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtClave.Location = new System.Drawing.Point(95, 15);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(100, 20);
			this.txtClave.TabIndex = 1;
			this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
			this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clave:";
			// 
			// Grid
			// 
			this.Grid.AllowUserToAddRows = false;
			this.Grid.AllowUserToDeleteRows = false;
			this.Grid.AutoGenerateColumns = false;
			this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
			this.Grid.DataSource = this.usersBindingSource;
			this.Grid.Location = new System.Drawing.Point(5, 233);
			this.Grid.MultiSelect = false;
			this.Grid.Name = "Grid";
			this.Grid.ReadOnly = true;
			this.Grid.RowHeadersVisible = false;
			this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Grid.Size = new System.Drawing.Size(437, 154);
			this.Grid.TabIndex = 3;
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataSource = typeof(Data.Users);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(141, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 33);
			this.label6.TabIndex = 5;
			this.label6.Text = "Usuarios";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Clave";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nicknameDataGridViewTextBoxColumn
			// 
			this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
			this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
			this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
			this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "Contraseña";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rolDataGridViewTextBoxColumn
			// 
			this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
			this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
			this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
			this.rolDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Crud_Usuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 392);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Grid);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crud_Usuario";
			this.Text = "Crud_Usuario";
			this.Load += new System.EventHandler(this.Crud_Usuario_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton opAdmin;
        private System.Windows.Forms.RadioButton opNormal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
	}
}