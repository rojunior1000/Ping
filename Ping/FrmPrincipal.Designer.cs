namespace MonitoramentoIPs
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lstvIPs = new System.Windows.Forms.ListView();
            this.colIPs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnviado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblproximo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblConfiguracao = new System.Windows.Forms.Label();
            this.lblConfiguracaoTexto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvIPs
            // 
            this.lstvIPs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvIPs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIPs,
            this.colStatus,
            this.colEnviado});
            this.lstvIPs.GridLines = true;
            this.lstvIPs.HideSelection = false;
            this.lstvIPs.Location = new System.Drawing.Point(0, 61);
            this.lstvIPs.Name = "lstvIPs";
            this.lstvIPs.Size = new System.Drawing.Size(923, 398);
            this.lstvIPs.TabIndex = 0;
            this.lstvIPs.UseCompatibleStateImageBehavior = false;
            this.lstvIPs.View = System.Windows.Forms.View.Details;
            // 
            // colIPs
            // 
            this.colIPs.Text = "IPs";
            this.colIPs.Width = 204;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status IPs";
            this.colStatus.Width = 297;
            // 
            // colEnviado
            // 
            this.colEnviado.Text = "Status Envio";
            this.colEnviado.Width = 259;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConfiguracaoTexto);
            this.panel1.Controls.Add(this.lblConfiguracao);
            this.panel1.Controls.Add(this.lstvIPs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 459);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.btnConfigurar);
            this.panel2.Controls.Add(this.btnPausar);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Controls.Add(this.lblproximo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 65);
            this.panel2.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::MonitoramentoIPs.Properties.Resources.Sair32;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(836, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 52);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = global::MonitoramentoIPs.Properties.Resources.Configurar32;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfigurar.Location = new System.Drawing.Point(755, 6);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 52);
            this.btnConfigurar.TabIndex = 3;
            this.btnConfigurar.Text = "&Configurar";
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Image = global::MonitoramentoIPs.Properties.Resources.Pausar32;
            this.btnPausar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPausar.Location = new System.Drawing.Point(674, 6);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 52);
            this.btnPausar.TabIndex = 2;
            this.btnPausar.Text = "&Pausar";
            this.btnPausar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = global::MonitoramentoIPs.Properties.Resources.Iniciar32;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.Location = new System.Drawing.Point(593, 6);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 52);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblproximo
            // 
            this.lblproximo.AutoSize = true;
            this.lblproximo.Location = new System.Drawing.Point(12, 26);
            this.lblproximo.Name = "lblproximo";
            this.lblproximo.Size = new System.Drawing.Size(71, 13);
            this.lblproximo.TabIndex = 0;
            this.lblproximo.Text = "Proximo Ping:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblConfiguracao
            // 
            this.lblConfiguracao.AutoSize = true;
            this.lblConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracao.Location = new System.Drawing.Point(12, 9);
            this.lblConfiguracao.Name = "lblConfiguracao";
            this.lblConfiguracao.Size = new System.Drawing.Size(209, 16);
            this.lblConfiguracao.TabIndex = 1;
            this.lblConfiguracao.Text = "Configuração Parametrizada:";
            // 
            // lblConfiguracaoTexto
            // 
            this.lblConfiguracaoTexto.AutoSize = true;
            this.lblConfiguracaoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracaoTexto.Location = new System.Drawing.Point(220, 9);
            this.lblConfiguracaoTexto.Name = "lblConfiguracaoTexto";
            this.lblConfiguracaoTexto.Size = new System.Drawing.Size(0, 16);
            this.lblConfiguracaoTexto.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento de IPs";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lstvIPs;
        private System.Windows.Forms.ColumnHeader colIPs;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblproximo;
        private System.Windows.Forms.ColumnHeader colEnviado;
        private System.Windows.Forms.Label lblConfiguracao;
        private System.Windows.Forms.Label lblConfiguracaoTexto;
    }
}

