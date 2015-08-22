namespace ProyectoIS2
{
    partial class AdministrarComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarComponentes));
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnTeclado = new System.Windows.Forms.Button();
            this.btnMouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMonitor.BackgroundImage")));
            this.btnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.Location = new System.Drawing.Point(39, 22);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(122, 78);
            this.btnMonitor.TabIndex = 0;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.BackgroundImage = global::ProyectoIS2.Properties.Resources.bg2;
            this.btnCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCPU.Image = ((System.Drawing.Image)(resources.GetObject("btnCPU.Image")));
            this.btnCPU.Location = new System.Drawing.Point(167, 22);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(122, 78);
            this.btnCPU.TabIndex = 1;
            this.btnCPU.Text = "CPU";
            this.btnCPU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTeclado.BackgroundImage")));
            this.btnTeclado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTeclado.Image = ((System.Drawing.Image)(resources.GetObject("btnTeclado.Image")));
            this.btnTeclado.Location = new System.Drawing.Point(39, 106);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(122, 78);
            this.btnTeclado.TabIndex = 2;
            this.btnTeclado.Text = "Teclado";
            this.btnTeclado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // btnMouse
            // 
            this.btnMouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMouse.BackgroundImage")));
            this.btnMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnMouse.Image")));
            this.btnMouse.Location = new System.Drawing.Point(167, 106);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(122, 78);
            this.btnMouse.TabIndex = 3;
            this.btnMouse.Text = "Mouse";
            this.btnMouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouse.UseVisualStyleBackColor = true;
            this.btnMouse.Click += new System.EventHandler(this.btnMouse_Click);
            // 
            // AdministrarComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoIS2.Properties.Resources.vAGZp;
            this.ClientSize = new System.Drawing.Size(333, 209);
            this.Controls.Add(this.btnMouse);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.btnMonitor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Componentes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnTeclado;
        private System.Windows.Forms.Button btnMouse;
    }
}