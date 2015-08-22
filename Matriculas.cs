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
    public partial class Matriculas : Form
    {
        public Matriculas()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        int idMatricula = 0;
        String idDetMatricula = "";
        String horario = "";
        private void Matriculas_Load(object sender, EventArgs e)
        {
            cn.llenarCombo(cmbCurso, "idCurso", "desCurso", "curso");
           cargarCombosBox();
           
        }
        private void refresh()
        {
            
            idMatricula = cn.verificar("Select idMatricula from matricula where usuario_idUsu ='"+txtcui.Text+"'");
            cn.consultar("SELECT idDetMat,horario_idHor FROM detallematricula where matricula_idMatricula = " + idMatricula , "detallematricula");
            datgrMatricula.DataSource = cn.ds.Tables["detallematricula"];
            datgrMatricula.Refresh();
        }
        private void cargarCombosBox()
        {
            
            String curso= (String)cmbCurso.SelectedValue;
            cn.llenarCombo(cmbGrupo, "idGrupo", "desGru", curso, "horario", "grupo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nomUsuario = cn.conTabla("Select nomApeUsu from usuario where idUsu = '"+txtcui.Text +"'");
            txtNombre.Text = nomUsuario;
            refresh();
        }
        private void cmbCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarCombosBox();
        }
        private void cmbGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            insertar();


        }
        private void insertar()
        {
            //Tenemos diferentes id para un solo horario entonces selecionamos el primer registro, el equivalente a Select TOP es:usaremos LIMIT 1
            int idHor = cn.verificar("Select idHor from horario where curso_idCurso="+cmbCurso.SelectedValue+" and grupo_idGrupo="+cmbGrupo.SelectedValue+" LIMIT 1");
            String sql = "INSERT INTO `laboratorioepis`.`detallematricula`(matricula_idMatricula,horario_idHor)VALUES("+idMatricula+","+idHor+")";
            
            if (cn.insertar(sql))
            {
                MessageBox.Show("insertado");
                refresh();
            }
            else
                MessageBox.Show("No insertado, Verfique los datos ingresados");
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idHor = cn.verificar("Select idHor from horario where curso_idCurso=" + cmbCurso.SelectedValue + " and grupo_idGrupo=" + cmbGrupo.SelectedValue + " LIMIT 1");
            String sql = "DELETE FROM `laboratorioepis`.`detallematricula` where idDetMat = "+ idDetMatricula;

            if (cn.insertar(sql))
            {
                MessageBox.Show("Eliminado");
                refresh();
            }
            else
                MessageBox.Show("No insertado, Verfique los datos ingresados");
        }

        private void datgrMatricula_Click(object sender, EventArgs e)
        {
            idDetMatricula = Convert.ToString(datgrMatricula.CurrentRow.Cells[0].Value);
            horario = Convert.ToString(datgrMatricula.CurrentRow.Cells[1].Value);

        }
    }
}
