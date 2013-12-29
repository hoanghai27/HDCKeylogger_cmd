using HDCKeylogger.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace HDCKeylogger
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khi nhấn nút open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                XmlReader xmlFile;
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string sSecretKey;

                    // Lấy khóa
                    sSecretKey = GetKey(filePath);
                    GCHandle gch = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned);
                    if (sSecretKey == "")
                    {
                        xmlFile = XmlReader.Create(filePath, new XmlReaderSettings());
                        ds.ReadXml(xmlFile);
                        dgvData.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Giải mã file
                        DES.DecryptFile(filePath,
                                        filePath + "_decrypted",
                                        sSecretKey);
                        xmlFile = XmlReader.Create(filePath + "_decrypted", new XmlReaderSettings());

                        ds.ReadXml(xmlFile);
                        dgvData.DataSource = ds.Tables[0];
                        xmlFile.Close();
                        // Xóa bỏ file đã giải mã đi
                        File.Delete(filePath + "_decrypted");
                    }

                    
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi mở file này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tìm key mã hóa trong file xml
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private string GetKey(string filePath)
        {
            try
            {
                string folder = Directory.GetParent(filePath).FullName;
                string filename = Path.GetFileName(filePath);
                XmlDocument xml = new XmlDocument();
                xml.Load(folder + "\\keys.xml");
                XmlNode node = xml.SelectSingleNode("//key[@file='" + filename + "']");
                return node.InnerText;
            }
            catch
            {
                return "";
            }
        }
    }
}
