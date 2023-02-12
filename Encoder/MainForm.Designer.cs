namespace Encoder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabEncodeType = new System.Windows.Forms.TabControl();
            this.tbpRSA = new System.Windows.Forms.TabPage();
            this.btnCreateKeys = new System.Windows.Forms.Button();
            this.lblRSAKey = new System.Windows.Forms.Label();
            this.txtRSAKey = new System.Windows.Forms.TextBox();
            this.btnRSAEncryptOrDecrypt = new System.Windows.Forms.Button();
            this.txtRSATargetText = new System.Windows.Forms.TextBox();
            this.lblRSATargetText = new System.Windows.Forms.Label();
            this.lblRSASourceText = new System.Windows.Forms.Label();
            this.txtRSASourceText = new System.Windows.Forms.TextBox();
            this.rdbRSADecrypt = new System.Windows.Forms.RadioButton();
            this.rdbRSAEncrypt = new System.Windows.Forms.RadioButton();
            this.pnlFull = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabEncodeType.SuspendLayout();
            this.tbpRSA.SuspendLayout();
            this.pnlFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEncodeType
            // 
            this.tabEncodeType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEncodeType.Controls.Add(this.tbpRSA);
            this.tabEncodeType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabEncodeType.Location = new System.Drawing.Point(3, 3);
            this.tabEncodeType.Name = "tabEncodeType";
            this.tabEncodeType.SelectedIndex = 0;
            this.tabEncodeType.Size = new System.Drawing.Size(509, 368);
            this.tabEncodeType.TabIndex = 0;
            // 
            // tbpRSA
            // 
            this.tbpRSA.Controls.Add(this.button1);
            this.tbpRSA.Controls.Add(this.btnCreateKeys);
            this.tbpRSA.Controls.Add(this.lblRSAKey);
            this.tbpRSA.Controls.Add(this.txtRSAKey);
            this.tbpRSA.Controls.Add(this.btnRSAEncryptOrDecrypt);
            this.tbpRSA.Controls.Add(this.txtRSATargetText);
            this.tbpRSA.Controls.Add(this.lblRSATargetText);
            this.tbpRSA.Controls.Add(this.lblRSASourceText);
            this.tbpRSA.Controls.Add(this.txtRSASourceText);
            this.tbpRSA.Controls.Add(this.rdbRSADecrypt);
            this.tbpRSA.Controls.Add(this.rdbRSAEncrypt);
            this.tbpRSA.Location = new System.Drawing.Point(4, 26);
            this.tbpRSA.Name = "tbpRSA";
            this.tbpRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRSA.Size = new System.Drawing.Size(501, 338);
            this.tbpRSA.TabIndex = 2;
            this.tbpRSA.Text = "RSA 加密 & 解密";
            this.tbpRSA.UseVisualStyleBackColor = true;
            this.tbpRSA.Click += new System.EventHandler(this.tbpRSA_Click);
            // 
            // btnCreateKeys
            // 
            this.btnCreateKeys.Location = new System.Drawing.Point(0, 313);
            this.btnCreateKeys.Name = "btnCreateKeys";
            this.btnCreateKeys.Size = new System.Drawing.Size(100, 25);
            this.btnCreateKeys.TabIndex = 19;
            this.btnCreateKeys.Text = "生成全新密钥";
            this.btnCreateKeys.UseVisualStyleBackColor = true;
            this.btnCreateKeys.Click += new System.EventHandler(this.btnCreateKeys_Click);
            // 
            // lblRSAKey
            // 
            this.lblRSAKey.Location = new System.Drawing.Point(7, 134);
            this.lblRSAKey.Name = "lblRSAKey";
            this.lblRSAKey.Size = new System.Drawing.Size(60, 20);
            this.lblRSAKey.TabIndex = 18;
            this.lblRSAKey.Text = "密钥";
            this.lblRSAKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRSAKey
            // 
            this.txtRSAKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRSAKey.Location = new System.Drawing.Point(73, 134);
            this.txtRSAKey.Name = "txtRSAKey";
            this.txtRSAKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSAKey.Size = new System.Drawing.Size(392, 20);
            this.txtRSAKey.TabIndex = 17;
            this.txtRSAKey.TextChanged += new System.EventHandler(this.txtRSAKey_TextChanged);
            // 
            // btnRSAEncryptOrDecrypt
            // 
            this.btnRSAEncryptOrDecrypt.Location = new System.Drawing.Point(73, 160);
            this.btnRSAEncryptOrDecrypt.Name = "btnRSAEncryptOrDecrypt";
            this.btnRSAEncryptOrDecrypt.Size = new System.Drawing.Size(75, 25);
            this.btnRSAEncryptOrDecrypt.TabIndex = 16;
            this.btnRSAEncryptOrDecrypt.Text = "加密";
            this.btnRSAEncryptOrDecrypt.UseVisualStyleBackColor = true;
            this.btnRSAEncryptOrDecrypt.Click += new System.EventHandler(this.btnRSAEncryptOrDecrypt_Click);
            // 
            // txtRSATargetText
            // 
            this.txtRSATargetText.Location = new System.Drawing.Point(73, 188);
            this.txtRSATargetText.Multiline = true;
            this.txtRSATargetText.Name = "txtRSATargetText";
            this.txtRSATargetText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSATargetText.Size = new System.Drawing.Size(392, 100);
            this.txtRSATargetText.TabIndex = 15;
            // 
            // lblRSATargetText
            // 
            this.lblRSATargetText.Location = new System.Drawing.Point(7, 191);
            this.lblRSATargetText.Name = "lblRSATargetText";
            this.lblRSATargetText.Size = new System.Drawing.Size(60, 19);
            this.lblRSATargetText.TabIndex = 14;
            this.lblRSATargetText.Text = "目标文本";
            this.lblRSATargetText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRSASourceText
            // 
            this.lblRSASourceText.Location = new System.Drawing.Point(7, 28);
            this.lblRSASourceText.Name = "lblRSASourceText";
            this.lblRSASourceText.Size = new System.Drawing.Size(60, 19);
            this.lblRSASourceText.TabIndex = 13;
            this.lblRSASourceText.Text = "源文本";
            this.lblRSASourceText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRSASourceText
            // 
            this.txtRSASourceText.Location = new System.Drawing.Point(73, 25);
            this.txtRSASourceText.Multiline = true;
            this.txtRSASourceText.Name = "txtRSASourceText";
            this.txtRSASourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSASourceText.Size = new System.Drawing.Size(392, 100);
            this.txtRSASourceText.TabIndex = 12;
            // 
            // rdbRSADecrypt
            // 
            this.rdbRSADecrypt.AutoSize = true;
            this.rdbRSADecrypt.Location = new System.Drawing.Point(142, 6);
            this.rdbRSADecrypt.Name = "rdbRSADecrypt";
            this.rdbRSADecrypt.Size = new System.Drawing.Size(50, 21);
            this.rdbRSADecrypt.TabIndex = 11;
            this.rdbRSADecrypt.TabStop = true;
            this.rdbRSADecrypt.Text = "解密";
            this.rdbRSADecrypt.UseVisualStyleBackColor = true;
            this.rdbRSADecrypt.CheckedChanged += new System.EventHandler(this.rdbRSADecrypt_CheckedChanged);
            // 
            // rdbRSAEncrypt
            // 
            this.rdbRSAEncrypt.AutoSize = true;
            this.rdbRSAEncrypt.Checked = true;
            this.rdbRSAEncrypt.Location = new System.Drawing.Point(73, 6);
            this.rdbRSAEncrypt.Name = "rdbRSAEncrypt";
            this.rdbRSAEncrypt.Size = new System.Drawing.Size(50, 21);
            this.rdbRSAEncrypt.TabIndex = 10;
            this.rdbRSAEncrypt.TabStop = true;
            this.rdbRSAEncrypt.Text = "加密";
            this.rdbRSAEncrypt.UseVisualStyleBackColor = true;
            this.rdbRSAEncrypt.CheckedChanged += new System.EventHandler(this.rdbRSAEncrypt_CheckedChanged);
            // 
            // pnlFull
            // 
            this.pnlFull.Controls.Add(this.tabEncodeType);
            this.pnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFull.Location = new System.Drawing.Point(0, 0);
            this.pnlFull.Name = "pnlFull";
            this.pnlFull.Size = new System.Drawing.Size(515, 374);
            this.pnlFull.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "打开开源地址";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 374);
            this.Controls.Add(this.pnlFull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurChat 加密&解密工具";
            this.tabEncodeType.ResumeLayout(false);
            this.tbpRSA.ResumeLayout(false);
            this.tbpRSA.PerformLayout();
            this.pnlFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEncodeType;
        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.TabPage tbpRSA;
        private System.Windows.Forms.TextBox txtRSAKey;
        private System.Windows.Forms.Button btnRSAEncryptOrDecrypt;
        private System.Windows.Forms.TextBox txtRSATargetText;
        private System.Windows.Forms.Label lblRSATargetText;
        private System.Windows.Forms.Label lblRSASourceText;
        private System.Windows.Forms.TextBox txtRSASourceText;
        private System.Windows.Forms.RadioButton rdbRSADecrypt;
        private System.Windows.Forms.RadioButton rdbRSAEncrypt;
        private System.Windows.Forms.Label lblRSAKey;
        private System.Windows.Forms.Button btnCreateKeys;
        private System.Windows.Forms.Button button1;
    }
}