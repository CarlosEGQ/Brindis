namespace Miniproyecto
{
    partial class Visualizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizacion));
            this.pControl = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCategories = new System.Windows.Forms.ToolStripButton();
            this.btnClients = new System.Windows.Forms.ToolStripButton();
            this.btnUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pControl.Location = new System.Drawing.Point(1, 28);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(827, 454);
            this.pControl.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategories,
            this.btnClients,
            this.btnUsers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCategories
            // 
            this.btnCategories.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(194, 24);
            this.btnCategories.Text = "Administrar Categorias";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click_1);
            // 
            // btnClients
            // 
            this.btnClients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(173, 24);
            this.btnClients.Text = "Administrar Clientes";
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(173, 24);
            this.btnUsers.Text = "Administar Usuarios";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // Visualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 485);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visualizacion";
            this.Text = "Visualizacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Visualizacion_FormClosed);
            this.Load += new System.EventHandler(this.Visualizacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCategories;
        private System.Windows.Forms.ToolStripButton btnClients;
        private System.Windows.Forms.ToolStripButton btnUsers;
    }
}