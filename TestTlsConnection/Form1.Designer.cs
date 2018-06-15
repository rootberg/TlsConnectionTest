namespace TestTlsConnection
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TextUrl = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblErrMsg = new System.Windows.Forms.Label();
            this.TxtError = new System.Windows.Forms.TextBox();
            this.TxtRemoteCertificate = new System.Windows.Forms.TextBox();
            this.TxtHashAlgorithm = new System.Windows.Forms.TextBox();
            this.TxtCipherAlgorithm = new System.Windows.Forms.TextBox();
            this.TxtProtocolVersion = new System.Windows.Forms.TextBox();
            this.TxtScannedSite = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Url to check:";
            // 
            // TextUrl
            // 
            this.TextUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextUrl.Location = new System.Drawing.Point(115, 10);
            this.TextUrl.Name = "TextUrl";
            this.TextUrl.Size = new System.Drawing.Size(511, 20);
            this.TextUrl.TabIndex = 1;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.BackColor = System.Drawing.Color.Green;
            this.BtnExecute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExecute.Location = new System.Drawing.Point(632, 8);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 2;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = false;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.Color.Yellow;
            this.BtnClear.Location = new System.Drawing.Point(713, 8);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Protocol Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scanned Site:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cipher Algorithm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hash Algorithm:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblErrMsg);
            this.panel1.Controls.Add(this.TxtError);
            this.panel1.Controls.Add(this.TxtRemoteCertificate);
            this.panel1.Controls.Add(this.TxtHashAlgorithm);
            this.panel1.Controls.Add(this.TxtCipherAlgorithm);
            this.panel1.Controls.Add(this.TxtProtocolVersion);
            this.panel1.Controls.Add(this.TxtScannedSite);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 230);
            this.panel1.TabIndex = 8;
            // 
            // LblErrMsg
            // 
            this.LblErrMsg.AutoSize = true;
            this.LblErrMsg.Location = new System.Drawing.Point(6, 142);
            this.LblErrMsg.Name = "LblErrMsg";
            this.LblErrMsg.Size = new System.Drawing.Size(78, 13);
            this.LblErrMsg.TabIndex = 20;
            this.LblErrMsg.Text = "Error Message:";
            // 
            // TxtError
            // 
            this.TxtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtError.Location = new System.Drawing.Point(106, 142);
            this.TxtError.MinimumSize = new System.Drawing.Size(4, 53);
            this.TxtError.Multiline = true;
            this.TxtError.Name = "TxtError";
            this.TxtError.ReadOnly = true;
            this.TxtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtError.Size = new System.Drawing.Size(649, 53);
            this.TxtError.TabIndex = 19;
            // 
            // TxtRemoteCertificate
            // 
            this.TxtRemoteCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRemoteCertificate.Location = new System.Drawing.Point(106, 89);
            this.TxtRemoteCertificate.MinimumSize = new System.Drawing.Size(4, 53);
            this.TxtRemoteCertificate.Multiline = true;
            this.TxtRemoteCertificate.Name = "TxtRemoteCertificate";
            this.TxtRemoteCertificate.ReadOnly = true;
            this.TxtRemoteCertificate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtRemoteCertificate.Size = new System.Drawing.Size(649, 53);
            this.TxtRemoteCertificate.TabIndex = 18;
            // 
            // TxtHashAlgorithm
            // 
            this.TxtHashAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHashAlgorithm.Location = new System.Drawing.Point(106, 69);
            this.TxtHashAlgorithm.Name = "TxtHashAlgorithm";
            this.TxtHashAlgorithm.ReadOnly = true;
            this.TxtHashAlgorithm.Size = new System.Drawing.Size(649, 20);
            this.TxtHashAlgorithm.TabIndex = 17;
            // 
            // TxtCipherAlgorithm
            // 
            this.TxtCipherAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCipherAlgorithm.Location = new System.Drawing.Point(106, 49);
            this.TxtCipherAlgorithm.Name = "TxtCipherAlgorithm";
            this.TxtCipherAlgorithm.ReadOnly = true;
            this.TxtCipherAlgorithm.Size = new System.Drawing.Size(649, 20);
            this.TxtCipherAlgorithm.TabIndex = 16;
            // 
            // TxtProtocolVersion
            // 
            this.TxtProtocolVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProtocolVersion.Location = new System.Drawing.Point(106, 29);
            this.TxtProtocolVersion.Name = "TxtProtocolVersion";
            this.TxtProtocolVersion.ReadOnly = true;
            this.TxtProtocolVersion.Size = new System.Drawing.Size(649, 20);
            this.TxtProtocolVersion.TabIndex = 15;
            // 
            // TxtScannedSite
            // 
            this.TxtScannedSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtScannedSite.Location = new System.Drawing.Point(106, 9);
            this.TxtScannedSite.Name = "TxtScannedSite";
            this.TxtScannedSite.ReadOnly = true;
            this.TxtScannedSite.Size = new System.Drawing.Size(649, 20);
            this.TxtScannedSite.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Remote Certificate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TextUrl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Test TLS Connection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextUrl;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtScannedSite;
        private System.Windows.Forms.TextBox TxtProtocolVersion;
        private System.Windows.Forms.TextBox TxtCipherAlgorithm;
        private System.Windows.Forms.TextBox TxtHashAlgorithm;
        private System.Windows.Forms.TextBox TxtRemoteCertificate;
        private System.Windows.Forms.Label LblErrMsg;
        private System.Windows.Forms.TextBox TxtError;
    }
}

