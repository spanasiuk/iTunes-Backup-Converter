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
        public string date;

        public Backup(string path)
        {
            if (File.Exists(path + "/Info.plist"))
            {
                PList backup = new PList(path + "/Info.plist");
                name = new DirectoryInfo(path).Name;
                this.path = path;
                date = backup.First(s => s.Key == "Last Backup Date").Value;
                ios.name = "";
                ios.buildNumber = "Build Version";
                ios.version = "Product Version";
                device.deviceName = "Device Name";
                device.deviceType = "Product Name";
                device.deviceVersion = "Product Type";
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
