using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.Utils
{
    public class Logger
    {
        public static ILog log;
        public static void init()
        {
            string logConfigFilePath = AppDomain.CurrentDomain.BaseDirectory + "resources\\log4net.config";
            FileInfo fileInfo = new FileInfo(logConfigFilePath);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(fileInfo);
            log = LogManager.GetLogger("CSFPOSWare");
        }
    }
}
