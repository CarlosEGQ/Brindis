namespace Miniproyecto
{
    partial class Crud_Categoria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud_Categoria));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CategoryGrid = new System.Windows.Forms.DataGridView();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(370, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(72, 22);
			this.btnNew.Text = "&Nueva";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(85, 22);
			this.btnSave.Text = "Guardar";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(85, 22);
			this.toolStripButton1.Text = "Eliminar";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtDes);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtClave);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(362, 74);
			this.panel1.TabIndex = 2;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(95, 41);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(100, 20);
			this.txtDes.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descripción:";
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
			// CategoryGrid
			// 
			this.CategoryGrid.AllowUserToAddRows = false;
			this.CategoryGrid.AllowUserToDeleteRows = false;
			this.CategoryGrid.AutoGenerateColumns = false;
			this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CategoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Descripcion});
			this.CategoryGrid.DataSource = this.categoryBindingSource;
			this.CategoryGrid.Location = new System.Drawing.Point(0, 150);
			this.CategoryGrid.MultiSelect = false;
			this.CategoryGrid.Name = "CategoryGrid";
			this.CategoryGrid.ReadOnly = true;
			this.CategoryGrid.RowHeadersVisible = false;
			this.CategoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CategoryGrid.Size = new System.Drawing.Size(360, 227);
			this.CategoryGrid.TabIndex = 3;
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataSource = typeof(Data.Category);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(90, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 33);
			this.label3.TabIndex = 4;
			this.label3.Text = "Categorias";
			// 
			// Clave
			// 
			this.Clave.DataPropertyName = "Id";
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "Description";
			this.Descripcion.HeaderText = "Description";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 240;
			// 
			// Crud_Categoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 389);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CategoryGrid);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crud_Categoria";
			this.Text = "Administrar Categorias";
			this.Load += new System.EventHandler(this.Crud_Categoria_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CategoryGrid;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
	}
}