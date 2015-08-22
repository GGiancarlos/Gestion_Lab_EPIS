using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIS2
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_CrearUser_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matriculas formMat = new Matriculas();
            formMat.Show();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void btnListEquipo_Click(object sender, EventArgs e)
        {
            AdministrarEquipo inventario = new AdministrarEquipo();
            inventario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdministrarComponentes admCom = new AdministrarComponentes();
            admCom.Show();
        }

        private void Administardor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal formPrin = new Principal();
            formPrin.Show();
        }

        private void btnListSoft_Click(object sender, EventArgs e)
        {
            AdministrarSoftware formSoft = new AdministrarSoftware();
            formSoft.Show();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            ReportesAdministrador formAdmRep = new ReportesAdministrador();
            formAdmRep.Show();
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio formLab = new Laboratorio();
            formLab.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdministrarUsuario formVerUsuario = new AdministrarUsuario();
            formVerUsuario.Show();
        }

        private void btnAdmHor_Click(object sender, EventArgs e)
        {
            Horario formHorario = new Horario();
            formHorario.Show();
        }

        
    }
}
