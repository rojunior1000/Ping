using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MonitoramentoIPs
{
    public partial class FrmConfigurar : Form
    {
        public FrmConfigurar()
        {
            InitializeComponent();
        }

        public bool blnOK = false;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfigurar_Load(object sender, EventArgs e)
        {
            CarregaCampos();
        }

        private void CarregaCampos()
        {
            List<string> strIPs = new List<string>();

            this.lstvDados.Items.Clear();
            this.lstvDados.BeginUpdate();

            strIPs = clsFunctions.RecuperaList_Xml("IPs", "ConfigPingIPs");
            foreach (var item in strIPs)
            {
                ListViewItem lst = this.lstvDados.Items.Add(item);
                lst.Tag = item;
            }

            this.lstvDados.EndUpdate();

            if (this.lstvDados.Items.Count != 0)
            {
                lstvDados.Items[0].Selected = true;
                lstvDados.Focus();
            }

            txtTempo.Text = clsFunctions.Recupera_Xml("TempoPing", "ConfigPingIPs");
            txtsmtp.Text = clsFunctions.Recupera_Xml("SMTP", "ConfigPingIPs");
            txtporta.Text = clsFunctions.Recupera_Xml("Porta", "ConfigPingIPs");
            smtpSSL.Checked = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("SSL", "ConfigPingIPs")) ? false : Convert.ToBoolean(clsFunctions.Recupera_Xml("SSL", "ConfigPingIPs"));
            txtusuarioEmail.Text = clsFunctions.Recupera_Xml("Usuario", "ConfigPingIPs");
            txtsenhaEmail.Text = clsFunctions.Recupera_Xml("Senha", "ConfigPingIPs");
            txtEmailPara.Text = clsFunctions.Recupera_Xml("EmailPara", "ConfigPingIPs");
            optErro.Checked = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("Enviar1", "ConfigPingIPs")) ? false : Convert.ToBoolean(clsFunctions.Recupera_Xml("Enviar1", "ConfigPingIPs"));
            optErro1.Checked = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("Enviar2", "ConfigPingIPs")) ? false : Convert.ToBoolean(clsFunctions.Recupera_Xml("Enviar2", "ConfigPingIPs"));
            chkMensagemAviso.Checked = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("MsgAviso", "ConfigPingIPs")) ? false : Convert.ToBoolean(clsFunctions.Recupera_Xml("MsgAviso", "ConfigPingIPs"));
            chkEnvioTelegram.Checked = string.IsNullOrEmpty(clsFunctions.Recupera_Xml("EnvioTelegram", "ConfigPingIPs")) ? false : Convert.ToBoolean(clsFunctions.Recupera_Xml("EnvioTelegram", "ConfigPingIPs"));

            if (optErro.Checked == false && optErro1.Checked == false)
                optErro.Checked = true;
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            if (!Valida_CamposIPs())
                return;

            this.lstvDados.BeginUpdate();

            ListViewItem i = this.lstvDados.Items.Add(txtnroIPs.Text);
            i.Tag = txtnroIPs.Text;

            this.lstvDados.EndUpdate();

            if (this.lstvDados.Items.Count != 0)
            {
                lstvDados.Items[0].Selected = true;
                lstvDados.Focus();
            }

            txtnroIPs.Text = string.Empty;
            txtnroIPs.Focus();
        }

        private bool Valida_CamposIPs()
        {
            bool result = false;

            if (txtnroIPs.Text.Length < 3)
            {
                MessageBox.Show("Por favor, adicione o numero do IP ou nome do host para verificação", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnroIPs.Focus();
                return result;
            }

            result = true;
            return result;
        }

        private bool ValidaCampos()
        {
            bool result = false;


            if (this.lstvDados.Items.Count == 0)
            {
                MessageBox.Show("Por favor, adicione o numero do IP ou nome do host para verificação", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnroIPs.Focus();
                return result;
            }

            if (string.IsNullOrEmpty(txtTempo.Text))
            {
                MessageBox.Show("Por favor, adicione o tempo de verificação do IPs", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTempo.Focus();
                return result;
            }

            if (!string.IsNullOrEmpty(txtsmtp.Text))
            {
                if (string.IsNullOrEmpty(txtporta.Text))
                {
                    MessageBox.Show("Por favor, adicione o porta do e-mail", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtporta.Focus();
                    return result;
                }

                if (string.IsNullOrEmpty(txtusuarioEmail.Text))
                {
                    MessageBox.Show("Por favor, adicione o usuário do e-mail", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusuarioEmail.Focus();
                    return result;
                }

                if (string.IsNullOrEmpty(txtsenhaEmail.Text))
                {
                    MessageBox.Show("Por favor, adicione a senha do e-mail", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsenhaEmail.Focus();
                    return result;
                }

                if (string.IsNullOrEmpty(txtEmailPara.Text))
                {
                    MessageBox.Show("Por favor, adicione o e-mail do Para", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailPara.Focus();
                    return result;
                }


                if (optErro.Checked == false && optErro1.Checked == false)
                {
                    MessageBox.Show("Por favor, selecione umas das opções para o tipo de envio", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    optErro.Focus();
                    return result;
                }

            }

            result = true;
            return result;
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (lstvDados.SelectedItems != null && lstvDados.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Deseja excluir o IP selecionado", "Messagem Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.lstvDados.Items.Remove(this.lstvDados.SelectedItems[0]);
                    this.lstvDados.Refresh();
                }
            }
        }

        private void txtnroIPs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdiciona_Click(sender, e);
            }
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {

            if (!ValidaCampos())
                return;

            int i = 1;

            if (File.Exists(clsFunctions.ArquivoConfigXML))
                File.Delete(clsFunctions.ArquivoConfigXML);

            foreach (ListViewItem item in this.lstvDados.Items)
            {
                clsFunctions.Salva_Xml(item.Text, "IPs" + i, "ConfigPingIPs");
                i++;
            }

            clsFunctions.Salva_Xml(txtTempo.Text, "TempoPing", "ConfigPingIPs");
            clsFunctions.Salva_Xml(optErro.Checked.ToString(), "Enviar1", "ConfigPingIPs");
            clsFunctions.Salva_Xml(optErro1.Checked.ToString(), "Enviar2", "ConfigPingIPs");
            clsFunctions.Salva_Xml(chkEnvioTelegram.Checked.ToString(), "EnvioTelegram", "ConfigPingIPs");

            if (!string.IsNullOrEmpty(txtsmtp.Text))
            {
                clsFunctions.Salva_Xml(txtsmtp.Text, "SMTP", "ConfigPingIPs");
                clsFunctions.Salva_Xml(txtporta.Text, "Porta", "ConfigPingIPs");
                clsFunctions.Salva_Xml(smtpSSL.Checked.ToString(), "SSL", "ConfigPingIPs");
                clsFunctions.Salva_Xml(txtusuarioEmail.Text, "Usuario", "ConfigPingIPs");
                clsFunctions.Salva_Xml(txtsenhaEmail.Text, "Senha", "ConfigPingIPs");
                clsFunctions.Salva_Xml(txtEmailPara.Text, "EmailPara", "ConfigPingIPs");
                clsFunctions.Salva_Xml(chkMensagemAviso.Checked.ToString(), "MsgAviso", "ConfigPingIPs");
            }

            blnOK = true;
            this.Close();
        }
    }
}
