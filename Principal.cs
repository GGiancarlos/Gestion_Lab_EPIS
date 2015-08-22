using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoIS2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
           // new Conexion();
            time.Interval = 1000;
            time.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            Hide();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Horario_Click(object sender, EventArgs e)
        {
            openExcel(@"D:\Horario_2014-II.xlsx");
        }
        private void openExcel(String file)
        {
            ProcessStartInfo  info = new ProcessStartInfo();
            info.FileName = "EXCEL.EXE";
            info.Arguments = file;
            Process.Start(info);

        }

        private void time_Tick(object sender, EventArgs e)
        {
            //picIma.Image = Image.FromFile("");
            
        }

        
    }
}
