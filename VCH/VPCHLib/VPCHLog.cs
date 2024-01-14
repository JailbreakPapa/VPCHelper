/*
 *   Copyright (c) 2023-present Mikael K. Aboagye
 *   All rights reserved.
 *   This open-source project is covered by the MIT License. See the LICENSE file for more details.
 */

using System.Text;

namespace VPCHLib
{
    public class VPCHLog
    {
        public static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private string logfilename = "vpchlog.txt";

        private bool createfileonsuccess = false;

        private FileStream vpch_logstream;

        public VPCHLog(string logfilename, bool CreateFileOnSuccess = false)
        {
            this.logfilename = logfilename;
            this.createfileonsuccess = CreateFileOnSuccess;
            if (CreateLogFile() != true)
            {
                Console.WriteLine("VPCHLog: Failed to create a log file. VCH will not create a log file for debugging.");
            }
        }

        private bool CreateLogFile()
        {
            vpch_logstream = new FileStream(logfilename, FileMode.OpenOrCreate);
            if (vpch_logstream.CanRead || vpch_logstream != null)
                return true;
            return false;
        }

        public void WriteLineToLog(string line)
        {
            AddText(vpch_logstream, line);
        }
    }
}