using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
namespace ProyectoIS2
{
    public partial class ReportesUsuario : Form
    {
        public ReportesUsuario(String id , String nom, String correo)
        {
            InitializeComponent();
            txtId.Text = id;
            txtNombres.Text = nom;
            txtCorreo.Text = correo;
        }
        private MailMessage mail;
        private Attachment archivos;
        
        private void Reportes_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNombres.Enabled = false;
            txtCorreo.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String asunto = "Reporte";
            String mensaje = txtDes.Text;
            String from = txtCorreo.Text;
            String fromContrasenia = txtContrasenia.Text;
            MailMessage mail;

            mail = new MailMessage();
            mail.To.Add(new MailAddress("lizbethlima@gmail.com"));
            mail.From = new MailAddress(from);
            mail.Subject = asunto;
            mail.Body = mensaje;
            mail.IsBodyHtml = false;

            
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            using (cliente)
            {
                cliente.UseDefaultCredentials = false;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.Credentials = new System.Net.NetworkCredential(from, fromContrasenia);
                cliente.EnableSsl = true;
                try
                {
                    cliente.Send(mail);
                    String sql = "INSERT INTO `laboratorioepis`.`reporte`(`desRep`,`LABORATORIO_idLab`,`estRep`,`fecha`)VALUES('" + txtDes.Text + "',1,'Pendiente' , '11-4-2014')"; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                    
                
            }
            MessageBox.Show("mensaje enviado");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
       
    }
}
