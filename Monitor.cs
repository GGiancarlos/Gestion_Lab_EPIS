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
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
            
        }

        Conexion cn = new Conexion();
        String boton = "";
        private void Monitor_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtMarca.Enabled = false;
            txtSerie.Enabled = false;
            groupEstado.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();
            rbDisponible.Enabled = false;
            rbNoDisponible.Enabled = false;
            rbDaniado.Enabled = false;
            datgrMonitor.Enabled = true;
            refresh();
        }
        private void refresh()
        {
            cn.consultar("SELECT idMon,marMon,estado,numserMon  FROM monitor", "monitor");
            datgrMonitor.DataSource = cn.ds.Tables["monitor"];
            datgrMonitor.Refresh();
        }
        

        private void datgrMonitor_Click(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(datgrMonitor.CurrentRow.Cells[0].Value);
            txtMarca.Text = Convert.ToString(datgrMonitor.CurrentRow.Cells[1].Value);
            String etd = Convert.ToString(datgrMonitor.CurrentRow.Cells[2].Value);
            if (etd.Equals("Disponible") )
                rbDisponible.Checked = true;
            if (etd.Equals("No Disponible"))
                rbNoDisponible.Checked = true;
            if (etd.Equals("Daniado"))
                rbDaniado.Checked = true;
            txtSerie.Text = Convert.ToString(datgrMonitor.CurrentRow.Cells[3].Value);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtMarca.Enabled = true;
            txtSerie.Enabled = true;
            groupEstado.Enabled = true;
            btnAceptar.Show();
            btnCancelar.Show();
            rbDisponible.Enabled = true;
            rbNoDisponible.Enabled = true;
            rbDaniado.Enabled = true;

            txtId.Text = "";
            txtMarca.Text = "";
            txtSerie.Text = "";
            rbDisponible.Checked = false;
            rbNoDisponible.Checked = false;
            rbDaniado.Checked = false;

            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            datgrMonitor.Enabled = false;
            boton = "insertar";


        }
        private void insertar()
        {
            String estado = "";
            if (rbDisponible.Checked)
                estado = "Disponible";
            if (rbNoDisponible.Checked)
                estado = "No Disponible";
            if (rbDaniado.Checked)
                estado = "Daniado";
            //verficar laboratorio.usuario
           String sql = "INSERT INTO `laboratorioepis`.`monitor`(`idMon`,`marMon`,`estado`,`numserMon`)VALUES('" + txtId.Text + "','" + txtMarca.Text + "','" + estado + "' , '" +txtSerie.Text + "')" ;
            MessageBox.Show(sql);
            if (cn.insertar(sql))
            {
                MessageBox.Show("insertado");
                refresh();
            }
            else
                MessageBox.Show("No insertado, Verfique los datos ingresados");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtMarca.Enabled = true;
            txtSerie.Enabled = true;
            groupEstado.Enabled = true;
            btnAceptar.Show();
            btnCancelar.Show();
            rbDisponible.Enabled = true;
            rbNoDisponible.Enabled = true;
            rbDaniado.Enabled = true;

            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            datgrMonitor.Enabled = false;
            boton = "modificar";
        }

        private void modificar()
        {
            String estado = "";
            if (rbDisponible.Checked)
                estado = "Disponible";
            if (rbNoDisponible.Checked)
                estado = "No Disponible";
            if (rbDaniado.Checked)
                estado = "Daniado";

            String sql = "UPDATE `laboratorioepis`.`monitor` set marMon='" + txtMarca.Text + "' , estado='" + estado + "', numserMon='" + txtSerie.Text + "' where idMon='" + txtId.Text + "'";

            MessageBox.Show(sql);
            if (cn.modificar(sql))
            {

                MessageBox.Show("Modificado");
            }
            else
                MessageBox.Show("no modificado");
            refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from `laboratorioepis`.`monitor` where idMon='" + txtId.Text + "'";

            if (cn.eliminar(sql))
            {

                MessageBox.Show("Eliminado");
            }
            else
                MessageBox.Show("No Eliminado");
            refresh();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (boton)
            {
                case "insertar":
                    insertar();
                    break;
                case "modificar":
                    modificar();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            txtId.Enabled = false;
            txtMarca.Enabled = false;
            txtSerie.Enabled = false;
            groupEstado.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();
            rbDisponible.Enabled = false;
            rbNoDisponible.Enabled = false;
            rbDaniado.Enabled = false;
            rbDisponible.Checked = false;
            rbNoDisponible.Checked = false;
            rbDaniado.Checked = false;

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            datgrMonitor.Enabled = true;
            refresh();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtMarca.Enabled = false;
            txtSerie.Enabled = false;
            groupEstado.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();
            rbDisponible.Enabled = false;
            rbNoDisponible.Enabled = false;
            rbDaniado.Enabled = false;

            txtId.Text = "";
            txtMarca.Text = "";
            txtSerie.Text = "";
            rbDisponible.Checked = false;
            rbNoDisponible.Checked = false;
            rbDaniado.Checked = false;

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            datgrMonitor.Enabled = true;
        }
    }
}
