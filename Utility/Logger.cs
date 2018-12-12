using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
namespace Utility
{
    public class Logger
    {
        private static string _fileName = string.Empty;

        private static string LogFolder
        {
            get
            {
                String folderPath = string.Empty;
                try
                {
                    folderPath = AppDomain.CurrentDomain.BaseDirectory + "\\Log";
                    if (!System.IO.Directory.Exists(folderPath))
                    {
                        System.IO.Directory.CreateDirectory(folderPath);
                    }
                }
                catch
                {
                    folderPath = AppDomain.CurrentDomain.BaseDirectory;
                }

                return folderPath;
            }
        }

        private static string FileName
        {
            get
            {
                if (string.IsNullOrEmpty(_fileName))
                {
                    _fileName = LogFolder + "\\Log_";
                    _fileName = _fileName + DateTime.Now.ToString("MM") + "_";
                    _fileName = _fileName + DateTime.Now.ToString("dd") + "_";
                    _fileName = _fileName + DateTime.Now.ToString("yyyy") + "_";
                    _fileName = _fileName + DateTime.Now.ToString("HH") + "_";
                    _fileName = _fileName + DateTime.Now.ToString("mm") + "_";
                    _fileName = _fileName + DateTime.Now.ToString("ss") + ".txt";
                }
                else
                {
                    if (!File.Exists(_fileName))
                    {
                        FileStream file = File.Create(_fileName);
                        file.Close();
                    }
                    else
                    {
                        FileInfo file = new FileInfo(_fileName);
                        if (file.Length > 1048576)
                        {
                            _fileName = string.Empty;
                            return FileName;
                        }
                    }

                    //FileInfo file = new FileInfo(_fileName);
                    //if (file.Length > 1048576)
                    //{
                    //    _fileName = string.Empty;
                    //    return FileName;
                    //}
                }

                return _fileName;
            }
        }


        //const string SinexErrLog = @"Log\ErrLog.txt";
        public static void WriteLog(string message)
        {
            try
            {
                FileInfo file = null;

                string fileName = FileName;

                using (StreamWriter w = File.AppendText(fileName))
                {
                    w.WriteLine(string.Format("{0} - {1} ", DateTime.Now, message));
                    w.WriteLine(string.Format("---------------------------------- "));
                    w.Flush();
                }
            }
            catch (Exception ex)
            {


            }

        }

        public static void WriteErrorLog(string message)
        {
            FileInfo file = null;

            string fileName = FileName;

            using (StreamWriter w = File.AppendText(fileName))
            {                
                w.WriteLine(string.Format(" {0} - Error {1} ", DateTime.Now, message));
                w.WriteLine(string.Format("---------------------------------- "));
                w.Flush();
            }
        }


    }
}
