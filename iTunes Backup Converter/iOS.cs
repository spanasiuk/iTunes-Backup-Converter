using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunes_Backup_Converter
{
    public class iOS
    {
        public string name;
        public string version;
        public string buildNumber;

        public override string ToString()
        {
            return name;
        }
    }
}
