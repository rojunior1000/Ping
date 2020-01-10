using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        bool TelegramEnvio = false;
        bool EmailEnvio = false;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaConfig();
        }

        private void CarregaConfig()
        {
            string strTextoEnvio = string.Empty;

            lblConfiguracaoTexto.Text = "Sem Parametrização";

            if (!File.Exists(clsFunctions.ArquivoConfigXML))
                return;

            List<string> strIPs = new List<string>();

            this.lstvIPs.Items.Clear();
            this.lstvIPs.BeginUpdate();

            strIPs = clsFunctions.RecuperaList_Xml("IPs", "ConfigPingIPs");
            foreach (var item in strIPs)
            {
                ListViewItem lst = this.lstvIPs.Items.Add(item);
                lst.SubItems.Add("Verificar");
                lst.SubItems.Add(string.Empty);
                lst.Tag = item;
            }

            this.lstvIPs.EndUpdate();

            Tempo = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs")) ? 0 : Convert.ToInt32(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs"));
            Tempo1 = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs")) ? 0 : Convert.ToInt32(clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs"));

            if (!string.IsNullOrEmpty(clsFunctions.Recupera_Xml("Enviar1", "ConfigPingIPs")))
                TipoEnvio = Convert.ToBoolean(clsFunctions.Recupera_Xml("Enviar1", "ConfigPingIPs")) == true ? "1" : "2";

            TelegramEnvio = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("EnvioTelegram", "ConfigPingIPs")) ? false : Convert.ToBoolean(clsFunctions.Recupera_Xml("EnvioTelegram", "ConfigPingIPs"));
            EmailEnvio = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("SMTP", "ConfigPingIPs")) ? false : true;

            lblConfiguracaoTexto.Text = "Nros de IPs para verificar " + strIPs.Count.ToString() + " - Tempo de ciclo de verificação dos IPs " + Tempo.ToString() + " segundos" + Environment.NewLine;

            if (TelegramEnvio && EmailEnvio)
                strTextoEnvio = "E-mail e Telegram";
            else if (EmailEnvio)
                strTextoEnvio = "E-mail";
            else if (TelegramEnvio)
                strTextoEnvio = "Telegram";

            lblConfiguracaoTexto.Text += TipoEnvio == "1" ? "Enviar " + strTextoEnvio + " quando houver erro" : "Enviar " + strTextoEnvio + " em cada ciclo de verificação";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            using (FrmConfigurar f = new FrmConfigurar())
            {
                timer1.Enabled = false;
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

            foreach (ListViewItem item in lstvIPs.Items)
            {
                try
                {
                    strIP = item.Text;
                    var status = pg.Send(strIP, 5000);

                    clsFunctions.AguardaFormMostra("Ping...." + strIP);

                    if (status.Status == IPStatus.Success)
                    {
                        item.SubItems[1].Text = status.Status.ToString();
                        item.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        item.SubItems[1].Text = status.Status.ToString();
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                        strEmail = "---------------" + DateTime.Now + "---------------" + Environment.NewLine + "[" + strIP + "] Erro: " + status.Status.ToString() + " " + status.Status;

                        EnviaEmail(strEmail, TipoEnvio, item.SubItems[2].Text);
                        EnviaTelegram(strEmail, item.SubItems[2].Text);
                        item.SubItems[2].Text = "Enviado";
                    }
                }
                catch (PingException ex)
                {
                    item.SubItems[1].Text = ex.Message;
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                    strEmail = "---------------" + DateTime.Now + "---------------" + Environment.NewLine + "[" + strIP + "] Erro: " + ex.InnerException.Message;

                    EnviaEmail(strEmail, TipoEnvio, item.SubItems[2].Text);
                    EnviaTelegram(strEmail, item.SubItems[2].Text);
                    item.SubItems[2].Text = "Enviado";
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

        private void EnviaEmail(string corpo, string TipoEnvio, string StatusEnvioIP)
        {

            if (TipoEnvio == "1") //Envia apenas uma vez
            {
                if (string.IsNullOrEmpty(StatusEnvioIP))
                {
                    clsFunctions.AguardaFormMostra("Enviando Email Erro");
                    clsFunctions.EnviarEmail(corpo);
                }
            }
            else if (TipoEnvio == "2") //Envia em cada ciclo de verificação mesmo se já estiver enviado
            {
                clsFunctions.AguardaFormMostra("Enviando Email Erro");
                clsFunctions.EnviarEmail(corpo);
            }

        }

        private void EnviaTelegram(string corpo, string StatusEnvioIP)
        {
            clsTelegram telegram = new clsTelegram();

            if (TelegramEnvio)
            {
                if (TipoEnvio == "1") //Envia apenas uma vez
                {
                    if (string.IsNullOrEmpty(StatusEnvioIP))
                    {
                        clsFunctions.AguardaFormMostra("Enviando Telegram Erro");
                        if (telegram.verificarAcessoInternet())
                        {
                            telegram.Bot_SendMessage(corpo);
                        }
                    }
                }
                else if (TipoEnvio == "2") //Envia em cada ciclo de verificação mesmo se já estiver enviado
                {
                    clsFunctions.AguardaFormMostra("Enviando Telegram Erro");
                    if (telegram.verificarAcessoInternet())
                    {
                        telegram.Bot_SendMessage(corpo);
                    }
                }
            }

        }

    }
}
