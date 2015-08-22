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
    public partial class AdministrarSoftware : Form
    {
        public AdministrarSoftware()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        String boton = "";
        private void AdministrarSoftware_Load(object sender, EventArgs e)
        {
            cn.llenarCombo(cmbListSoftware, "idLab", "desLab", "laboratorio");
            btnAceptar.Hide();
            btnCancelar.Hide();
            txtCodSoft.Enabled = false;
            txtDescripcion.Enabled = false;
            refresh();
        }
        private void refresh()
        {
            cn.consultar("SELECT idSoft, desSoft FROM software where LABORATORIO_idLab = '" + cmbListSoftware.SelectedValue + "'", "software");
            datgrsoft.DataSource = cn.ds.Tables["software"];
            datgrsoft.Refresh();
        }
        private void datgrLaboratorio_Click(object sender, EventArgs e)
        {
            txtCodSoft.Text = Convert.ToString(datgrsoft.CurrentRow.Cells[0].Value);
            txtDescripcion.Text = Convert.ToString(datgrsoft.CurrentRow.Cells[1].Value);
        }

       
        private void btnMod_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            btnAceptar.Show();
            btnCancelar.Show();
            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbListSoftware.Enabled = false;
            txtCodSoft.Enabled = true;
            txtDescripcion.Enabled = true;

            txtCodSoft.Text = "";
            txtDescripcion.Text = "";
            boton = "insertar";


        }
        private void insertar()
        {

            String sql = "INSERT INTO `laboratorioepis`.`software`(idEqu,LABORATORIO_idsoft,desSoft)VALUES('" + txtCodSoft.Text + "','" + cmbListSoftware.SelectedValue + "','" + txtDescripcion.Text + "')";
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
            if (txtCodSoft.Text != "")
            {
                btnAceptar.Show();
                btnCancelar.Show();
                btnInsertar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                cmbListSoftware.Enabled = false;

                txtCodSoft.Enabled = true;
                txtDescripcion.Enabled = true;
                boton = "modificar";
            }
            else
                MessageBox.Show("Seleccione que registro desea modificar");
        }

        private void modificar()
        {
            String sql = "UPDATE `laboratorioepis`.`software` set  desEqu ='" + txtDescripcion.Text + "' where idSoft='" + txtCodSoft.Text + "'";

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
            if (txtCodSoft.Text != "")
            {
                string sql = "DELETE from `laboratorioepis`.`software` where idEqu='" + txtCodSoft.Text + "'";

                if (cn.eliminar(sql))
                {

                    MessageBox.Show("Eliminado");
                }
                else
                    MessageBox.Show("No Eliminado");
                refresh();
            }
            else
                MessageBox.Show("Seleccione que registro desea eliminar");
            
            
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

            txtCodSoft.Enabled = false;
            txtDescripcion.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbListSoftware.Enabled = true;
            datgrsoft.Enabled = true;
            refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodSoft.Enabled = false;
            txtDescripcion.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbListSoftware.Enabled = true;
            datgrsoft.Enabled = true;
        }

        private void cmbListSoftware_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh();
        }

        
    }
}
