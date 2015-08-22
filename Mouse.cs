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
    public partial class Mouse : Form
    {
        public Mouse()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        String boton = "";
        private void Mouse_Load(object sender, EventArgs e)
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
            datgrMouse.Enabled = true;
            refresh();
        }

        private void refresh()
        {
            cn.consultar("SELECT idMou,marMou,estado,numserMou  FROM mouse", "mouse");
            datgrMouse.DataSource = cn.ds.Tables["mouse"];
            datgrMouse.Refresh();
        }
        private void LabEPIS_Click(object sender, EventArgs e)
        {

        }

        private void datgrMouse_Click(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(datgrMouse.CurrentRow.Cells[0].Value);
            txtMarca.Text = Convert.ToString(datgrMouse.CurrentRow.Cells[1].Value);
            String etd = Convert.ToString(datgrMouse.CurrentRow.Cells[2].Value);
            if (etd.Equals("Disponible"))
                rbDisponible.Checked = true;
            if (etd.Equals("No Disponible"))
                rbNoDisponible.Checked = true;
            if (etd.Equals("Daniado"))
                rbDaniado.Checked = true;
            txtSerie.Text = Convert.ToString(datgrMouse.CurrentRow.Cells[3].Value);

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
            datgrMouse.Enabled = false;
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
            String sql = "INSERT INTO `laboratorioepis`.`mouse`(`idMou`,`marMou`,`estado`,`numserMou`)VALUES('" + txtId.Text + "','" + txtMarca.Text + "','" + estado + "' , '" + txtSerie.Text + "')";
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
            datgrMouse.Enabled = false;
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

            String sql = "UPDATE `laboratorioepis`.`mouse` set marMou='" + txtMarca.Text + "' , estado='" + estado + "', numserMou='" + txtSerie.Text + "' where idMou='" + txtId.Text + "'";

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
            string sql = "DELETE from `laboratorioepis`.`mouse` where idMou='" + txtId.Text + "'";

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
            datgrMouse.Enabled = true;
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
            datgrMouse.Enabled = true;
        }

    }
}
