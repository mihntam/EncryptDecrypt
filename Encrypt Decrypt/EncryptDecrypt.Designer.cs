namespace EncryptDecrypt
{
    partial class EncryptDecrypt
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCipher = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCipherTextDec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRSADecrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDecOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRSAEncrypt = new System.Windows.Forms.Button();
            this.txtEncOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlainTextEnc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.cboKeyPairSize = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGenerateKeyPair = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabCipher.SuspendLayout();
            this.tabRSA.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCipher);
            this.tabControl.Controls.Add(this.tabRSA);
            this.tabControl.Controls.Add(this.tabTeam);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 637);
            this.tabControl.TabIndex = 0;
            // 
            // tabCipher
            // 
            this.tabCipher.Controls.Add(this.label3);
            this.tabCipher.Controls.Add(this.txtKey);
            this.tabCipher.Controls.Add(this.label2);
            this.tabCipher.Controls.Add(this.label1);
            this.tabCipher.Controls.Add(this.btnDecrypt);
            this.tabCipher.Controls.Add(this.txtOutput);
            this.tabCipher.Controls.Add(this.btnEncrypt);
            this.tabCipher.Controls.Add(this.txtInput);
            this.tabCipher.Location = new System.Drawing.Point(4, 24);
            this.tabCipher.Name = "tabCipher";
            this.tabCipher.Padding = new System.Windows.Forms.Padding(3);
            this.tabCipher.Size = new System.Drawing.Size(952, 609);
            this.tabCipher.TabIndex = 0;
            this.tabCipher.Text = "Vigenere Cipher";
            this.tabCipher.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey.Location = new System.Drawing.Point(23, 329);
            this.txtKey.Margin = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(346, 257);
            this.txtKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(512, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.BackColor = System.Drawing.Color.Tomato;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrypt.Location = new System.Drawing.Point(392, 308);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(97, 37);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(512, 44);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(417, 542);
            this.txtOutput.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncrypt.Location = new System.Drawing.Point(392, 261);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(97, 37);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(23, 44);
            this.txtInput.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(346, 254);
            this.txtInput.TabIndex = 0;
            // 
            // tabRSA
            // 
            this.tabRSA.Controls.Add(this.groupBox3);
            this.tabRSA.Controls.Add(this.groupBox2);
            this.tabRSA.Controls.Add(this.groupBox1);
            this.tabRSA.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabRSA.Location = new System.Drawing.Point(4, 24);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tabRSA.Size = new System.Drawing.Size(952, 609);
            this.tabRSA.TabIndex = 1;
            this.tabRSA.Text = "RSA";
            this.tabRSA.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtCipherTextDec);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnRSADecrypt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDecOutput);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(477, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 401);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RSA Decryption";
            // 
            // txtCipherTextDec
            // 
            this.txtCipherTextDec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCipherTextDec.Location = new System.Drawing.Point(6, 50);
            this.txtCipherTextDec.Margin = new System.Windows.Forms.Padding(5);
            this.txtCipherTextDec.Multiline = true;
            this.txtCipherTextDec.Name = "txtCipherTextDec";
            this.txtCipherTextDec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCipherTextDec.Size = new System.Drawing.Size(458, 121);
            this.txtCipherTextDec.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Enter Plain Text to Decrypt";
            // 
            // btnRSADecrypt
            // 
            this.btnRSADecrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRSADecrypt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRSADecrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRSADecrypt.Location = new System.Drawing.Point(3, 181);
            this.btnRSADecrypt.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnRSADecrypt.Name = "btnRSADecrypt";
            this.btnRSADecrypt.Size = new System.Drawing.Size(88, 32);
            this.btnRSADecrypt.TabIndex = 16;
            this.btnRSADecrypt.Text = "Decrypt";
            this.btnRSADecrypt.UseVisualStyleBackColor = false;
            this.btnRSADecrypt.Click += new System.EventHandler(this.btnRSADecrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Decrypted Output";
            // 
            // txtDecOutput
            // 
            this.txtDecOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDecOutput.Location = new System.Drawing.Point(3, 248);
            this.txtDecOutput.Margin = new System.Windows.Forms.Padding(5);
            this.txtDecOutput.Multiline = true;
            this.txtDecOutput.Name = "txtDecOutput";
            this.txtDecOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecOutput.Size = new System.Drawing.Size(458, 148);
            this.txtDecOutput.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRSAEncrypt);
            this.groupBox2.Controls.Add(this.txtEncOutput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPlainTextEnc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 401);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA Encryption";
            // 
            // btnRSAEncrypt
            // 
            this.btnRSAEncrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRSAEncrypt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRSAEncrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRSAEncrypt.Location = new System.Drawing.Point(5, 181);
            this.btnRSAEncrypt.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnRSAEncrypt.Name = "btnRSAEncrypt";
            this.btnRSAEncrypt.Size = new System.Drawing.Size(88, 32);
            this.btnRSAEncrypt.TabIndex = 10;
            this.btnRSAEncrypt.Text = "Encrypt";
            this.btnRSAEncrypt.UseVisualStyleBackColor = false;
            this.btnRSAEncrypt.Click += new System.EventHandler(this.btnRSAEncrypt_Click);
            // 
            // txtEncOutput
            // 
            this.txtEncOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEncOutput.Location = new System.Drawing.Point(5, 248);
            this.txtEncOutput.Margin = new System.Windows.Forms.Padding(5);
            this.txtEncOutput.Multiline = true;
            this.txtEncOutput.Name = "txtEncOutput";
            this.txtEncOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncOutput.Size = new System.Drawing.Size(458, 148);
            this.txtEncOutput.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(5, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Encrypted Output";
            // 
            // txtPlainTextEnc
            // 
            this.txtPlainTextEnc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlainTextEnc.Location = new System.Drawing.Point(8, 50);
            this.txtPlainTextEnc.Margin = new System.Windows.Forms.Padding(5);
            this.txtPlainTextEnc.Multiline = true;
            this.txtPlainTextEnc.Name = "txtPlainTextEnc";
            this.txtPlainTextEnc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlainTextEnc.Size = new System.Drawing.Size(458, 121);
            this.txtPlainTextEnc.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Plain Text to Encrypt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportKey);
            this.groupBox1.Controls.Add(this.btnSaveKey);
            this.groupBox1.Controls.Add(this.cboKeyPairSize);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnGenerateKeyPair);
            this.groupBox1.Controls.Add(this.txtPrivateKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPublicKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA Key Pair";
            // 
            // btnImportKey
            // 
            this.btnImportKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImportKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportKey.ForeColor = System.Drawing.Color.Black;
            this.btnImportKey.Location = new System.Drawing.Point(709, 24);
            this.btnImportKey.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(120, 32);
            this.btnImportKey.TabIndex = 17;
            this.btnImportKey.Text = "Import Keypair";
            this.btnImportKey.UseVisualStyleBackColor = false;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveKey.ForeColor = System.Drawing.Color.Black;
            this.btnSaveKey.Location = new System.Drawing.Point(831, 24);
            this.btnSaveKey.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(107, 32);
            this.btnSaveKey.TabIndex = 16;
            this.btnSaveKey.Text = "Save Keypair";
            this.btnSaveKey.UseVisualStyleBackColor = false;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // cboKeyPairSize
            // 
            this.cboKeyPairSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboKeyPairSize.FormattingEnabled = true;
            this.cboKeyPairSize.Location = new System.Drawing.Point(297, 33);
            this.cboKeyPairSize.Name = "cboKeyPairSize";
            this.cboKeyPairSize.Size = new System.Drawing.Size(93, 26);
            this.cboKeyPairSize.TabIndex = 15;
            this.cboKeyPairSize.Text = "512 bits";
            this.cboKeyPairSize.SelectedValueChanged += new System.EventHandler(this.cboKeyPairSize_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(197, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Key Pair Size";
            // 
            // btnGenerateKeyPair
            // 
            this.btnGenerateKeyPair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateKeyPair.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateKeyPair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateKeyPair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateKeyPair.Location = new System.Drawing.Point(8, 30);
            this.btnGenerateKeyPair.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnGenerateKeyPair.Name = "btnGenerateKeyPair";
            this.btnGenerateKeyPair.Size = new System.Drawing.Size(164, 32);
            this.btnGenerateKeyPair.TabIndex = 5;
            this.btnGenerateKeyPair.Text = "Generate RSA key pair";
            this.btnGenerateKeyPair.UseVisualStyleBackColor = false;
            this.btnGenerateKeyPair.Click += new System.EventHandler(this.btnGenerateKeyPair_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivateKey.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrivateKey.Location = new System.Drawing.Point(474, 86);
            this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrivateKey.Size = new System.Drawing.Size(464, 102);
            this.txtPrivateKey.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(474, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Private Key";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPublicKey.Location = new System.Drawing.Point(8, 86);
            this.txtPublicKey.Margin = new System.Windows.Forms.Padding(5);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPublicKey.Size = new System.Drawing.Size(464, 102);
            this.txtPublicKey.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Public Key";
            // 
            // tabTeam
            // 
            this.tabTeam.Location = new System.Drawing.Point(4, 24);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Size = new System.Drawing.Size(952, 609);
            this.tabTeam.TabIndex = 2;
            this.tabTeam.Text = "7guys";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // EncryptDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "EncryptDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E&D";
            this.Load += new System.EventHandler(this.EncryptDecrypt_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCipher.ResumeLayout(false);
            this.tabCipher.PerformLayout();
            this.tabRSA.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabCipher;
        private TabPage tabRSA;
        private TextBox txtInput;
        private Button btnEncrypt;
        private TextBox txtOutput;
        private Button btnDecrypt;
        private Label label2;
        private Label label1;
        private TabPage tabTeam;
        private Label label3;
        private TextBox txtKey;
        private GroupBox groupBox1;
        private TextBox txtPrivateKey;
        private Label label5;
        private TextBox txtPublicKey;
        private Label label4;
        private Button btnGenerateKeyPair;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtPlainTextEnc;
        private Label label6;
        private Button btnRSAEncrypt;
        private TextBox txtEncOutput;
        private Label label8;
        private TextBox txtCipherTextDec;
        private Label label9;
        private Button btnRSADecrypt;
        private Label label7;
        private TextBox txtDecOutput;
        private Label label10;
        private ComboBox cboKeyPairSize;
        private Button btnSaveKey;
        private Button btnImportKey;
    }
}