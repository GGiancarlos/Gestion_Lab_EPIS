namespace ProyectoIS2
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnAdmHor = new System.Windows.Forms.Button();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.btnListSoft = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnListEquipo = new System.Windows.Forms.Button();
            this.btnCrearUsu = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btn_CrearUser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmHor
            // 
            this.btnAdmHor.Location = new System.Drawing.Point(36, 102);
            this.btnAdmHor.Name = "btnAdmHor";
            this.btnAdmHor.Size = new System.Drawing.Size(142, 29);
            this.btnAdmHor.TabIndex = 32;
            this.btnAdmHor.Text = "Administrar horarios";
            this.btnAdmHor.UseVisualStyleBackColor = true;
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.Location = new System.Drawing.Point(18, 32);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(142, 29);
            this.btnLaboratorio.TabIndex = 31;
            this.btnLaboratorio.Text = "Listar Laboratorios";
            this.btnLaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnListSoft
            // 
            this.btnListSoft.Location = new System.Drawing.Point(18, 67);
            this.btnListSoft.Name = "btnListSoft";
            this.btnListSoft.Size = new System.Drawing.Size(142, 29);
            this.btnListSoft.TabIndex = 30;
            this.btnListSoft.Text = "Listar Software";
            this.btnListSoft.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 29);
            this.button4.TabIndex = 29;
            this.button4.Text = "Administrar componentes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnListEquipo
            // 
            this.btnListEquipo.Location = new System.Drawing.Point(18, 102);
            this.btnListEquipo.Name = "btnListEquipo";
            this.btnListEquipo.Size = new System.Drawing.Size(142, 29);
            this.btnListEquipo.TabIndex = 28;
            this.btnListEquipo.Text = "Listar Equipos";
            this.btnListEquipo.UseVisualStyleBackColor = true;
            // 
            // btnCrearUsu
            // 
            this.btnCrearUsu.Location = new System.Drawing.Point(36, 32);
            this.btnCrearUsu.Name = "btnCrearUsu";
            this.btnCrearUsu.Size = new System.Drawing.Size(142, 29);
            this.btnCrearUsu.TabIndex = 27;
            this.btnCrearUsu.Text = "Matricular Alumno";
            this.btnCrearUsu.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Californian FB", 15F);
            this.Title.Location = new System.Drawing.Point(180, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(172, 24);
            this.Title.TabIndex = 25;
            this.Title.Text = "ADMINISTRADOR";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(36, 68);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(142, 27);
            this.btnVerificar.TabIndex = 24;
            this.btnVerificar.Text = "Verificar Reporte";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // btn_CrearUser
            // 
            this.btn_CrearUser.Location = new System.Drawing.Point(19, 32);
            this.btn_CrearUser.Name = "btn_CrearUser";
            this.btn_CrearUser.Size = new System.Drawing.Size(128, 27);
            this.btn_CrearUser.TabIndex = 23;
            this.btn_CrearUser.Text = "Crear Usuario";
            this.btn_CrearUser.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_CrearUser);
            this.groupBox1.Location = new System.Drawing.Point(59, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 153);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Usuarios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ver Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLaboratorio);
            this.groupBox2.Controls.Add(this.btnListSoft);
            this.groupBox2.Controls.Add(this.btnListEquipo);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(59, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 198);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrar Laboratorios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdmHor);
            this.groupBox3.Controls.Add(this.btnVerificar);
            this.groupBox3.Controls.Add(this.btnCrearUsu);
            this.groupBox3.Location = new System.Drawing.Point(290, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 153);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funciones del Administrador";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Title);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmHor;
        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.Button btnListSoft;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnListEquipo;
        private System.Windows.Forms.Button btnCrearUsu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btn_CrearUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}