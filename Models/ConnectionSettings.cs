namespace NevaNetCore.Models
{
    public class ConnectionSettings
    {
        public String LIBFPTR_SETTING_PORT { get; set; }
        public String LIBFPTR_SETTING_BAUDRATE { get; set; }
        public String LIBFPTR_SETTING_BITS { get; set; }
        public String LIBFPTR_SETTING_SB { get; set; }
        public String LIBFPTR_SETTING_PARITY { get; set; }
        public String LIBFPTR_SETTING_COM_FILE { get; set; }

        public String LIBFPTR_SETTING_IPADDRESS { get; set; }

        public String Connection_status { get; set; }

        public String Version_driver { get; set; }
        public ConnectionSettings()
        {
            LIBFPTR_SETTING_PORT = "LIBFPTR_PORT_COM";
            LIBFPTR_SETTING_BAUDRATE = "LIBFPTR_PORT_BR_115200";
            LIBFPTR_SETTING_BITS = "LIBFPTR_SETTING_BITS_7";
            LIBFPTR_SETTING_SB = "LIBFPTR_SETTING_SB_1";
            LIBFPTR_SETTING_PARITY = "LIBFPTR_SETTING_PARITY_NO";
            LIBFPTR_SETTING_COM_FILE = "COM1";
            LIBFPTR_SETTING_IPADDRESS = "192.168.1.10";
            Connection_status = " ";
            Version_driver = " ";
        }
    }
}
//public String LIBFPTR_SETTING_PORT = "LIBFPTR_PORT_COM";
//public String LIBFPTR_SETTING_BAUDRATE = "LIBFPTR_PORT_BR_115200";
//public String LIBFPTR_SETTING_BITS = "LIBFPTR_SETTING_BITS_7";
//public String LIBFPTR_SETTING_SB = "LIBFPTR_SETTING_SB_1";
//public String LIBFPTR_SETTING_PARITY = "LIBFPTR_SETTING_PARITY_NO";
//public String LIBFPTR_SETTING_COM_FILE = "COM1";
//public String LIBFPTR_SETTING_IPADDRESS = "192.168.1.10";
