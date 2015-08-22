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
    public partial class AdministrarEquipo : Form
    {
        public AdministrarEquipo()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();
        String boton = "";

        private void Inventario_Load(object sender, EventArgs e)
        {
            cn.llenarCombo(cmbLabEquipo, "idLab", "desLab", "laboratorio");
            btnAceptar.Hide();
            btnCancelar.Hide();
            txtEquipo.Enabled = false;
            txtDescripcion.Enabled = false;
            cmbMonitor.Enabled = false;
            cmbCPU.Enabled = false;
            cmbTeclado.Enabled = false;
            cmbMouse.Enabled = false;
            refresh();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {

        }
        
        private void refresh()
        {

            
            cn.llenarCombo(cmbMonitor, "idMon", "marMon", "monitor", "Disponible");
            cn.llenarCombo(cmbMouse, "idMou", "marMou", "mouse", "Disponible");
            cn.llenarCombo(cmbCPU, "idCPU", "marCPU", "cpu", "Disponible");
            cn.llenarCombo(cmbTeclado, "idTec", "marTec", "teclado", "Disponible");

            cn.consultar("SELECT idEqu, MONITOR_idMon,TECLADO_idTec,MOUSE_idMou,CPU_idCPU,desEqu FROM equipo where LABORATORIO_idLab = '"+cmbLabEquipo.SelectedValue+"'", "equipo");
            datgrEquipo.DataSource = cn.ds.Tables["equipo"];
            cmbLabEquipo.Refresh();
            cmbMonitor.Refresh();
            cmbMouse.Refresh();
            cmbTeclado.Refresh();
            cmbCPU.Refresh();
            datgrEquipo.Refresh();
        }
        private void datgrLaboratorio_Click(object sender, EventArgs e)
        {
            txtEquipo.Text = Convert.ToString(datgrEquipo.CurrentRow.Cells[0].Value);
            cmbMonitor.Text = Convert.ToString(datgrEquipo.CurrentRow.Cells[1].Value);
            cmbTeclado.Text = Convert.ToString(datgrEquipo.CurrentRow.Cells[2].Value);
            cmbMouse.Text = Convert.ToString(datgrEquipo.CurrentRow.Cells[3].Value);
            cmbCPU.Text = Convert.ToString(datgrEquipo.CurrentRow.Cells[4].Value);
            txtDescripcion.Text = Convert.ToString(datgrEquipo.CurrentRow.Cells[5].Value);

           
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            txtEquipo.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbMonitor.Enabled = true;
            cmbCPU.Enabled = true;
            cmbTeclado.Enabled = true;
            cmbMouse.Enabled = true;
            cmbLabEquipo.Enabled = false;

            txtEquipo.Text = "";
            cmbMonitor.Text = "";
            cmbCPU.Text = "";
            cmbTeclado.Text = "";
            cmbMouse.Text = "";
            txtDescripcion.Text = "";

            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAceptar.Show();
            btnCancelar.Show();
            datgrEquipo.Enabled = false;
            boton = "insertar";


        }
        private void insertar()
        {

            String sql = "INSERT INTO `laboratorioepis`.`equipo`(idEqu,LABORATORIO_idLab, MONITOR_idMon,TECLADO_idTec,MOUSE_idMou,CPU_idCPU,desEqu)VALUES('" 
                + txtEquipo.Text + "','" + cmbLabEquipo.SelectedValue + "','"+cmbMonitor.SelectedValue+"','"+cmbTeclado.SelectedValue+"','"+cmbMouse.SelectedValue+"','"+cmbCPU.SelectedValue+"','"+txtDescripcion.Text+"')";
            //MessageBox.Show(sql);
            //Modificamos las tablas 
            //monitor
            String sqlMon = "UPDATE `laboratorioepis`.`monitor` set estado = 'No Disponible' where idMon='" + cmbMonitor.SelectedValue + "'";
            //mouse
            String sqlMou = "UPDATE `laboratorioepis`.`mouse` set estado = 'No Disponible' where idMou='" + cmbMouse.SelectedValue + "'";
            //cpu
            String sqlCpu = "UPDATE `laboratorioepis`.`cpu` set estado = 'No Disponible' where idcPU='" + cmbCPU.SelectedValue + "'";
            //teclado
            String sqlTec = "UPDATE `laboratorioepis`.`teclado` set estado = 'No Disponible' where idTec='" + cmbTeclado.SelectedValue + "'";
            if (cn.insertar(sql))
            {
                cn.modificar(sqlMon);
                cn.modificar(sqlMou);
                cn.modificar(sqlCpu);
                cn.modificar(sqlTec);
                MessageBox.Show("insertado");
                refresh();
            }
            else
                MessageBox.Show("No insertado, Verfique los datos ingresados");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtEquipo.Enabled = false;
            txtDescripcion.Enabled = true;
            cmbMonitor.Enabled = true;
            cmbCPU.Enabled = true;
            cmbTeclado.Enabled = true;
            cmbMouse.Enabled = true;
            cmbLabEquipo.Enabled = false;
            datgrEquipo.Enabled = false;

            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAceptar.Show();
            btnCancelar.Show();
            boton = "modificar";
        }

        private void modificar()
        {
            String sql = "UPDATE `laboratorioepis`.`equipo` set MONITOR_idMon = '"+cmbMonitor.SelectedValue+",TECLADO_idTec = '"+ cmbTeclado.SelectedValue+"',MOUSE_idMou = '"+cmbMouse.SelectedValue+"',CPU_idCPU ='"+cmbCPU.SelectedValue+"' , deEqu ='" + txtDescripcion.Text + "' where idEqu='" + txtEquipo.Text + "'";
            
           // MessageBox.Show(sql);
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
            string sql = "DELETE from `laboratorioepis`.`equipo` where idEqu='" + txtEquipo.Text + "'";
            //Monitor
            String sqlMon = "UPDATE `laboratorioepis`.`monitor` set estado = 'Disponible' where idMon='" + cmbMonitor.Text + "'";
            //mouse
            String sqlMou = "UPDATE `laboratorioepis`.`mouse` set estado = 'Disponible' where idMou='" + cmbMouse.Text + "'";
            //cpu
            String sqlCpu = "UPDATE `laboratorioepis`.`cpu` set estado = 'Disponible' where idcPU='" + cmbCPU.Text + "'";
            //teclado
            String sqlTec = "UPDATE `laboratorioepis`.`teclado` set estado = 'Disponible' where idTec='" + cmbTeclado.Text + "'";
            if (cn.eliminar(sql))
            {
                cn.modificar(sqlMon);
                cn.modificar(sqlMou);
                cn.modificar(sqlCpu);
                cn.modificar(sqlTec);
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

            txtEquipo.Enabled = false;
            txtDescripcion.Enabled = false;
            cmbLabEquipo.Enabled = true;
            cmbMonitor.Enabled = false;
            cmbTeclado.Enabled = false;
            cmbMouse.Enabled = false;
            cmbCPU.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            datgrEquipo.Enabled = true;
            refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEquipo.Enabled = false;
            txtDescripcion.Enabled = false;
            cmbLabEquipo.Enabled = true;
            cmbMonitor.Enabled = false;
            cmbTeclado.Enabled = false;
            cmbMouse.Enabled = false;
            cmbCPU.Enabled = false;
            btnAceptar.Hide();
            btnCancelar.Hide();

            btnInsertar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            datgrEquipo.Enabled = true;
            refresh();
        }

        private void cmbLabEquipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
