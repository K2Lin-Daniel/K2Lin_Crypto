namespace K2LinCrypto
{
    partial class Crypto
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crypto));
            this.pubkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.EncryptoText = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceiverPublic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncryptoResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DecryptoText = new System.Windows.Forms.TextBox();
            this.DecryptoResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.privkey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CopyPublicKey = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.EncryptSessionID = new System.Windows.Forms.TextBox();
            this.SelfSessionID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Sel4096 = new System.Windows.Forms.RadioButton();
            this.Sel2048 = new System.Windows.Forms.RadioButton();
            this.Sel8192 = new System.Windows.Forms.RadioButton();
            this.CopyEncryptedText = new System.Windows.Forms.Button();
            this.SwapMode = new System.Windows.Forms.CheckBox();
            this.HashIDIncorrect = new System.Windows.Forms.Label();
            this.EncryptionText = new System.Windows.Forms.PictureBox();
            this.DecryptionText = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReadXML = new System.Windows.Forms.OpenFileDialog();
            this.SaveXML = new System.Windows.Forms.SaveFileDialog();
            this.SaveKeyPair = new System.Windows.Forms.Button();
            this.ReadKeyPair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pubkey
            // 
            resources.ApplyResources(this.pubkey, "pubkey");
            this.pubkey.Name = "pubkey";
            this.pubkey.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // generate
            // 
            resources.ApplyResources(this.generate, "generate");
            this.generate.Name = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // EncryptoText
            // 
            resources.ApplyResources(this.EncryptoText, "EncryptoText");
            this.EncryptoText.Name = "EncryptoText";
            // 
            // EncryptButton
            // 
            resources.ApplyResources(this.EncryptButton, "EncryptButton");
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ReceiverPublic
            // 
            resources.ApplyResources(this.ReceiverPublic, "ReceiverPublic");
            this.ReceiverPublic.Name = "ReceiverPublic";
            this.ReceiverPublic.TextChanged += new System.EventHandler(this.ReceiverPublic_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EncryptoResult
            // 
            resources.ApplyResources(this.EncryptoResult, "EncryptoResult");
            this.EncryptoResult.Name = "EncryptoResult";
            this.EncryptoResult.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // DecryptoText
            // 
            resources.ApplyResources(this.DecryptoText, "DecryptoText");
            this.DecryptoText.Name = "DecryptoText";
            // 
            // DecryptoResult
            // 
            resources.ApplyResources(this.DecryptoResult, "DecryptoResult");
            this.DecryptoResult.Name = "DecryptoResult";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // DecryptButton
            // 
            resources.ApplyResources(this.DecryptButton, "DecryptButton");
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // privkey
            // 
            resources.ApplyResources(this.privkey, "privkey");
            this.privkey.Name = "privkey";
            this.privkey.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // CopyPublicKey
            // 
            resources.ApplyResources(this.CopyPublicKey, "CopyPublicKey");
            this.CopyPublicKey.Name = "CopyPublicKey";
            this.CopyPublicKey.UseVisualStyleBackColor = true;
            this.CopyPublicKey.Click += new System.EventHandler(this.CopyPublicKey_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // EncryptSessionID
            // 
            resources.ApplyResources(this.EncryptSessionID, "EncryptSessionID");
            this.EncryptSessionID.Name = "EncryptSessionID";
            this.EncryptSessionID.ReadOnly = true;
            // 
            // SelfSessionID
            // 
            resources.ApplyResources(this.SelfSessionID, "SelfSessionID");
            this.SelfSessionID.Name = "SelfSessionID";
            this.SelfSessionID.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // Sel4096
            // 
            resources.ApplyResources(this.Sel4096, "Sel4096");
            this.Sel4096.Name = "Sel4096";
            this.Sel4096.TabStop = true;
            this.Sel4096.UseVisualStyleBackColor = true;
            this.Sel4096.CheckedChanged += new System.EventHandler(this.Sel4096_CheckedChanged);
            // 
            // Sel2048
            // 
            resources.ApplyResources(this.Sel2048, "Sel2048");
            this.Sel2048.Checked = true;
            this.Sel2048.Name = "Sel2048";
            this.Sel2048.TabStop = true;
            this.Sel2048.UseVisualStyleBackColor = true;
            this.Sel2048.CheckedChanged += new System.EventHandler(this.Sel2048_CheckedChanged);
            // 
            // Sel8192
            // 
            resources.ApplyResources(this.Sel8192, "Sel8192");
            this.Sel8192.Name = "Sel8192";
            this.Sel8192.TabStop = true;
            this.Sel8192.UseVisualStyleBackColor = true;
            this.Sel8192.CheckedChanged += new System.EventHandler(this.Sel8192_CheckedChanged);
            // 
            // CopyEncryptedText
            // 
            resources.ApplyResources(this.CopyEncryptedText, "CopyEncryptedText");
            this.CopyEncryptedText.Name = "CopyEncryptedText";
            this.CopyEncryptedText.UseVisualStyleBackColor = true;
            this.CopyEncryptedText.Click += new System.EventHandler(this.CopyEncryptedText_Click);
            // 
            // SwapMode
            // 
            resources.ApplyResources(this.SwapMode, "SwapMode");
            this.SwapMode.Name = "SwapMode";
            this.SwapMode.UseVisualStyleBackColor = true;
            this.SwapMode.CheckedChanged += new System.EventHandler(this.SwapMode_CheckedChanged);
            // 
            // HashIDIncorrect
            // 
            resources.ApplyResources(this.HashIDIncorrect, "HashIDIncorrect");
            this.HashIDIncorrect.ForeColor = System.Drawing.Color.Red;
            this.HashIDIncorrect.Name = "HashIDIncorrect";
            // 
            // EncryptionText
            // 
            this.EncryptionText.BackColor = System.Drawing.Color.Transparent;
            this.EncryptionText.BackgroundImage = global::K2LinCrypto.Properties.Resources.Encryption;
            resources.ApplyResources(this.EncryptionText, "EncryptionText");
            this.EncryptionText.Name = "EncryptionText";
            this.EncryptionText.TabStop = false;
            // 
            // DecryptionText
            // 
            this.DecryptionText.BackColor = System.Drawing.Color.Transparent;
            this.DecryptionText.BackgroundImage = global::K2LinCrypto.Properties.Resources.Decryption;
            resources.ApplyResources(this.DecryptionText, "DecryptionText");
            this.DecryptionText.Name = "DecryptionText";
            this.DecryptionText.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::K2LinCrypto.Properties.Resources.K2Lin_crypto_XML;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::K2LinCrypto.Properties.Resources.unlock_icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::K2LinCrypto.Properties.Resources.lock_icon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ReadXML
            // 
            this.ReadXML.DefaultExt = "xml";
            this.ReadXML.InitialDirectory = "%USERPROFILE%\\Desktop";
            resources.ApplyResources(this.ReadXML, "ReadXML");
            // 
            // SaveXML
            // 
            this.SaveXML.DefaultExt = "xml";
            this.SaveXML.DereferenceLinks = false;
            this.SaveXML.InitialDirectory = "%USERPROFILE%\\Desktop";
            resources.ApplyResources(this.SaveXML, "SaveXML");
            // 
            // SaveKeyPair
            // 
            resources.ApplyResources(this.SaveKeyPair, "SaveKeyPair");
            this.SaveKeyPair.Name = "SaveKeyPair";
            this.SaveKeyPair.UseVisualStyleBackColor = true;
            this.SaveKeyPair.Click += new System.EventHandler(this.SaveKeyPair_Click);
            // 
            // ReadKeyPair
            // 
            resources.ApplyResources(this.ReadKeyPair, "ReadKeyPair");
            this.ReadKeyPair.Name = "ReadKeyPair";
            this.ReadKeyPair.UseVisualStyleBackColor = true;
            this.ReadKeyPair.Click += new System.EventHandler(this.ReadKeyPair_Click);
            // 
            // Crypto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReadKeyPair);
            this.Controls.Add(this.SaveKeyPair);
            this.Controls.Add(this.EncryptionText);
            this.Controls.Add(this.DecryptionText);
            this.Controls.Add(this.HashIDIncorrect);
            this.Controls.Add(this.SwapMode);
            this.Controls.Add(this.CopyEncryptedText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Sel8192);
            this.Controls.Add(this.Sel2048);
            this.Controls.Add(this.Sel4096);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SelfSessionID);
            this.Controls.Add(this.EncryptSessionID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CopyPublicKey);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.privkey);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DecryptoResult);
            this.Controls.Add(this.DecryptoText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EncryptoResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReceiverPublic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.EncryptoText);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pubkey);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EncryptionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pubkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox EncryptoText;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReceiverPublic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EncryptoResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DecryptoText;
        private System.Windows.Forms.TextBox DecryptoResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox privkey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CopyPublicKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EncryptSessionID;
        private System.Windows.Forms.TextBox SelfSessionID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton Sel4096;
        private System.Windows.Forms.RadioButton Sel2048;
        private System.Windows.Forms.RadioButton Sel8192;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button CopyEncryptedText;
        private System.Windows.Forms.CheckBox SwapMode;
        private System.Windows.Forms.Label HashIDIncorrect;
        private System.Windows.Forms.PictureBox DecryptionText;
        private System.Windows.Forms.PictureBox EncryptionText;
        private System.Windows.Forms.OpenFileDialog ReadXML;
        private System.Windows.Forms.SaveFileDialog SaveXML;
        private System.Windows.Forms.Button SaveKeyPair;
        private System.Windows.Forms.Button ReadKeyPair;
    }
}

