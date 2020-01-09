using System;
using System.Windows.Forms;

namespace MonitoramentoIPs
{
    public partial class FrmAguarda : Form
    {
        public FrmAguarda()
        {
            InitializeComponent();
        }

        private void FrmAguarda_Activated(object sender, EventArgs e)
        {
            this.pictureBox.Refresh();
            Application.DoEvents();
        }

        private void FrmAguarda_Load(object sender, EventArgs e)
        {
            clsFunctions.CursorEspera(new FrmPrincipal());
        }

        private void FrmAguarda_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsFunctions.CursorNormal(new FrmPrincipal());
        }
    }
}
