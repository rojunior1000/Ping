using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace MonitoramentoIPs
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Int32 Tempo = 0;
        Int32 Tempo1 = 0;
        string TipoEnvio = string.Empty;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaConfig();
        }

        private void CarregaConfig()
        {

            string strIPs = string.Empty;

            this.lstvIPs.Items.Clear();
            this.lstvIPs.BeginUpdate();

            for (int i = 1; i <= 999; i++)
            {
                strIPs = clsFunctions.Recupera_Xml("IPs" + i, "ConfigPingIPs");
                if (!string.IsNullOrEmpty(strIPs))
                {
                    ListViewItem lst = this.lstvIPs.Items.Add(strIPs);
                    lst.SubItems.Add("Verificar");
                    lst.SubItems.Add(string.Empty);
                    lst.Tag = strIPs;
                }
            }

            Tempo = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs")) ? 0 : Convert.ToInt32(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs"));
            Tempo1 = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs")) ? 0 : Convert.ToInt32(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs"));

            if (!string.IsNullOrEmpty(clsFunctions.Recupera_Xml("Enviar1", "ConfigPingIPs")))
                TipoEnvio = Convert.ToBoolean(clsFunctions.Recupera_Xml("Enviar1", "ConfigPingIPs")) == true ? "1" : "2";

            this.lstvIPs.EndUpdate();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            using (FrmConfigurar f = new FrmConfigurar())
            {
                f.ShowDialog();
                if (f.blnOK)
                    CarregaConfig();
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja pausar a verificação automatica ?", "Messagem Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblproximo.Text = "Proximo Ping : " + (Tempo1 - 1).ToString();
            Tempo1 -= 1;
            if (Tempo1 == 0)
            {
                timer1.Enabled = false;
                Tempo1 = Tempo;
                ExecutarPing();
            }
        }

        private void ExecutarPing()
        {
            Ping pg = new Ping();
            string strIP = string.Empty;
            string strEmail = string.Empty;

            if (lstvIPs.Items.Count == 0)
            {
                MessageBox.Show("Por favor, adicione o numero do IP ou nome do host para verificação na tela de configuração", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsFunctions.CursorEspera(this);
            clsFunctions.AguardaFormMostra("Verificando IPs");

            for (int i = 0; i <= lstvIPs.Items.Count - 1; i++)
            {
                try
                {
                    strIP = lstvIPs.Items[i].Text;
                    var status = pg.Send(strIP, 5000);

                    clsFunctions.AguardaFormMostra("Ping...." + strIP);

                    if (status.Status == IPStatus.Success)
                    {
                        lstvIPs.Items[i].SubItems[1].Text = status.Status.ToString();
                        lstvIPs.Items[i].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        lstvIPs.Items[i].SubItems[1].Text = status.Status.ToString();
                        lstvIPs.Items[i].BackColor = Color.Red;
                        strEmail = "---------------" + DateTime.Now + "---------------" + Environment.NewLine + "[" + strIP + "] Erro: " + status.Status.ToString() + " " + status.Status;

                        if (string.IsNullOrEmpty(TipoEnvio) || TipoEnvio == "1")
                        {
                            if (string.IsNullOrEmpty(lstvIPs.Items[i].SubItems[2].Text))
                                clsFunctions.AguardaFormMostra("Enviando Email Erro");

                            lstvIPs.Items[i].SubItems[2].Text = "EmailEnviado";
                        }
                        else
                            clsFunctions.AguardaFormMostra("Enviando Email Erro");
                    }
                }
                catch (PingException ex)
                {
                    lstvIPs.Items[i].SubItems[1].Text = ex.Message;
                    lstvIPs.Items[i].BackColor = Color.Red;
                    strEmail = "---------------" + DateTime.Now + "---------------" + Environment.NewLine + "[" + strIP + "] Erro: " + ex.InnerException.Message;
                }
            }

            clsFunctions.AguardaFormFecha();
            clsFunctions.CursorNormal(this);
            lstvIPs.Refresh();
            timer1.Enabled = true;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ExecutarPing();
        }
    }
}
