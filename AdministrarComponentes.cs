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
    public partial class AdministrarComponentes : Form
    {
        public AdministrarComponentes()
        {
            InitializeComponent();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            Monitor formMonitor = new Monitor();
            formMonitor.Show();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            Cpu formCpu = new Cpu();
            formCpu.Show();
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            Mouse formMouse = new Mouse();
            formMouse.Show();
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            Teclado formTeclado = new Teclado();
            formTeclado.Show();
        }
    }
}
