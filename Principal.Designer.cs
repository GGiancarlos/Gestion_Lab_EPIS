namespace ProyectoIS2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Btn_Inicio = new System.Windows.Forms.Button();
            this.LabEPIS = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Horario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picIma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIma)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.BackColor = System.Drawing.Color.Silver;
            this.Btn_Inicio.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio.Location = new System.Drawing.Point(22, 110);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.Size = new System.Drawing.Size(92, 27);
            this.Btn_Inicio.TabIndex = 1;
            this.Btn_Inicio.Text = "Inicio";
            this.Btn_Inicio.UseVisualStyleBackColor = false;
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // LabEPIS
            // 
            this.LabEPIS.AutoSize = true;
            this.LabEPIS.BackColor = System.Drawing.Color.Transparent;
            this.LabEPIS.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.LabEPIS.ForeColor = System.Drawing.Color.Azure;
            this.LabEPIS.Location = new System.Drawing.Point(314, 31);
            this.LabEPIS.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LabEPIS.Name = "LabEPIS";
            this.LabEPIS.Size = new System.Drawing.Size(213, 28);
            this.LabEPIS.TabIndex = 9;
            this.LabEPIS.Text = "Laboratorio - EPIS";
            this.LabEPIS.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.Silver;
            this.btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ayuda.Location = new System.Drawing.Point(706, 31);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(47, 33);
            this.btn_Ayuda.TabIndex = 11;
            this.btn_Ayuda.Text = "?";
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Horario
            // 
            this.btn_Horario.BackColor = System.Drawing.Color.Silver;
            this.btn_Horario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Horario.Location = new System.Drawing.Point(22, 164);
            this.btn_Horario.Name = "btn_Horario";
            this.btn_Horario.Size = new System.Drawing.Size(92, 27);
            this.btn_Horario.TabIndex = 12;
            this.btn_Horario.Text = "Horarios";
            this.btn_Horario.UseVisualStyleBackColor = false;
            this.btn_Horario.Click += new System.EventHandler(this.btn_Horario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            this.time.Interval = 500;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picIma
            // 
            this.picIma.Image = ((System.Drawing.Image)(resources.GetObject("picIma.Image")));
            this.picIma.Location = new System.Drawing.Point(170, 110);
            this.picIma.Name = "picIma";
            this.picIma.Size = new System.Drawing.Size(478, 284);
            this.picIma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIma.TabIndex = 0;
            this.picIma.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoIS2.Properties.Resources.app_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Horario);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.LabEPIS);
            this.Controls.Add(this.Btn_Inicio);
            this.Controls.Add(this.picIma);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio EPISUNSA";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIma;
        private System.Windows.Forms.Button Btn_Inicio;
        private System.Windows.Forms.Label LabEPIS;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_Horario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer time;
    }
}