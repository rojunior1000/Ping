namespace MonitoramentoIPs
{
    partial class FrmConfigurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigurar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabIPs = new System.Windows.Forms.TabPage();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.MaskedTextBox();
            this.lstvDados = new System.Windows.Forms.ListView();
            this.colIPs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnroIPs = new System.Windows.Forms.TextBox();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkMensagemAviso = new System.Windows.Forms.CheckBox();
            this.txtEmailPara = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.optErro1 = new System.Windows.Forms.RadioButton();
            this.optErro = new System.Windows.Forms.RadioButton();
            this.txtporta = new System.Windows.Forms.MaskedTextBox();
            this.txtsenhaEmail = new System.Windows.Forms.TextBox();
            this.txtusuarioEmail = new System.Windows.Forms.TextBox();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.smtpSSL = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrava = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabIPs.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 385);
            this.panel1.TabIndex = 0;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabIPs);
            this.TabControl1.Controls.Add(this.tabEmail);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(800, 385);
            this.TabControl1.TabIndex = 0;
            // 
            // tabIPs
            // 
            this.tabIPs.BackColor = System.Drawing.SystemColors.Control;
            this.tabIPs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabIPs.Controls.Add(this.btnExclui);
            this.tabIPs.Controls.Add(this.btnAdiciona);
            this.tabIPs.Controls.Add(this.txtTempo);
            this.tabIPs.Controls.Add(this.lstvDados);
            this.tabIPs.Controls.Add(this.Label2);
            this.tabIPs.Controls.Add(this.Label1);
            this.tabIPs.Controls.Add(this.txtnroIPs);
            this.tabIPs.Location = new System.Drawing.Point(4, 22);
            this.tabIPs.Name = "tabIPs";
            this.tabIPs.Padding = new System.Windows.Forms.Padding(3);
            this.tabIPs.Size = new System.Drawing.Size(792, 359);
            this.tabIPs.TabIndex = 0;
            this.tabIPs.Text = "Config. IPs";
            // 
            // btnExclui
            // 
            this.btnExclui.Image = global::MonitoramentoIPs.Properties.Resources.minus_24;
            this.btnExclui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExclui.Location = new System.Drawing.Point(222, 65);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(89, 32);
            this.btnExclui.TabIndex = 3;
            this.btnExclui.Text = "&Exclui";
            this.btnExclui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Image = global::MonitoramentoIPs.Properties.Resources.add_2_24;
            this.btnAdiciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdiciona.Location = new System.Drawing.Point(127, 65);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(89, 32);
            this.btnAdiciona.TabIndex = 2;
            this.btnAdiciona.Text = "&Adcionar";
            this.btnAdiciona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(6, 147);
            this.txtTempo.Mask = "####";
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(305, 20);
            this.txtTempo.TabIndex = 5;
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstvDados
            // 
            this.lstvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIPs});
            this.lstvDados.FullRowSelect = true;
            this.lstvDados.GridLines = true;
            this.lstvDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvDados.HideSelection = false;
            this.lstvDados.Location = new System.Drawing.Point(317, 6);
            this.lstvDados.Name = "lstvDados";
            this.lstvDados.Size = new System.Drawing.Size(465, 343);
            this.lstvDados.TabIndex = 6;
            this.lstvDados.UseCompatibleStateImageBehavior = false;
            this.lstvDados.View = System.Windows.Forms.View.Details;
            // 
            // colIPs
            // 
            this.colIPs.Text = "IPs";
            this.colIPs.Width = 411;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 131);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(152, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Tempo para o Ping (segundos)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "IP para verificação";
            // 
            // txtnroIPs
            // 
            this.txtnroIPs.Location = new System.Drawing.Point(6, 39);
            this.txtnroIPs.Name = "txtnroIPs";
            this.txtnroIPs.Size = new System.Drawing.Size(305, 20);
            this.txtnroIPs.TabIndex = 1;
            this.txtnroIPs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnroIPs_KeyDown);
            // 
            // tabEmail
            // 
            this.tabEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tabEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabEmail.Controls.Add(this.checkBox1);
            this.tabEmail.Controls.Add(this.chkMensagemAviso);
            this.tabEmail.Controls.Add(this.txtEmailPara);
            this.tabEmail.Controls.Add(this.Label7);
            this.tabEmail.Controls.Add(this.optErro1);
            this.tabEmail.Controls.Add(this.optErro);
            this.tabEmail.Controls.Add(this.txtporta);
            this.tabEmail.Controls.Add(this.txtsenhaEmail);
            this.tabEmail.Controls.Add(this.txtusuarioEmail);
            this.tabEmail.Controls.Add(this.txtsmtp);
            this.tabEmail.Controls.Add(this.Label6);
            this.tabEmail.Controls.Add(this.Label5);
            this.tabEmail.Controls.Add(this.Label4);
            this.tabEmail.Controls.Add(this.Label3);
            this.tabEmail.Controls.Add(this.smtpSSL);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(792, 359);
            this.tabEmail.TabIndex = 1;
            this.tabEmail.Text = "Email";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(334, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Enviar Aviso Telegram";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkMensagemAviso
            // 
            this.chkMensagemAviso.AutoSize = true;
            this.chkMensagemAviso.Location = new System.Drawing.Point(118, 211);
            this.chkMensagemAviso.Name = "chkMensagemAviso";
            this.chkMensagemAviso.Size = new System.Drawing.Size(210, 17);
            this.chkMensagemAviso.TabIndex = 13;
            this.chkMensagemAviso.Text = "Mensagem de Aviso de E-mail Enviado";
            this.chkMensagemAviso.UseVisualStyleBackColor = true;
            // 
            // txtEmailPara
            // 
            this.txtEmailPara.Location = new System.Drawing.Point(118, 164);
            this.txtEmailPara.Name = "txtEmailPara";
            this.txtEmailPara.Size = new System.Drawing.Size(529, 20);
            this.txtEmailPara.TabIndex = 12;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(118, 148);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(91, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Encaminhar Para:";
            // 
            // optErro1
            // 
            this.optErro1.AutoSize = true;
            this.optErro1.Location = new System.Drawing.Point(275, 190);
            this.optErro1.Name = "optErro1";
            this.optErro1.Size = new System.Drawing.Size(194, 17);
            this.optErro1.TabIndex = 6;
            this.optErro1.TabStop = true;
            this.optErro1.Text = "Enviar em cada ciclo de verificação";
            this.optErro1.UseVisualStyleBackColor = true;
            // 
            // optErro
            // 
            this.optErro.AutoSize = true;
            this.optErro.Location = new System.Drawing.Point(118, 190);
            this.optErro.Name = "optErro";
            this.optErro.Size = new System.Drawing.Size(151, 17);
            this.optErro.TabIndex = 5;
            this.optErro.TabStop = true;
            this.optErro.Text = "Enviar quando houver erro";
            this.optErro.UseVisualStyleBackColor = true;
            // 
            // txtporta
            // 
            this.txtporta.Location = new System.Drawing.Point(493, 47);
            this.txtporta.Mask = "000";
            this.txtporta.Name = "txtporta";
            this.txtporta.Size = new System.Drawing.Size(57, 20);
            this.txtporta.TabIndex = 1;
            this.txtporta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsenhaEmail
            // 
            this.txtsenhaEmail.Location = new System.Drawing.Point(118, 125);
            this.txtsenhaEmail.Name = "txtsenhaEmail";
            this.txtsenhaEmail.PasswordChar = '*';
            this.txtsenhaEmail.Size = new System.Drawing.Size(529, 20);
            this.txtsenhaEmail.TabIndex = 4;
            // 
            // txtusuarioEmail
            // 
            this.txtusuarioEmail.Location = new System.Drawing.Point(118, 86);
            this.txtusuarioEmail.Name = "txtusuarioEmail";
            this.txtusuarioEmail.Size = new System.Drawing.Size(529, 20);
            this.txtusuarioEmail.TabIndex = 3;
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(118, 47);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(369, 20);
            this.txtsmtp.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(115, 109);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 13);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Senha";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(118, 70);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Usuário";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(490, 31);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Porta";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(115, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Servidor SMTP";
            // 
            // smtpSSL
            // 
            this.smtpSSL.AutoSize = true;
            this.smtpSSL.Location = new System.Drawing.Point(556, 49);
            this.smtpSSL.Name = "smtpSSL";
            this.smtpSSL.Size = new System.Drawing.Size(91, 17);
            this.smtpSSL.TabIndex = 2;
            this.smtpSSL.Text = "Conexão SSL";
            this.smtpSSL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGrava);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MonitoramentoIPs.Properties.Resources.Sair32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(718, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 53);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Saída";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrava
            // 
            this.btnGrava.Image = global::MonitoramentoIPs.Properties.Resources.Salvar32;
            this.btnGrava.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrava.Location = new System.Drawing.Point(643, 5);
            this.btnGrava.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(71, 53);
            this.btnGrava.TabIndex = 0;
            this.btnGrava.Text = "&Grava";
            this.btnGrava.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // FrmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfigurar_Load);
            this.panel1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.tabIPs.ResumeLayout(false);
            this.tabIPs.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tabIPs;
        internal System.Windows.Forms.MaskedTextBox txtTempo;
        internal System.Windows.Forms.ListView lstvDados;
        internal System.Windows.Forms.ColumnHeader colIPs;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtnroIPs;
        internal System.Windows.Forms.TabPage tabEmail;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.CheckBox chkMensagemAviso;
        internal System.Windows.Forms.TextBox txtEmailPara;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.RadioButton optErro1;
        internal System.Windows.Forms.RadioButton optErro;
        internal System.Windows.Forms.MaskedTextBox txtporta;
        internal System.Windows.Forms.TextBox txtsenhaEmail;
        internal System.Windows.Forms.TextBox txtusuarioEmail;
        internal System.Windows.Forms.TextBox txtsmtp;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox smtpSSL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnAdiciona;
    }
}