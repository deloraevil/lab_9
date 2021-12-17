using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using core;

namespace odintsov
{
    class OdintsovLog: LogAbstract, LogInterface
    {
        public List<string> memory = new List<string>();
        private OdintsovLog() { }

        private static OdintsovLog odintsovLog = null;
        public static OdintsovLog I()
        {
            if (odintsovLog == null)
            {
                odintsovLog = new OdintsovLog();
            }

            return odintsovLog;
        }

        public LogInterface log(string str)
        {
            memory.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(memory.ToArray());

            string file_name = @"log\" + DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss.ms") + ".log";
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\log");
            string[] output = memory.ToArray();
            using (var sw = new StreamWriter(file_name, true))
            {
                sw.WriteLine(formatLog(output));

            }
            return this;
        }
    }
}
