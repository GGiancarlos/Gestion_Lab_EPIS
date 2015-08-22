namespace ProyectoIS2
{
    partial class Horario
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
            this.groupLab = new System.Windows.Forms.GroupBox();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.datgrHorario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.checkLunes = new System.Windows.Forms.CheckBox();
            this.checkMartes = new System.Windows.Forms.CheckBox();
            this.checkMiercoles = new System.Windows.Forms.CheckBox();
            this.checkJueves = new System.Windows.Forms.CheckBox();
            this.checkViernes = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMieFin = new System.Windows.Forms.TextBox();
            this.txtMieIni = new System.Windows.Forms.TextBox();
            this.txtJueFin = new System.Windows.Forms.TextBox();
            this.txtJueIni = new System.Windows.Forms.TextBox();
            this.txtVieFin = new System.Windows.Forms.TextBox();
            this.txtVieIni = new System.Windows.Forms.TextBox();
            this.txtMarFin = new System.Windows.Forms.TextBox();
            this.txtMarIni = new System.Windows.Forms.TextBox();
            this.txtLunFin = new System.Windows.Forms.TextBox();
            this.txtLunIni = new System.Windows.Forms.TextBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgrHorario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLab
            // 
            this.groupLab.Controls.Add(this.cmbLab);
            this.groupLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLab.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupLab.Location = new System.Drawing.Point(12, 23);
            this.groupLab.Name = "groupLab";
            this.groupLab.Size = new System.Drawing.Size(226, 56);
            this.groupLab.TabIndex = 66;
            this.groupLab.TabStop = false;
            this.groupLab.Text = "Equipos de Laboratorio :";
            // 
            // cmbLab
            // 
            this.cmbLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(44, 19);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(147, 23);
            this.cmbLab.TabIndex = 0;
            this.cmbLab.SelectionChangeCommitted += new System.EventHandler(this.cmbLab_SelectionChangeCommitted);
            // 
            // datgrHorario
            // 
            this.datgrHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrHorario.Location = new System.Drawing.Point(12, 250);
            this.datgrHorario.Name = "datgrHorario";
            this.datgrHorario.Size = new System.Drawing.Size(642, 234);
            this.datgrHorario.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(24, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 119);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Silver;
            this.btnInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInsertar.Location = new System.Drawing.Point(37, 19);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModificar.Location = new System.Drawing.Point(37, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Location = new System.Drawing.Point(37, 91);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // checkLunes
            // 
            this.checkLunes.AutoSize = true;
            this.checkLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkLunes.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkLunes.Location = new System.Drawing.Point(80, 50);
            this.checkLunes.Name = "checkLunes";
            this.checkLunes.Size = new System.Drawing.Size(60, 17);
            this.checkLunes.TabIndex = 68;
            this.checkLunes.Text = "Lunes";
            this.checkLunes.UseVisualStyleBackColor = true;
            // 
            // checkMartes
            // 
            this.checkMartes.AutoSize = true;
            this.checkMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkMartes.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkMartes.Location = new System.Drawing.Point(162, 50);
            this.checkMartes.Name = "checkMartes";
            this.checkMartes.Size = new System.Drawing.Size(64, 17);
            this.checkMartes.TabIndex = 69;
            this.checkMartes.Text = "Martes";
            this.checkMartes.UseVisualStyleBackColor = true;
            // 
            // checkMiercoles
            // 
            this.checkMiercoles.AutoSize = true;
            this.checkMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkMiercoles.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkMiercoles.Location = new System.Drawing.Point(242, 50);
            this.checkMiercoles.Name = "checkMiercoles";
            this.checkMiercoles.Size = new System.Drawing.Size(80, 17);
            this.checkMiercoles.TabIndex = 70;
            this.checkMiercoles.Text = "Miercoles";
            this.checkMiercoles.UseVisualStyleBackColor = true;
            // 
            // checkJueves
            // 
            this.checkJueves.AutoSize = true;
            this.checkJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkJueves.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkJueves.Location = new System.Drawing.Point(328, 50);
            this.checkJueves.Name = "checkJueves";
            this.checkJueves.Size = new System.Drawing.Size(66, 17);
            this.checkJueves.TabIndex = 71;
            this.checkJueves.Text = "Jueves";
            this.checkJueves.UseVisualStyleBackColor = true;
            // 
            // checkViernes
            // 
            this.checkViernes.AutoSize = true;
            this.checkViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkViernes.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkViernes.Location = new System.Drawing.Point(409, 50);
            this.checkViernes.Name = "checkViernes";
            this.checkViernes.Size = new System.Drawing.Size(68, 17);
            this.checkViernes.TabIndex = 72;
            this.checkViernes.Text = "Viernes\r\n";
            this.checkViernes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.cmbGrupo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMieFin);
            this.groupBox2.Controls.Add(this.txtMieIni);
            this.groupBox2.Controls.Add(this.txtJueFin);
            this.groupBox2.Controls.Add(this.txtJueIni);
            this.groupBox2.Controls.Add(this.txtVieFin);
            this.groupBox2.Controls.Add(this.txtVieIni);
            this.groupBox2.Controls.Add(this.txtMarFin);
            this.groupBox2.Controls.Add(this.txtMarIni);
            this.groupBox2.Controls.Add(this.txtLunFin);
            this.groupBox2.Controls.Add(this.txtLunIni);
            this.groupBox2.Controls.Add(this.cmbCurso);
            this.groupBox2.Controls.Add(this.checkLunes);
            this.groupBox2.Controls.Add(this.checkViernes);
            this.groupBox2.Controls.Add(this.checkMartes);
            this.groupBox2.Controls.Add(this.checkJueves);
            this.groupBox2.Controls.Add(this.checkMiercoles);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Azure;
            this.groupBox2.Location = new System.Drawing.Point(197, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 137);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Curso";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(184, 19);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 86;
            this.cmbGrupo.SelectionChangeCommitted += new System.EventHandler(this.cmbGrupo_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Inicio";
            // 
            // txtMieFin
            // 
            this.txtMieFin.Location = new System.Drawing.Point(245, 101);
            this.txtMieFin.Name = "txtMieFin";
            this.txtMieFin.Size = new System.Drawing.Size(60, 20);
            this.txtMieFin.TabIndex = 83;
            // 
            // txtMieIni
            // 
            this.txtMieIni.Location = new System.Drawing.Point(245, 73);
            this.txtMieIni.Name = "txtMieIni";
            this.txtMieIni.Size = new System.Drawing.Size(60, 20);
            this.txtMieIni.TabIndex = 82;
            // 
            // txtJueFin
            // 
            this.txtJueFin.Location = new System.Drawing.Point(328, 101);
            this.txtJueFin.Name = "txtJueFin";
            this.txtJueFin.Size = new System.Drawing.Size(60, 20);
            this.txtJueFin.TabIndex = 81;
            // 
            // txtJueIni
            // 
            this.txtJueIni.Location = new System.Drawing.Point(328, 73);
            this.txtJueIni.Name = "txtJueIni";
            this.txtJueIni.Size = new System.Drawing.Size(60, 20);
            this.txtJueIni.TabIndex = 80;
            // 
            // txtVieFin
            // 
            this.txtVieFin.Location = new System.Drawing.Point(409, 101);
            this.txtVieFin.Name = "txtVieFin";
            this.txtVieFin.Size = new System.Drawing.Size(60, 20);
            this.txtVieFin.TabIndex = 79;
            // 
            // txtVieIni
            // 
            this.txtVieIni.Location = new System.Drawing.Point(409, 73);
            this.txtVieIni.Name = "txtVieIni";
            this.txtVieIni.Size = new System.Drawing.Size(60, 20);
            this.txtVieIni.TabIndex = 78;
            // 
            // txtMarFin
            // 
            this.txtMarFin.Location = new System.Drawing.Point(162, 101);
            this.txtMarFin.Name = "txtMarFin";
            this.txtMarFin.Size = new System.Drawing.Size(60, 20);
            this.txtMarFin.TabIndex = 77;
            // 
            // txtMarIni
            // 
            this.txtMarIni.Location = new System.Drawing.Point(162, 73);
            this.txtMarIni.Name = "txtMarIni";
            this.txtMarIni.Size = new System.Drawing.Size(60, 20);
            this.txtMarIni.TabIndex = 76;
            // 
            // txtLunFin
            // 
            this.txtLunFin.Location = new System.Drawing.Point(80, 101);
            this.txtLunFin.Name = "txtLunFin";
            this.txtLunFin.Size = new System.Drawing.Size(60, 20);
            this.txtLunFin.TabIndex = 75;
            // 
            // txtLunIni
            // 
            this.txtLunIni.Location = new System.Drawing.Point(80, 73);
            this.txtLunIni.Name = "txtLunIni";
            this.txtLunIni.Size = new System.Drawing.Size(60, 20);
            this.txtLunIni.TabIndex = 74;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(16, 19);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(150, 21);
            this.cmbCurso.TabIndex = 73;
            this.cmbCurso.SelectionChangeCommitted += new System.EventHandler(this.cmbcurso_SelectionChangeCommitted);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAceptar.Location = new System.Drawing.Point(359, 17);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 74;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoIS2.Properties.Resources.vAGZp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupLab);
            this.Controls.Add(this.datgrHorario);
            this.Name = "Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            this.groupLab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datgrHorario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLab;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.DataGridView datgrHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox checkLunes;
        private System.Windows.Forms.CheckBox checkMartes;
        private System.Windows.Forms.CheckBox checkMiercoles;
        private System.Windows.Forms.CheckBox checkJueves;
        private System.Windows.Forms.CheckBox checkViernes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMieFin;
        private System.Windows.Forms.TextBox txtMieIni;
        private System.Windows.Forms.TextBox txtJueFin;
        private System.Windows.Forms.TextBox txtJueIni;
        private System.Windows.Forms.TextBox txtVieFin;
        private System.Windows.Forms.TextBox txtVieIni;
        private System.Windows.Forms.TextBox txtMarFin;
        private System.Windows.Forms.TextBox txtMarIni;
        private System.Windows.Forms.TextBox txtLunFin;
        private System.Windows.Forms.TextBox txtLunIni;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Button btnAceptar;

    }
}