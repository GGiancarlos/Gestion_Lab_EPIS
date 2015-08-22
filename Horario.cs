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
    public partial class Horario : Form
    {
        public Horario()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();

        int lunes = 0;
        int martes = 0;
        int miercoles = 0;
        int jueves = 0;
        int viernes = 0;
        int contador = 0;
        String boton = "";

        private void Horario_Load(object sender, EventArgs e)
        {
            cn.llenarCombo(cmbLab, "idLab", "desLab", "laboratorio");
            cn.llenarCombo(cmbCurso,"idCurso","desCurso","curso");
            cn.llenarCombo(cmbGrupo,"idGrupo","desGru","grupo");
            
            refresh();
        }
        private void refresh()
        {
            cn.consultar("SELECT curso_idCurso,grupo_idGrupo,diaHor,iniHor,finHor FROM horario where laboratorio_idLab = '" + cmbLab.SelectedValue + "'", "horario");
            datgrHorario.DataSource = cn.ds.Tables["horario"];
            datgrHorario.Refresh();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            boton = "insertar"; 
        }
        private void insertar()
        {
            if (checkLunes.Checked == true)
            {
                String sql = "INSERT INTO `laboratorioepis`.`horario`(curso_idCurso,grupo_idGrupo,laboratorio_idLab,diaHor,iniHor,finHor)VALUES('"+cmbCurso.SelectedValue+"','"+cmbGrupo.SelectedValue+"','"+cmbLab.SelectedValue+ "',Lunes,'"+txtLunIni.Text+"','"+txtLunFin.Text+"')";
                if (cn.insertar(sql))
                {
                    refresh();
                }
                else
                    MessageBox.Show("No insertado, Verfique los datos ingresados");
            }
            if (checkMartes.Checked == true)
            {
                String sql = "INSERT INTO `laboratorioepis`.`horario`(curso_idCurso,grupo_idGrupo,laboratorio_idLab,diaHor,iniHor,finHor)VALUES('" + cmbCurso.SelectedValue + "','" + cmbGrupo.SelectedValue + "','" + cmbLab.SelectedValue + "',Martes,'" + txtMarIni.Text + "','" + txtMarFin.Text + "')";
                if (cn.insertar(sql))
                {
                    refresh();
                }
                else
                    MessageBox.Show("No insertado, Verfique los datos ingresados");
            }
            if (checkMiercoles.Checked == true)
            {
                String sql = "INSERT INTO `laboratorioepis`.`horario`(curso_idCurso,grupo_idGrupo,laboratorio_idLab,diaHor,iniHor,finHor)VALUES('" + cmbCurso.SelectedValue + "','" + cmbGrupo.SelectedValue + "','" + cmbLab.SelectedValue + "',Miercoles,'" + txtMieIni.Text + "','" + txtMieFin.Text + "')";
                if (cn.insertar(sql))
                {
                    refresh();
                }
                else
                    MessageBox.Show("No insertado, Verfique los datos ingresados");
            }
            if (checkJueves.Checked == true)
            {
                String sql = "INSERT INTO `laboratorioepis`.`horario`(curso_idCurso,grupo_idGrupo,laboratorio_idLab,diaHor,iniHor,finHor)VALUES('" + cmbCurso.SelectedValue + "','" + cmbGrupo.SelectedValue + "','" + cmbLab.SelectedValue + "',Jueves,'" + txtJueIni.Text + "','" + txtJueFin.Text + "')";
                if (cn.insertar(sql))
                {
                    refresh();
                }
                else
                    MessageBox.Show("No insertado, Verfique los datos ingresados");
            }
            if (checkViernes.Checked == true)
            {
                String sql = "INSERT INTO `laboratorioepis`.`horario`(curso_idCurso,grupo_idGrupo,laboratorio_idLab,diaHor,iniHor,finHor)VALUES('" + cmbCurso.SelectedValue + "','" + cmbGrupo.SelectedValue + "','" + cmbLab.SelectedValue + "',Viernes,'" + txtVieIni.Text + "','" + txtVieFin.Text + "')";
                if (cn.insertar(sql))
                {
                    refresh();
                }
                else
                    MessageBox.Show("No insertado, Verfique los datos ingresados");
            }
            
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

            
            refresh();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //if (txtCodSoft.Text != "")
            
                
                boton = "modificar";
            
            //else
               // MessageBox.Show("Seleccione que registro desea modificar");
        }

        private void modificar()
        {
            /*String sql = "UPDATE `laboratorioepis`.`software` set  desEqu ='" + txtDescripcion.Text + "' where idSoft='" + txtCodSoft.Text + "'";

            MessageBox.Show(sql);
            if (cn.modificar(sql))
            {

                MessageBox.Show("Modificado");
            }
            else
                MessageBox.Show("no modificado");
            refresh();*/
        }

        private void cmbLab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh();
        }
        private void cmbcurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh();
        }

        private void cmbGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh();
        }

       

        
    }
}
