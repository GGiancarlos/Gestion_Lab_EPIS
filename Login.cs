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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
       Conexion cn = new Conexion();
       Principal formPri;

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            String cod = txt_usuario.Text;
            String contrasenia = txt_contraseña.Text;

            String sql = "select count(*) from usuario where idUSu='" + cod + "' and conUsu='" + contrasenia + "'";
            int valor = cn.verificar(sql);

            String sqlTipo = "select TIPO_idTipo from usuario where idUSu='" + cod + "' and conUsu='" + contrasenia + "'";
            int valorTipo = cn.verTipo(sqlTipo);
            

            if (valor == 1 && valorTipo == 1)
            {
                Administrador formAdministrador = new Administrador();
                formAdministrador.Show();
                Hide();
                
            }

            if (valor == 1 && valorTipo == 3)
            {
                String sqlCorreo = "select corrUsu from usuario where idUSu='" + cod + "'";
                String correo = cn.conTabla(sqlCorreo);

                String sqlNombre = "select nomapeUsu from usuario where idUSu='" + cod + "'";
                String nombre = cn.conTabla(sqlNombre);

                Usuario formAlum = new Usuario(cod,nombre,correo);
                formAlum.Show();
                Hide();
            }
                
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPri = new Principal();
            formPri.Show();
            Hide();
        }     
       
    }
}
