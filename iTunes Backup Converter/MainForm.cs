using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTunes_Backup_Converter
{
    public partial class MainForm : Form
    {

        string currentVersion = "Unknown";
        string backupDefault = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Apple Computer/MobileSync/Backup/";
        List<iOS> iOSVersionsList = new List<iOS>();

        public MainForm()
        {
            InitializeComponent();
            loadBackups(backupDefault);
        }

        private void backUpSelect_CheckedChanged(object sender, EventArgs e)
        {
            fixAll();
        }

        private void fixAll()
        {
            dudBackupName.Enabled = rbtnSelectFromList.Checked;
            txbSelectedPath.Enabled = btnSelectPath.Enabled = rbtnManualSelect.Checked;

            lbCurrent.Text = "Current version: " + currentVersion;
            dudNewVersion.Enabled = currentVersion != "Unknown";


        }

        private List<Backup> loadBackups(string path)
        {
            List<Backup> result = new List<Backup>();
            foreach (string folder in Directory.GetDirectories(path))
            {
                result.Add(new Backup(folder));
            }
            return result;
        }

        private void loadiOSDatabase()
        {

        }
    }
}
