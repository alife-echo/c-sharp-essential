namespace alife_tb_sd_f
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelMenu.Controls.Add(this.btnDownload);
            this.panelMenu.Controls.Add(this.btnInterest);
            this.panelMenu.Controls.Add(this.btnQuery);
            this.panelMenu.Controls.Add(this.btnUpload);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(278, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(278, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(50)))), ((int)(((byte)(159)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpload.Location = new System.Drawing.Point(0, 76);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUpload.Size = new System.Drawing.Size(278, 61);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(50)))), ((int)(((byte)(159)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuery.Location = new System.Drawing.Point(0, 137);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnQuery.Size = new System.Drawing.Size(278, 61);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "QUERY";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnInterest
            // 
            this.btnInterest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInterest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(50)))), ((int)(((byte)(159)))));
            this.btnInterest.FlatAppearance.BorderSize = 0;
            this.btnInterest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterest.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInterest.Location = new System.Drawing.Point(0, 198);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInterest.Size = new System.Drawing.Size(278, 61);
            this.btnInterest.TabIndex = 2;
            this.btnInterest.Text = "INTEREST";
            this.btnInterest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterest.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(50)))), ((int)(((byte)(159)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDownload.Location = new System.Drawing.Point(0, 259);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDownload.Size = new System.Drawing.Size(278, 61);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button btnQuery;
    }
}

