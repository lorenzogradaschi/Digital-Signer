namespace Signer
{
    partial class Form1
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
            btnUploadFile = new Button();
            radioButton1 = new RadioButton();
            splitContainer1 = new SplitContainer();
            cert_pass = new TextBox();
            btn_SignFile = new Button();
            label3 = new Label();
            label2 = new Label();
            btn_VerifyCer = new Button();
            btn_LoadCer = new Button();
            cmbx_RSAkeysize = new ComboBox();
            btn_SaveKeys = new Button();
            btn_LoadKeys = new Button();
            btn_generateKeys = new Button();
            radioButton2 = new RadioButton();
            label1 = new Label();
            btn_LoadSigned = new Button();
            label4 = new Label();
            btn_Verify = new Button();
            btn_LoadCert2 = new Button();
            btn_LoadPubKey = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label6 = new Label();
            btn_LoadOriginal = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            openFileDialog4 = new OpenFileDialog();
            openFileDialog5 = new OpenFileDialog();
            openFileDialog6 = new OpenFileDialog();
            openFileDialog7 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUploadFile
            // 
            btnUploadFile.Location = new Point(180, 93);
            btnUploadFile.Name = "btnUploadFile";
            btnUploadFile.Size = new Size(245, 55);
            btnUploadFile.TabIndex = 0;
            btnUploadFile.Text = "SELECT";
            btnUploadFile.UseVisualStyleBackColor = true;
            btnUploadFile.Click += btnUploadFile_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(30, 220);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 36);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "RSA";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.GradientActiveCaption;
            splitContainer1.Panel1.Controls.Add(cert_pass);
            splitContainer1.Panel1.Controls.Add(btn_SignFile);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(btn_VerifyCer);
            splitContainer1.Panel1.Controls.Add(btn_LoadCer);
            splitContainer1.Panel1.Controls.Add(cmbx_RSAkeysize);
            splitContainer1.Panel1.Controls.Add(btn_SaveKeys);
            splitContainer1.Panel1.Controls.Add(btn_LoadKeys);
            splitContainer1.Panel1.Controls.Add(btn_generateKeys);
            splitContainer1.Panel1.Controls.Add(radioButton2);
            splitContainer1.Panel1.Controls.Add(radioButton1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnUploadFile);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Info;
            splitContainer1.Panel2.Controls.Add(btn_LoadSigned);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(btn_Verify);
            splitContainer1.Panel2.Controls.Add(btn_LoadCert2);
            splitContainer1.Panel2.Controls.Add(btn_LoadPubKey);
            splitContainer1.Panel2.Controls.Add(radioButton3);
            splitContainer1.Panel2.Controls.Add(radioButton4);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(btn_LoadOriginal);
            splitContainer1.Size = new Size(1102, 531);
            splitContainer1.SplitterDistance = 632;
            splitContainer1.TabIndex = 3;
            // 
            // cert_pass
            // 
            cert_pass.Location = new Point(198, 280);
            cert_pass.MaxLength = 16;
            cert_pass.Name = "cert_pass";
            cert_pass.PasswordChar = '*';
            cert_pass.PlaceholderText = "Enter password";
            cert_pass.Size = new Size(199, 39);
            cert_pass.TabIndex = 12;
            // 
            // btn_SignFile
            // 
            btn_SignFile.Location = new Point(180, 424);
            btn_SignFile.Name = "btn_SignFile";
            btn_SignFile.Size = new Size(245, 55);
            btn_SignFile.TabIndex = 11;
            btn_SignFile.Text = "SELECT";
            btn_SignFile.UseVisualStyleBackColor = true;
            btn_SignFile.Click += btn_SignFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 45);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 10;
            label3.Text = "Select a File to Sign";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 366);
            label2.Name = "label2";
            label2.Size = new Size(460, 32);
            label2.TabIndex = 2;
            label2.Text = "Sign the File and Download the Signature";
            // 
            // btn_VerifyCer
            // 
            btn_VerifyCer.Location = new Point(504, 276);
            btn_VerifyCer.Name = "btn_VerifyCer";
            btn_VerifyCer.Size = new Size(97, 48);
            btn_VerifyCer.TabIndex = 8;
            btn_VerifyCer.Text = "Verify Certificate";
            btn_VerifyCer.UseVisualStyleBackColor = true;
            btn_VerifyCer.Click += btn_VerifyCer_Click;
            // 
            // btn_LoadCer
            // 
            btn_LoadCer.Location = new Point(405, 278);
            btn_LoadCer.Name = "btn_LoadCer";
            btn_LoadCer.Size = new Size(93, 44);
            btn_LoadCer.TabIndex = 7;
            btn_LoadCer.Text = "Load";
            btn_LoadCer.UseVisualStyleBackColor = true;
            btn_LoadCer.Click += btn_LoadCer_Click;
            // 
            // cmbx_RSAkeysize
            // 
            cmbx_RSAkeysize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_RSAkeysize.FormattingEnabled = true;
            cmbx_RSAkeysize.Items.AddRange(new object[] { "1024", "2048" });
            cmbx_RSAkeysize.Location = new Point(132, 224);
            cmbx_RSAkeysize.Name = "cmbx_RSAkeysize";
            cmbx_RSAkeysize.Size = new Size(130, 40);
            cmbx_RSAkeysize.TabIndex = 0;
            // 
            // btn_SaveKeys
            // 
            btn_SaveKeys.Location = new Point(502, 220);
            btn_SaveKeys.Name = "btn_SaveKeys";
            btn_SaveKeys.Size = new Size(91, 46);
            btn_SaveKeys.TabIndex = 6;
            btn_SaveKeys.Text = "Save";
            btn_SaveKeys.UseVisualStyleBackColor = true;
            btn_SaveKeys.Click += btn_SaveKeys_Click;
            // 
            // btn_LoadKeys
            // 
            btn_LoadKeys.Location = new Point(403, 220);
            btn_LoadKeys.Name = "btn_LoadKeys";
            btn_LoadKeys.Size = new Size(93, 46);
            btn_LoadKeys.TabIndex = 5;
            btn_LoadKeys.Text = "Load";
            btn_LoadKeys.UseVisualStyleBackColor = true;
            btn_LoadKeys.Click += btn_LoadKeys_Click;
            // 
            // btn_generateKeys
            // 
            btn_generateKeys.Location = new Point(268, 220);
            btn_generateKeys.Name = "btn_generateKeys";
            btn_generateKeys.Size = new Size(129, 46);
            btn_generateKeys.TabIndex = 4;
            btn_generateKeys.Text = "Generate";
            btn_generateKeys.UseVisualStyleBackColor = true;
            btn_generateKeys.Click += btn_generateKeys_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(30, 280);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(153, 36);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Certificate";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 167);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 0;
            label1.Text = "Select a Method to Sign";
            // 
            // btn_LoadSigned
            // 
            btn_LoadSigned.Location = new Point(243, 93);
            btn_LoadSigned.Name = "btn_LoadSigned";
            btn_LoadSigned.Size = new Size(170, 55);
            btn_LoadSigned.TabIndex = 24;
            btn_LoadSigned.Text = "Signature";
            btn_LoadSigned.UseVisualStyleBackColor = true;
            btn_LoadSigned.Click += btn_LoadSigned_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 45);
            label4.Name = "label4";
            label4.Size = new Size(427, 32);
            label4.TabIndex = 23;
            label4.Text = "Select Original File and the Signed File";
            // 
            // btn_Verify
            // 
            btn_Verify.Location = new Point(102, 421);
            btn_Verify.Name = "btn_Verify";
            btn_Verify.Size = new Size(245, 58);
            btn_Verify.TabIndex = 22;
            btn_Verify.Text = "VERIFY";
            btn_Verify.UseVisualStyleBackColor = true;
            btn_Verify.Click += btn_Verify_Click;
            // 
            // btn_LoadCert2
            // 
            btn_LoadCert2.Location = new Point(197, 313);
            btn_LoadCert2.Name = "btn_LoadCert2";
            btn_LoadCert2.Size = new Size(216, 46);
            btn_LoadCert2.TabIndex = 20;
            btn_LoadCert2.Text = "Load a Certificate";
            btn_LoadCert2.UseVisualStyleBackColor = true;
            btn_LoadCert2.Click += btn_LoadCert2_Click;
            // 
            // btn_LoadPubKey
            // 
            btn_LoadPubKey.Location = new Point(124, 259);
            btn_LoadPubKey.Name = "btn_LoadPubKey";
            btn_LoadPubKey.Size = new Size(203, 46);
            btn_LoadPubKey.TabIndex = 17;
            btn_LoadPubKey.Text = "Load Public Key";
            btn_LoadPubKey.UseVisualStyleBackColor = true;
            btn_LoadPubKey.Click += btn_LoadPubKey_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(18, 321);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(153, 36);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Certificate";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(18, 261);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(87, 36);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "RSA";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 208);
            label6.Name = "label6";
            label6.Size = new Size(272, 32);
            label6.TabIndex = 12;
            label6.Text = "Select a Method to Sign";
            // 
            // btn_LoadOriginal
            // 
            btn_LoadOriginal.Location = new Point(42, 93);
            btn_LoadOriginal.Name = "btn_LoadOriginal";
            btn_LoadOriginal.Size = new Size(170, 55);
            btn_LoadOriginal.TabIndex = 13;
            btn_LoadOriginal.Text = "Original";
            btn_LoadOriginal.UseVisualStyleBackColor = true;
            btn_LoadOriginal.Click += btn_LoadOriginal_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // openFileDialog5
            // 
            openFileDialog5.FileName = "openFileDialog5";
            // 
            // openFileDialog6
            // 
            openFileDialog6.FileName = "openFileDialog6";
            // 
            // openFileDialog7
            // 
            openFileDialog7.FileName = "openFileDialog7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 536);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUploadFile;
        private RadioButton radioButton1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private ComboBox cmbx_RSAkeysize;
        private Button btn_SaveKeys;
        private Button btn_LoadKeys;
        private Button btn_generateKeys;
        private RadioButton radioButton2;
        private Label label3;
        private Button btn_VerifyCer;
        private Button btn_LoadCer;
        private Button btn_LoadSigned;
        private Label label4;
        private Button btn_Verify;
        private Button btn_LoadCert2;
        private Button btn_LoadPubKey;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label6;
        private Button btn_LoadOriginal;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
        private OpenFileDialog openFileDialog5;
        private OpenFileDialog openFileDialog6;
        private OpenFileDialog openFileDialog7;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
        private Button btn_SignFile;
        private TextBox cert_pass;
    }
}