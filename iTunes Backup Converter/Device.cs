using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunes_Backup_Converter
{
    public class Device
    {
        public string deviceName;
        public string deviceType;
        public string deviceVersion;

        public override string ToString()
        {
            return deviceName;
        }
    }
}
