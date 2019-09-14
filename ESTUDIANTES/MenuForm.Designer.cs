namespace ESTUDIANTES
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resgistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudiandteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarInscripcioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resgistrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resgistrosToolStripMenuItem
            // 
            this.resgistrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstudiandteToolStripMenuItem,
            this.registrarInscripcioToolStripMenuItem});
            this.resgistrosToolStripMenuItem.Name = "resgistrosToolStripMenuItem";
            this.resgistrosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.resgistrosToolStripMenuItem.Text = "Resgistros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // registrarEstudiandteToolStripMenuItem
            // 
            this.registrarEstudiandteToolStripMenuItem.Name = "registrarEstudiandteToolStripMenuItem";
            this.registrarEstudiandteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registrarEstudiandteToolStripMenuItem.Text = "Registrar Estudiandte";
            this.registrarEstudiandteToolStripMenuItem.Click += new System.EventHandler(this.RegistrarEstudiandteToolStripMenuItem_Click);
            // 
            // registrarInscripcioToolStripMenuItem
            // 
            this.registrarInscripcioToolStripMenuItem.Name = "registrarInscripcioToolStripMenuItem";
            this.registrarInscripcioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registrarInscripcioToolStripMenuItem.Text = "Registrar Inscripcio";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 485);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bodoni MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resgistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudiandteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarInscripcioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}

