
namespace RSA注册机
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMchineCode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAuthCode = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDeCode = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMchineCode2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCopyAuthCode = new System.Windows.Forms.Button();
            this.btnCopyPublicKey = new System.Windows.Forms.Button();
            this.btnCopyPrivateKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(690, 10);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublicKey.Location = new System.Drawing.Point(3, 23);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicKey.Size = new System.Drawing.Size(318, 140);
            this.txtPublicKey.TabIndex = 1;
            this.txtPublicKey.TextChanged += new System.EventHandler(this.txtPublicKey_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPublicKey);
            this.groupBox1.Location = new System.Drawing.Point(15, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公钥";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrivateKey);
            this.groupBox2.Location = new System.Drawing.Point(454, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 166);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "私钥";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(3, 23);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivateKey.Size = new System.Drawing.Size(325, 140);
            this.txtPrivateKey.TabIndex = 1;
            this.txtPrivateKey.TextChanged += new System.EventHandler(this.txtPrivateKey_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMchineCode);
            this.groupBox3.Location = new System.Drawing.Point(15, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 86);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "①原文";
            // 
            // txtMchineCode
            // 
            this.txtMchineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMchineCode.Location = new System.Drawing.Point(3, 23);
            this.txtMchineCode.Multiline = true;
            this.txtMchineCode.Name = "txtMchineCode";
            this.txtMchineCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMchineCode.Size = new System.Drawing.Size(318, 60);
            this.txtMchineCode.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAuthCode);
            this.groupBox4.Location = new System.Drawing.Point(454, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 86);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "②私钥加密原文得到密文";
            // 
            // txtAuthCode
            // 
            this.txtAuthCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAuthCode.Location = new System.Drawing.Point(3, 23);
            this.txtAuthCode.Multiline = true;
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAuthCode.Size = new System.Drawing.Size(318, 60);
            this.txtAuthCode.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(457, 193);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(115, 32);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "①私钥加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // btnDeCode
            // 
            this.btnDeCode.Location = new System.Drawing.Point(588, 193);
            this.btnDeCode.Name = "btnDeCode";
            this.btnDeCode.Size = new System.Drawing.Size(110, 32);
            this.btnDeCode.TabIndex = 8;
            this.btnDeCode.Text = "②公钥解密";
            this.btnDeCode.UseVisualStyleBackColor = true;
            this.btnDeCode.Click += new System.EventHandler(this.BtnDeCode_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(719, 193);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(71, 32);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "③对比";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMchineCode2);
            this.groupBox5.Location = new System.Drawing.Point(15, 193);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 86);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "③密文解密得到原文";
            // 
            // txtMchineCode2
            // 
            this.txtMchineCode2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMchineCode2.Location = new System.Drawing.Point(3, 23);
            this.txtMchineCode2.Multiline = true;
            this.txtMchineCode2.Name = "txtMchineCode2";
            this.txtMchineCode2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMchineCode2.Size = new System.Drawing.Size(318, 60);
            this.txtMchineCode2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(340, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "生成一对";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCopyAuthCode
            // 
            this.btnCopyAuthCode.Location = new System.Drawing.Point(457, 247);
            this.btnCopyAuthCode.Name = "btnCopyAuthCode";
            this.btnCopyAuthCode.Size = new System.Drawing.Size(95, 32);
            this.btnCopyAuthCode.TabIndex = 11;
            this.btnCopyAuthCode.Text = "复制密文";
            this.btnCopyAuthCode.UseVisualStyleBackColor = true;
            this.btnCopyAuthCode.Click += new System.EventHandler(this.BtnCopyAuthCode_Click);
            // 
            // btnCopyPublicKey
            // 
            this.btnCopyPublicKey.Location = new System.Drawing.Point(576, 247);
            this.btnCopyPublicKey.Name = "btnCopyPublicKey";
            this.btnCopyPublicKey.Size = new System.Drawing.Size(95, 32);
            this.btnCopyPublicKey.TabIndex = 12;
            this.btnCopyPublicKey.Text = "复制公钥";
            this.btnCopyPublicKey.UseVisualStyleBackColor = true;
            this.btnCopyPublicKey.Click += new System.EventHandler(this.BtnCopyPublicKey_Click);
            // 
            // btnCopyPrivateKey
            // 
            this.btnCopyPrivateKey.Location = new System.Drawing.Point(695, 247);
            this.btnCopyPrivateKey.Name = "btnCopyPrivateKey";
            this.btnCopyPrivateKey.Size = new System.Drawing.Size(95, 32);
            this.btnCopyPrivateKey.TabIndex = 13;
            this.btnCopyPrivateKey.Text = "复制私钥";
            this.btnCopyPrivateKey.UseVisualStyleBackColor = true;
            this.btnCopyPrivateKey.Click += new System.EventHandler(this.BtnCopyPrivateKey_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderThickness = 4F;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnCopyPrivateKey);
            this.Controls.Add(this.btnCopyPublicKey);
            this.Controls.Add(this.btnCopyAuthCode);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnDeCode);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "FrmMain";
            this.Text = "注册机校验工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMchineCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAuthCode;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDeCode;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMchineCode2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCopyAuthCode;
        private System.Windows.Forms.Button btnCopyPublicKey;
        private System.Windows.Forms.Button btnCopyPrivateKey;
    }
}

