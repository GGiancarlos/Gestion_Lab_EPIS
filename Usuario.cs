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
    public partial class Usuario : Form
    {
        String id;
        String nom;
        String correo;
        public Usuario(String id, String nom , String correo)
        {
            InitializeComponent();
            this.id = id;
            this.nom = nom;
            this.correo = correo;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportesUsuario formReporte = new ReportesUsuario(id, nom, correo);
            formReporte.Show();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
