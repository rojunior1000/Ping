using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml;

namespace MonitoramentoIPs
{
    public class clsFunctions
    {

        public static string ArquivoConfigXML = "ConfigIPs.xml";

        #region "Insere valor no arquivo xml"
        public static void SetIni(string NameTag, string ValueTag, string FileXML, string TagMain)
        {
            DataSet dsSetIni = new DataSet();
            DataSet dsSetIniOut = new DataSet();
            DataTable dtSetIniOut = dsSetIniOut.Tables.Add(TagMain);

            try
            {
                dsSetIni.ReadXml(FileXML);
                dtSetIniOut = dsSetIni.Tables[TagMain];
                dtSetIniOut.Rows[0][NameTag] = ValueTag;
                dsSetIni.WriteXml(FileXML);
            }
            catch (FileNotFoundException)
            {
                XmlTextWriter newXml = new XmlTextWriter(FileXML, System.Text.Encoding.ASCII);

                newXml.WriteStartDocument();
                newXml.WriteStartElement(TagMain);
                newXml.WriteElementString(NameTag, ValueTag);
                newXml.WriteEndElement();
                newXml.WriteEndDocument();
                newXml.Flush();
                newXml.Close();
            }
            catch (Exception)
            {
                dtSetIniOut.Columns.Add(NameTag);
                dtSetIniOut.Rows[0][NameTag] = ValueTag;
                dtSetIniOut.DataSet.WriteXml(FileXML);
            }
        }
        #endregion

        #region "Pega o valor do xml"
        public static string GetIni(string TagName, string FileXML, string TagMain)
        {
            string result = string.Empty;

            if (File.Exists(FileXML))
            {
                try
                {
                    DataSet dsGetIni = new DataSet();
                    dsGetIni.ReadXml(FileXML);
                    DataTable dtGetIni = dsGetIni.Tables[TagMain];
                    result = dtGetIni.Rows[0][TagName].ToString();
                }
                catch (Exception)
                {
                }
            }
            return result;
        }
        #endregion

        #region "Pega o valor da Lista de IPs"
        public static List<string> GetIniList(string TagName, string FileXML, string TagMain)
        {
            List<string> result = new List<string>();

            if (File.Exists(FileXML))
            {
                try
                {
                    DataSet dsGetIni = new DataSet();
                    dsGetIni.ReadXml(FileXML);
                    DataTable dtGetIni = dsGetIni.Tables[TagMain];

                    for (int i = 0; i < dtGetIni.Columns.Count; i++)
                    {
                        if (dtGetIni.Columns[i].ColumnName.Contains("IPs"))
                        {
                            result.Add(dtGetIni.Rows[0][dtGetIni.Columns[i].ColumnName].ToString());
                        }
                    }

                }
                catch (Exception)
                {
                }
            }
            return result;
        }
        #endregion

        public static string Recupera_Xml(string strParametros, string strTagPrincipal)
        {
            string result = GetIni(strParametros, ArquivoConfigXML, strTagPrincipal);
            return result;
        }

        public static List<string> RecuperaList_Xml(string strParametros, string strTagPrincipal)
        {
            List<string> result = GetIniList(strParametros, ArquivoConfigXML, strTagPrincipal);
            return result;
        }

        public static void Salva_Xml(string campos, string strParametros, string strTagPrincipal)
        {
            SetIni(strParametros, campos, ArquivoConfigXML, strTagPrincipal);
        }

        public static bool EnviarEmail(string corpo)
        {
            bool result = false;
            string strSMTP = string.Empty;
            string strPorta = string.Empty;
            bool blnSSL = false;
            string strUsuario = string.Empty;
            string strSenha = string.Empty;
            string strEmailPara = string.Empty;
            bool blnMsgAviso = false;

            try
            {
                if (!string.IsNullOrEmpty(Recupera_Xml("SMTP", "ConfigPingIPs")))
                {
                    strSMTP = Recupera_Xml("SMTP", "ConfigPingIPs");
                    strPorta = Recupera_Xml("Porta", "ConfigPingIPs");
                    blnSSL = string.IsNullOrEmpty(Recupera_Xml("SSL", "ConfigPingIPs")) ? false : Convert.ToBoolean(Recupera_Xml("SSL", "ConfigPingIPs"));
                    strUsuario = Recupera_Xml("Usuario", "ConfigPingIPs");
                    strSenha = Recupera_Xml("Senha", "ConfigPingIPs");
                    strEmailPara = Recupera_Xml("EmailPara", "ConfigPingIPs");
                    blnMsgAviso = string.IsNullOrEmpty(Recupera_Xml("MsgAviso", "ConfigPingIPs")) ? false : Convert.ToBoolean(Recupera_Xml("MsgAviso", "ConfigPingIPs"));


                    //Cria os objetos para envio de mensagem
                    MailMessage msg = new MailMessage();
                    SmtpClient smtp = new SmtpClient(strSMTP);
                    smtp.Port = Convert.ToInt32(strPorta);
                    smtp.EnableSsl = blnSSL;
                    smtp.Credentials = new NetworkCredential(strUsuario, strSenha);

                    msg.From = new MailAddress(strUsuario);
                    msg.To.Add(new MailAddress(strEmailPara));
                    msg.Subject = "Erro de Monitoramento de Ping";
                    msg.IsBodyHtml = true;
                    msg.Body = corpo;

                    smtp.Send(msg);

                    smtp.Dispose();
                    msg.Dispose();

                    if (blnMsgAviso)
                        MessageBox.Show("E-Mail gerado e enviado para o destinatário com sucesso", "Messagem Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    result = true;

                }
            }
            catch (SmtpException eSmtp)
            {
                MessageBox.Show("Erro SMTP ao enviar e-mail" + Environment.NewLine + eSmtp.Message, "Erro Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro genérico ao enviar e-mail" + Environment.NewLine + ex.Message, "Erro Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public static void CursorEspera(Form f)
        {
            f.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
        }

        public static void CursorNormal(Form f)
        {
            f.Cursor = Cursors.Default;
            Application.DoEvents();
        }

        public static void AguardaFormMostra(string texto = "", int percentValue = 0, int maxValue = 100)
        {

            var FrmAberto = (FrmAguarda)Application.OpenForms["FrmAguarda"];

            if (FrmAberto == null)
            {
                FrmAguarda f = new FrmAguarda();
                if (percentValue < 0)
                {
                    percentValue = 0;
                }

                if (!f.Visible)
                    f.Show();

                if (!f.Focused)
                    f.Focus();

                if (!string.IsNullOrEmpty(texto))
                {
                    f.lblTexto.Text = texto;
                }

                f.progressBar.Maximum = maxValue + 1;

                if (percentValue != 0)
                {
                    f.progressBar.Value = percentValue;
                }

                f.pictureBox.Refresh();
            }
            else
            {
                FrmAberto.Focus();

                if (!string.IsNullOrEmpty(texto))
                {
                    FrmAberto.lblTexto.Text = texto;
                }

                if (percentValue != 0)
                {
                    FrmAberto.progressBar.Value = percentValue;
                }

                FrmAberto.pictureBox.Refresh();
            }

        }

        public static void AguardaFormFecha()
        {
            var f = Application.OpenForms["FrmAguarda"];
            if (f != null)
                f.Close();
        }


    }
}
