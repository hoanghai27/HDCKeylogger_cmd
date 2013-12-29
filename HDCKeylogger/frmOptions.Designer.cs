namespace HDCKeylogger
{
    partial class frmOptions
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageFileLog = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPageEmail = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxStartUp = new System.Windows.Forms.CheckBox();
            this.cbxAutoStart = new System.Windows.Forms.CheckBox();
            this.cbxAutoHide = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxAutoLogFile = new System.Windows.Forms.CheckBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogDir = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFileLogTimer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxAutoEmail = new System.Windows.Forms.CheckBox();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSMTPHost = new System.Windows.Forms.TextBox();
            this.nudSMTPPort = new System.Windows.Forms.NumericUpDown();
            this.cbxUseSSL = new System.Windows.Forms.CheckBox();
            this.nudEmailTimer = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEncryptFile = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageFileLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageEmail.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileLogTimer)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSMTPPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageFileLog);
            this.tabControl.Controls.Add(this.tabPageEmail);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(391, 243);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.flowLayoutPanel1);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(383, 217);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Chung";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageFileLog
            // 
            this.tabPageFileLog.Controls.Add(this.flowLayoutPanel2);
            this.tabPageFileLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageFileLog.Name = "tabPageFileLog";
            this.tabPageFileLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFileLog.Size = new System.Drawing.Size(383, 217);
            this.tabPageFileLog.TabIndex = 1;
            this.tabPageFileLog.Text = "Log File";
            this.tabPageFileLog.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabPageEmail
            // 
            this.tabPageEmail.Controls.Add(this.flowLayoutPanel3);
            this.tabPageEmail.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmail.Name = "tabPageEmail";
            this.tabPageEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmail.Size = new System.Drawing.Size(383, 217);
            this.tabPageEmail.TabIndex = 2;
            this.tabPageEmail.Text = "Email";
            this.tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbxStartUp);
            this.flowLayoutPanel1.Controls.Add(this.cbxAutoStart);
            this.flowLayoutPanel1.Controls.Add(this.cbxAutoHide);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 211);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbxStartUp
            // 
            this.cbxStartUp.AutoSize = true;
            this.cbxStartUp.Location = new System.Drawing.Point(13, 13);
            this.cbxStartUp.Name = "cbxStartUp";
            this.cbxStartUp.Size = new System.Drawing.Size(149, 17);
            this.cbxStartUp.TabIndex = 0;
            this.cbxStartUp.Text = "Khởi động cùng Windows";
            this.cbxStartUp.UseVisualStyleBackColor = true;
            // 
            // cbxAutoStart
            // 
            this.cbxAutoStart.AutoSize = true;
            this.cbxAutoStart.Location = new System.Drawing.Point(13, 36);
            this.cbxAutoStart.Name = "cbxAutoStart";
            this.cbxAutoStart.Size = new System.Drawing.Size(93, 17);
            this.cbxAutoStart.TabIndex = 1;
            this.cbxAutoStart.Text = "Tự động chạy";
            this.cbxAutoStart.UseVisualStyleBackColor = true;
            // 
            // cbxAutoHide
            // 
            this.cbxAutoHide.AutoSize = true;
            this.cbxAutoHide.Location = new System.Drawing.Point(13, 59);
            this.cbxAutoHide.Name = "cbxAutoHide";
            this.cbxAutoHide.Size = new System.Drawing.Size(82, 17);
            this.cbxAutoHide.TabIndex = 2;
            this.cbxAutoHide.Text = "Tự động ẩn";
            this.cbxAutoHide.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cbxAutoLogFile);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxFile);
            this.flowLayoutPanel2.Controls.Add(this.cbxEncryptFile);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(377, 211);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // cbxAutoLogFile
            // 
            this.cbxAutoLogFile.AutoSize = true;
            this.cbxAutoLogFile.Location = new System.Drawing.Point(13, 13);
            this.cbxAutoLogFile.Name = "cbxAutoLogFile";
            this.cbxAutoLogFile.Size = new System.Drawing.Size(138, 17);
            this.cbxAutoLogFile.TabIndex = 0;
            this.cbxAutoLogFile.Text = "Tự động ghi vào file log";
            this.cbxAutoLogFile.UseVisualStyleBackColor = true;
            this.cbxAutoLogFile.CheckedChanged += new System.EventHandler(this.cbxAutoLogFile_CheckedChanged);
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.label3);
            this.groupBoxFile.Controls.Add(this.nudFileLogTimer);
            this.groupBoxFile.Controls.Add(this.label2);
            this.groupBoxFile.Controls.Add(this.btnSelectFolder);
            this.groupBoxFile.Controls.Add(this.txtLogDir);
            this.groupBoxFile.Controls.Add(this.label1);
            this.groupBoxFile.Location = new System.Drawing.Point(13, 36);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(351, 80);
            this.groupBoxFile.TabIndex = 1;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục chứa file";
            // 
            // txtLogDir
            // 
            this.txtLogDir.Location = new System.Drawing.Point(124, 17);
            this.txtLogDir.Name = "txtLogDir";
            this.txtLogDir.Size = new System.Drawing.Size(190, 20);
            this.txtLogDir.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(320, 15);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(26, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian tự động lưu";
            // 
            // nudFileLogTimer
            // 
            this.nudFileLogTimer.Location = new System.Drawing.Point(124, 44);
            this.nudFileLogTimer.Name = "nudFileLogTimer";
            this.nudFileLogTimer.Size = new System.Drawing.Size(53, 20);
            this.nudFileLogTimer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "phút";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cbxAutoEmail);
            this.flowLayoutPanel3.Controls.Add(this.groupBoxEmail);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(377, 211);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // cbxAutoEmail
            // 
            this.cbxAutoEmail.AutoSize = true;
            this.cbxAutoEmail.Location = new System.Drawing.Point(13, 13);
            this.cbxAutoEmail.Name = "cbxAutoEmail";
            this.cbxAutoEmail.Size = new System.Drawing.Size(111, 17);
            this.cbxAutoEmail.TabIndex = 0;
            this.cbxAutoEmail.Text = "Tự động gửi email";
            this.cbxAutoEmail.UseVisualStyleBackColor = true;
            this.cbxAutoEmail.CheckedChanged += new System.EventHandler(this.cbxAutoEmail_CheckedChanged);
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.label9);
            this.groupBoxEmail.Controls.Add(this.nudEmailTimer);
            this.groupBoxEmail.Controls.Add(this.cbxUseSSL);
            this.groupBoxEmail.Controls.Add(this.nudSMTPPort);
            this.groupBoxEmail.Controls.Add(this.txtSMTPHost);
            this.groupBoxEmail.Controls.Add(this.txtPassword);
            this.groupBoxEmail.Controls.Add(this.txtEmailAddress);
            this.groupBoxEmail.Controls.Add(this.label8);
            this.groupBoxEmail.Controls.Add(this.label7);
            this.groupBoxEmail.Controls.Add(this.label6);
            this.groupBoxEmail.Controls.Add(this.label5);
            this.groupBoxEmail.Controls.Add(this.label4);
            this.groupBoxEmail.Location = new System.Drawing.Point(13, 36);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(347, 159);
            this.groupBoxEmail.TabIndex = 1;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Cấu hình email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Máy chủ SMTP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cổng SMTP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tự động gửi sau";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(109, 17);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(232, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtSMTPHost
            // 
            this.txtSMTPHost.Location = new System.Drawing.Point(109, 69);
            this.txtSMTPHost.Name = "txtSMTPHost";
            this.txtSMTPHost.Size = new System.Drawing.Size(232, 20);
            this.txtSMTPHost.TabIndex = 9;
            // 
            // nudSMTPPort
            // 
            this.nudSMTPPort.Location = new System.Drawing.Point(109, 95);
            this.nudSMTPPort.Name = "nudSMTPPort";
            this.nudSMTPPort.Size = new System.Drawing.Size(92, 20);
            this.nudSMTPPort.TabIndex = 10;
            // 
            // cbxUseSSL
            // 
            this.cbxUseSSL.AutoSize = true;
            this.cbxUseSSL.Location = new System.Drawing.Point(207, 96);
            this.cbxUseSSL.Name = "cbxUseSSL";
            this.cbxUseSSL.Size = new System.Drawing.Size(45, 17);
            this.cbxUseSSL.TabIndex = 11;
            this.cbxUseSSL.Text = "SLL";
            this.cbxUseSSL.UseVisualStyleBackColor = true;
            // 
            // nudEmailTimer
            // 
            this.nudEmailTimer.Location = new System.Drawing.Point(109, 121);
            this.nudEmailTimer.Name = "nudEmailTimer";
            this.nudEmailTimer.Size = new System.Drawing.Size(92, 20);
            this.nudEmailTimer.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "phút";
            // 
            // cbxEncryptFile
            // 
            this.cbxEncryptFile.AutoSize = true;
            this.cbxEncryptFile.Location = new System.Drawing.Point(13, 122);
            this.cbxEncryptFile.Name = "cbxEncryptFile";
            this.cbxEncryptFile.Size = new System.Drawing.Size(78, 17);
            this.cbxEncryptFile.TabIndex = 2;
            this.cbxEncryptFile.Text = "Mã hóa file";
            this.cbxEncryptFile.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(391, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageFileLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageEmail.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileLogTimer)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSMTPPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbxStartUp;
        private System.Windows.Forms.CheckBox cbxAutoStart;
        private System.Windows.Forms.CheckBox cbxAutoHide;
        private System.Windows.Forms.TabPage tabPageFileLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox cbxAutoLogFile;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.TextBox txtLogDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFileLogTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox cbxAutoEmail;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudEmailTimer;
        private System.Windows.Forms.CheckBox cbxUseSSL;
        private System.Windows.Forms.NumericUpDown nudSMTPPort;
        private System.Windows.Forms.TextBox txtSMTPHost;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxEncryptFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}