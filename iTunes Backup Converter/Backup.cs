using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iTunes_Backup_Converter
{
    public class Backup
    {
        public string name;
        public iOS ios;
        public Device device;
        public string path;
        public DateTime date;

        public Backup(string path)
        {
            if (File.Exists(path + "/Info.plist"))
            {
                PList backup = new PList(path + "/Info.plist");
                ios = new iOS();
                device = new Device();
                name = new DirectoryInfo(path).Name;
                this.path = path;
                date = backup.First(s => s.Key == "Last Backup Date").Value;
                ios.name = "iOS 12.0";
                ios.buildNumber = backup.First(s => s.Key == "Build Version").Value;
                ios.version = backup.First(s => s.Key == "Product Version").Value;
                device.deviceName = backup.First(s => s.Key == "Device Name").Value;
                device.deviceType = backup.First(s => s.Key == "Product Name").Value;
                device.deviceVersion = backup.First(s => s.Key == "Product Type").Value;
                /*XDocument file = XDocument.Load(path + "/Info.plist");
                Console.WriteLine(file.Element("Product Version"));
                foreach (string line in file.Elements())
                {
                    Console.WriteLine(line);
                }*/
            }
        }

        public override string ToString()
        {
            return device + " (" + ios + ") - " + date;
        }
    }
}
