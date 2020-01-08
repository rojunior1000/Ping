﻿namespace MonitoramentoIPs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvIPs
            // 
            this.lstvIPs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIPs,
            this.colStatus});
            this.lstvIPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvIPs.GridLines = true;
            this.lstvIPs.HideSelection = false;
            this.lstvIPs.Location = new System.Drawing.Point(0, 0);
            this.lstvIPs.Name = "lstvIPs";
            this.lstvIPs.Size = new System.Drawing.Size(923, 459);
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
            // panel1
            // 
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblTempo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 65);
            this.panel2.TabIndex = 2;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(12, 26);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(71, 13);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "Proximo Ping:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
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
            // 
            // button1
            // 
            this.button1.Image = global::MonitoramentoIPs.Properties.Resources.Iniciar32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(593, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Iniciar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTempo;
    }
}
