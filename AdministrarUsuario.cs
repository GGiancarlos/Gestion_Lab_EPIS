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
    public partial class AdministrarUsuario : Form
    {
        public AdministrarUsuario()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        String boton = "";
        private void AdministrarUsuario_Load(object sender, EventArgs e)
        {
            cn.llenarCombo(cmbUsuario, "idTipo", "desTip", "tipo");
            btnAceptar.Hide();
            btnCancelar.Hide();
            txtId.Enabled = false;
            txtcontrasenia.Enabled = false;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            refresh();
        }
        private void refresh()
        {
            cn.consultar("SELECT idUsu,nomapeUsu,conUsu,corrUsu FROM usuario where TIPO_idTipo = '" + cmbUsuario.SelectedValue + "'", "usuario");
            datgrUsuario.DataSource = cn.ds.Tables["usuario"];
            datgrUsuario.Refresh();
        }
        private void datgrUsuario_Click(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(datgrUsuario.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(datgrUsuario.CurrentRow.Cells[1].Value);
            txtcontrasenia.Text = Convert.ToString(datgrUsuario.CurrentRow.Cells[2].Value);
            txtCorreo.Text = Convert.ToString(datgrUsuario.CurrentRow.Cells[3].Value);

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnAceptar.Show();
            btnCancelar.Show();
            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbUsuario.Enabled = false;
            txtId.Enabled = true;
            txtcontrasenia.Enabled = true;
            txtNombre.Enabled = true;
            txtCorreo.Enabled = true;

            txtId.Text = "";
            txtNombre.Text = "";
            txtcontrasenia.Text = "";
            txtCorreo.Text = "";
            boton = "insertar";


        }
        private void insertar()
        {

            String sql = "INSERT INTO `laboratorioepis`.`usuario`(idUsu,conUsu,nomapeUsu,corrUsu,TIPO_idTipo)VALUES('" +txtId.Text +"','"+ txtcontrasenia.Text+"','"+txtNombre.Text+"','"+txtCorreo.Text+ "','" + cmbUsuario.SelectedValue +"')";
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
            if (txtId.Text != "")
            {
                btnAceptar.Show();
                btnCancelar.Show();
                btnInsertar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                cmbUsuario.Enabled = false;

                txtId.Enabled = true;
                txtcontrasenia.Enabled = true;
                txtNombre.Enabled = true;
                txtCorreo.Enabled = true;
                boton = "modificar";
            }
            else
                MessageBox.Show("Seleccione que registro desea modificar");
        }

        private void modificar()
        {
            String sql = "UPDATE `laboratorioepis`.`usuario` set  conUsu ='" + txtcontrasenia.Text+"', nomapeUsu = '"+txtNombre.Text +"', corrUsu = '"+txtCorreo.Text+ "' where idUsu='" + txtId.Text + "'";

            MessageBox.Show(sql);
            if (cn.modificar(sql))
            {

                MessageBox.Show("Modificado");
            }

            else
                MessageBox.Show("No modificado");
            refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                string sql = "DELETE from `laboratorioepis`.`usuario` where idUsu='" + txtId.Text + "'";

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

            txtId.Enabled = false;
            txtcontrasenia.Enabled = false;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbUsuario.Enabled = true;
            datgrUsuario.Enabled = true;
            refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtcontrasenia.Enabled = false;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbUsuario.Enabled = true;
            datgrUsuario.Enabled = true;
        }

        private void cmbUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh();
        }

        
    }
}
