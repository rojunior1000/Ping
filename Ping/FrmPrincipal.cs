using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace MonitoramentoIPs
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Int64 Tempo = 0;
        Int64 Tempo1 = 0;
        string TipoEnvio = string.Empty;

        private void ExecutarPing()
        {
            Ping pg = new Ping();
            
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
