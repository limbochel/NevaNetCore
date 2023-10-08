using System.Drawing;
using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Linq;
using System;

namespace NevaNetCore.Models
{
    public class ConnectionSettings
    {
        public String LIBFPTR_SETTING_MODEL { get; set; }
        public String LIBFPTR_SETTING_PORT { get; set; }
        public String LIBFPTR_SETTING_COM_FILE { get; set; }
        public String LIBFPTR_SETTING_IPADDRESS { get; set; }
        public String LIBFPTR_SETTING_IPPORT {get; set; }
        public String Connection_status { get; set; }

        public String Version_driver { get; set; }
        public ConnectionSettings()
        {
            LIBFPTR_SETTING_MODEL = "LIBFPTR_MODEL_NEVA_AUTO";
            LIBFPTR_SETTING_PORT = "0";
            LIBFPTR_SETTING_COM_FILE = "COM1";
            LIBFPTR_SETTING_IPPORT = "5005";
        LIBFPTR_SETTING_IPADDRESS = "192.168.1.10";
            Connection_status = " - ";
            Version_driver = " ";
        }
    }
}