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
            this.label1 = new System.Windows.Forms.Label();
            this.pubkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptoText = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceiverPublic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncryptoResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 18F);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(908, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "K2Lin Crypto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pubkey
            // 
            this.pubkey.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pubkey.Location = new System.Drawing.Point(103, 13);
            this.pubkey.MaxLength = 4096;
            this.pubkey.Multiline = true;
            this.pubkey.Name = "pubkey";
            this.pubkey.ReadOnly = true;
            this.pubkey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pubkey.Size = new System.Drawing.Size(949, 34);
            this.pubkey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 12F);
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Key";
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("等线", 10F);
            this.generate.Location = new System.Drawing.Point(801, 95);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(122, 43);
            this.generate.TabIndex = 5;
            this.generate.Text = "Generate Keypair";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 18F);
            this.label3.Location = new System.Drawing.Point(90, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encryption";
            // 
            // EncryptoText
            // 
            this.EncryptoText.Location = new System.Drawing.Point(157, 164);
            this.EncryptoText.Name = "EncryptoText";
            this.EncryptoText.Size = new System.Drawing.Size(895, 22);
            this.EncryptoText.TabIndex = 7;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("等线", 14F);
            this.EncryptButton.Location = new System.Drawing.Point(930, 247);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(122, 34);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "Encrypt!";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 12F);
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Text to Encrypt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 12F);
            this.label5.Location = new System.Drawing.Point(58, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Public key\r\n(Receiver)";
            // 
            // ReceiverPublic
            // 
            this.ReceiverPublic.Location = new System.Drawing.Point(157, 192);
            this.ReceiverPublic.Multiline = true;
            this.ReceiverPublic.Name = "ReceiverPublic";
            this.ReceiverPublic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceiverPublic.Size = new System.Drawing.Size(895, 48);
            this.ReceiverPublic.TabIndex = 11;
            this.ReceiverPublic.TextChanged += new System.EventHandler(this.ReceiverPublic_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等线", 12F);
            this.label6.Location = new System.Drawing.Point(24, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Encrypted Text";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EncryptoResult
            // 
            this.EncryptoResult.Location = new System.Drawing.Point(157, 288);
            this.EncryptoResult.Name = "EncryptoResult";
            this.EncryptoResult.Size = new System.Drawing.Size(895, 22);
            this.EncryptoResult.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 18F);
            this.label7.Location = new System.Drawing.Point(90, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Decryption";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::K2LinCrypto.Properties.Resources.lock_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 69);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::K2LinCrypto.Properties.Resources.unlock_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 326);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 69);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("等线", 12F);
            this.label8.Location = new System.Drawing.Point(21, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Text to Decrypt";
            // 
            // DecryptoText
            // 
            this.DecryptoText.Location = new System.Drawing.Point(157, 395);
            this.DecryptoText.Name = "DecryptoText";
            this.DecryptoText.Size = new System.Drawing.Size(895, 22);
            this.DecryptoText.TabIndex = 18;
            // 
            // DecryptoResult
            // 
            this.DecryptoResult.Location = new System.Drawing.Point(157, 464);
            this.DecryptoResult.Name = "DecryptoResult";
            this.DecryptoResult.Size = new System.Drawing.Size(895, 22);
            this.DecryptoResult.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("等线", 12F);
            this.label9.Location = new System.Drawing.Point(25, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Decrypted Text";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("等线", 14F);
            this.DecryptButton.Location = new System.Drawing.Point(930, 423);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(122, 34);
            this.DecryptButton.TabIndex = 21;
            this.DecryptButton.Text = "Decrypt!";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // privkey
            // 
            this.privkey.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.privkey.Location = new System.Drawing.Point(103, 54);
            this.privkey.MaxLength = 4096;
            this.privkey.Multiline = true;
            this.privkey.Name = "privkey";
            this.privkey.ReadOnly = true;
            this.privkey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.privkey.Size = new System.Drawing.Size(949, 34);
            this.privkey.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("等线", 12F);
            this.label10.Location = new System.Drawing.Point(1, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Private Key";
            // 
            // CopyPublicKey
            // 
            this.CopyPublicKey.Font = new System.Drawing.Font("等线", 10F);
            this.CopyPublicKey.Location = new System.Drawing.Point(930, 95);
            this.CopyPublicKey.Name = "CopyPublicKey";
            this.CopyPublicKey.Size = new System.Drawing.Size(122, 43);
            this.CopyPublicKey.TabIndex = 24;
            this.CopyPublicKey.Text = "Copy PublicKey";
            this.CopyPublicKey.UseVisualStyleBackColor = true;
            this.CopyPublicKey.Click += new System.EventHandler(this.CopyPublicKey_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Session ID:";
            // 
            // EncryptSessionID
            // 
            this.EncryptSessionID.Location = new System.Drawing.Point(801, 247);
            this.EncryptSessionID.Name = "EncryptSessionID";
            this.EncryptSessionID.ReadOnly = true;
            this.EncryptSessionID.Size = new System.Drawing.Size(114, 22);
            this.EncryptSessionID.TabIndex = 26;
            // 
            // SelfSessionID
            // 
            this.SelfSessionID.Location = new System.Drawing.Point(680, 95);
            this.SelfSessionID.Name = "SelfSessionID";
            this.SelfSessionID.ReadOnly = true;
            this.SelfSessionID.Size = new System.Drawing.Size(114, 22);
            this.SelfSessionID.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(601, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "Session ID:";
            // 
            // Sel4096
            // 
            this.Sel4096.AutoSize = true;
            this.Sel4096.Location = new System.Drawing.Point(358, 102);
            this.Sel4096.Name = "Sel4096";
            this.Sel4096.Size = new System.Drawing.Size(84, 18);
            this.Sel4096.TabIndex = 29;
            this.Sel4096.Text = "4096 Bits";
            this.Sel4096.UseVisualStyleBackColor = true;
            this.Sel4096.CheckedChanged += new System.EventHandler(this.Sel4096_CheckedChanged);
            // 
            // Sel2048
            // 
            this.Sel2048.AutoSize = true;
            this.Sel2048.Checked = true;
            this.Sel2048.Location = new System.Drawing.Point(254, 102);
            this.Sel2048.Name = "Sel2048";
            this.Sel2048.Size = new System.Drawing.Size(84, 18);
            this.Sel2048.TabIndex = 30;
            this.Sel2048.TabStop = true;
            this.Sel2048.Text = "2048 Bits";
            this.Sel2048.UseVisualStyleBackColor = true;
            this.Sel2048.CheckedChanged += new System.EventHandler(this.Sel2048_CheckedChanged);
            // 
            // Sel8192
            // 
            this.Sel8192.AutoSize = true;
            this.Sel8192.Location = new System.Drawing.Point(462, 102);
            this.Sel8192.Name = "Sel8192";
            this.Sel8192.Size = new System.Drawing.Size(84, 18);
            this.Sel8192.TabIndex = 31;
            this.Sel8192.Text = "8192 Bits";
            this.Sel8192.UseVisualStyleBackColor = true;
            this.Sel8192.CheckedChanged += new System.EventHandler(this.Sel8192_CheckedChanged);
            // 
            // Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 526);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EncryptoResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReceiverPublic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.EncryptoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pubkey);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crypto";
            this.Text = "K2Lin Cryptography V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pubkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EncryptoText;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReceiverPublic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EncryptoResult;
        private System.Windows.Forms.Label label7;
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
    }
}

