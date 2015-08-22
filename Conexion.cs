using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoIS2
{
    class Conexion
    {

        private string connectionString = "Server=localhost;Port=3306;Database=laboratorioepis;Uid=root; Password=Madness_123";
        public MySqlConnection conexion;
        public MySqlCommand comando; 
        public DataSet ds;
        public MySqlDataAdapter da;
        private MySqlCommandBuilder cmd;
        
 

       // MySqlConnection cn = new MySqlConnection("Server=localhost;Database=laboratorioepis;Uid=root; Password=root");
        //MySqlCommand cmd = new MySqlCommand();

        private void conectar()
        {
            try
            {
                conexion = new MySqlConnection(connectionString);
                //MessageBox.Show("La conexion se ha realizado", "Exito");

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error", "ERROR");
            }
        }

        public Conexion()
        {
            conectar();
        }

        /*
         *Metodos quee nos devuleves el conteo de una seleccion para login usuario
         *Tambien nos retornara el id de una matricula
         */
        public int verificar(String sql)
        {
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(); ;
            comando.Connection = conexion;
            try
            {
                comando.CommandText = sql;
                int valor = int.Parse(comando.ExecuteScalar().ToString());
                if (true)
                {
                    return valor;
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            conexion.Close();
           return -1;
        }

        //Verificar tipo
        public int verTipo(String sql)
        {
            conexion.Close();
            conexion.Open();
            comando.CommandText = sql;
            int valor = int.Parse(comando.ExecuteScalar().ToString());
            conexion.Close();
            return valor;
 
        }
        public String conTabla(String sql)
        {
            conexion.Close();
            conexion.Open();
            comando.CommandText = sql;
            String valor = comando.ExecuteScalar().ToString();
            conexion.Close();
            return valor;

        }
        //Insertar usuario(verificar si se usa tambien en administrador)
        public bool insertar(String sql)
        {
            int retorno = 0;
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(); ;
            comando.Connection = conexion;
            try
            {
                comando.CommandText = sql;
                retorno = comando.ExecuteNonQuery();
                if (retorno == 1)
                {
                    conexion.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Error");
                    conexion.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                return false;
            }

        }

        //Consultar
        public bool modificar(String sql)
        {
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sql, conexion);
            int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool eliminar(string sql)
        {
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sql, conexion);
            int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
                return true;
            else
                return false;
        }
        public void consultar(string sql, string tabla)
        {
            ds = new DataSet();
            da = new MySqlDataAdapter();
            ds.Tables.Clear();
            da = new MySqlDataAdapter(sql, conexion);
            cmd = new MySqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        //consultar 2
        public DataTable cosultar2(string tabla)
        {
            string sql = "select * from" + tabla;
            da = new MySqlDataAdapter(sql, conexion);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }

        public void llenarCombo(ComboBox cmb,String idcampo,String campo, String tabla)
        {
            try
            {
                ds = new DataSet();
                da = new MySqlDataAdapter();
                String sql = "select "+idcampo +","+ campo +" from "+ tabla;
                conexion.Close();
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                da.SelectCommand = comando;
                da.Fill(ds);
                da.Dispose();
                comando.Dispose();
                conexion.Close();
                cmb.DataSource = ds.Tables[0];
                cmb.ValueMember = idcampo;
                cmb.DisplayMember = campo;
            }
            catch(Exception e)
            {
                MessageBox.Show("No se encontro datos"+e.ToString());
            }
        }

        public void llenarCombo(ComboBox cmb, String idcampo, String campo, String tabla,String estado)
        {
            try
            {
                conexion.Close();
                ds = new DataSet();
                da = new MySqlDataAdapter();
                String sql = "select " + idcampo + "," + campo + " from " + tabla+ " where estado='"+estado+"'";
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                da.SelectCommand = comando;
                da.Fill(ds);
                da.Dispose();
                comando.Dispose();
                conexion.Close();
                cmb.DataSource = ds.Tables[0];
                cmb.ValueMember = idcampo;
                cmb.DisplayMember = idcampo;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro datos" + e.ToString());
            }
        }

        public void llenarCombo(ComboBox cmb, String idcampo, String campo,String campoiden, String tablaHor,String tablaGrup)
        {
            try
            {
                conexion.Close();
                ds = new DataSet();
                da = new MySqlDataAdapter();
                String sql = "Select distinct "+idcampo+","+campo+" from laboratorioepis."+tablaGrup+",laboratorioepis."+tablaHor+" where laboratorioepis."+tablaGrup+".idGrupo="+ campoiden;
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                da.SelectCommand = comando;
                da.Fill(ds);
                da.Dispose();
                comando.Dispose();
                conexion.Close();
                cmb.DataSource = ds.Tables[0];
                cmb.ValueMember = idcampo;
                cmb.DisplayMember = campo;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro datos" + e.ToString());
            }
        }
        

   
    }
}
