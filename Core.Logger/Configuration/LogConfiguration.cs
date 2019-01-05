using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Core.Log.Configuration
{
    public class LogConfiguration
    {
        public static LogConfiguration Configuration
        {
            get
            {
                return new LogConfiguration();
            }
        }

        public string PlainTextFileFormat
        {
            get
            {
                return "LOG_{0:yyyy_MM_dd_HH_mm_ss_fff}.txt";
            }
            
        }
        public string SecurityExceptionMessage
        {
            get
            {
                return "Security Failure";
            }
        }

        public string Source
        {
            get
            {
                return "Any Source";
            }
        }
        public string SystemExceptionMessage
        {
            get
            {
                return "System Exception";
            }
        }
        public string UserWindowSource
        {
            get
            {
                return "Vivos.Information";
            }
        }

        public string XmlFileFormat
        {
            get
            {
                return "LOG_{0:yyyy_MM_dd_HH_mm_ss_fff}.svclog";
            }
        }
    }
}
