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
    public partial class ReportesAdministrador : Form
    {
        public ReportesAdministrador()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        private void ReportesAdministrador_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            cn.consultar("SELECT idRep, desRep,LABORATORIO_idLab,usuario_idUsu,estRep,fecha FROM reporte ", "reporte");
            datgrReporte.DataSource = cn.ds.Tables["reporte"];
            datgrReporte.Refresh();
        }
        private void datgrReporte_Click(object sender, EventArgs e)
        {
            txtIdreporte.Text = Convert.ToString(datgrReporte.CurrentRow.Cells[0].Value);
            txtDescripcion.Text = Convert.ToString(datgrReporte.CurrentRow.Cells[1].Value);
            txtLaboratorio.Text = Convert.ToString(datgrReporte.CurrentRow.Cells[2].Value);
            txtUsuario.Text = Convert.ToString(datgrReporte.CurrentRow.Cells[3].Value);
            


        }
        private void btnRevisado_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE `laboratorioepis`.`reporte` set estRep = 'Revisado' where idRep='" + txtIdreporte.Text + "'";

            // MessageBox.Show(sql);
            if (cn.modificar(sql))
            {

                MessageBox.Show("Reporte revisado");
            }
            else
                MessageBox.Show("Reporte no revisado");
            refresh();
        }
    }
}
