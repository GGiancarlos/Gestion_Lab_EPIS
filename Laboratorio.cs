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
    public partial class Laboratorio : Form
    {
        public Laboratorio()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        String boton = "";
        private void Laboratorio_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtDescripcion.Enabled = false;
            txtAula.Enabled = false;
            txtCapacidad.Enabled = false;
            btnInsertar.Show();
            btnModificar.Show();
            btnEliminar.Show();
            btnAceptar.Hide();
            btnCancelar.Hide();
            refresh();
        }

        private void refresh()
        {
            cn.consultar("SELECT idLab,desLab,numAulLab,capacidad  FROM laboratorio", "laboratorio");
            datgrLaboratorio.DataSource = cn.ds.Tables["laboratorio"];
            datgrLaboratorio.Refresh();
        }
        private void datgrLaboratorio_Click(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(datgrLaboratorio.CurrentRow.Cells[0].Value);
            txtDescripcion.Text = Convert.ToString(datgrLaboratorio.CurrentRow.Cells[1].Value);
            txtAula.Text = Convert.ToString(datgrLaboratorio.CurrentRow.Cells[2].Value);
            txtCapacidad.Text = Convert.ToString(datgrLaboratorio.CurrentRow.Cells[3].Value);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtDescripcion.Enabled = true;
            txtAula.Enabled = true;
            txtCapacidad.Enabled = true;
            btnAceptar.Show();
            btnCancelar.Show();

            txtId.Text = "";
            txtDescripcion.Text = "";
            txtAula.Text = "";
            txtCapacidad.Text = "";

            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            datgrLaboratorio.Enabled = false;
            boton = "insertar";


        }
        private void insertar()
        {
            
            String sql = "INSERT INTO `laboratorioepis`.`laboratorio`(`idLab`,`desLab`,`numAulLab`,`capacidad`)VALUES('" + txtId.Text + "','" + txtDescripcion.Text + "','"+txtAula.Text+ "´,´"+ txtCapacidad.Text +"')";
           // MessageBox.Show(sql);
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
            txtDescripcion.Enabled = true;
            txtAula.Enabled = true;
            txtCapacidad.Enabled = true;
            btnAceptar.Show();
            btnCancelar.Show();
            
            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            datgrLaboratorio.Enabled = false;
            boton = "modificar";
        }

        private void modificar()
        {
            String sql = "UPDATE `laboratorioepis`.`laboratorio` set desLab='" + txtDescripcion.Text + "', numAulLab = '" + txtAula.Text + "', capacidad = " + txtCapacidad.Text +"' where idLab='" + txtId.Text + "'";

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
            string sql = "DELETE from `laboratorioepis`.`laboratorio` where idLab='" + txtId.Text + "'";

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
            txtDescripcion.Enabled = false;
            txtAula.Enabled = false;
            txtCapacidad.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            datgrLaboratorio.Enabled = true;
            refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtDescripcion.Enabled = false;
            txtAula.Enabled = false;
            txtCapacidad.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            txtId.Text = "";
            txtDescripcion.Text = "";

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            datgrLaboratorio.Enabled = true;
        }
    }
}
