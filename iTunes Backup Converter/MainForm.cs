using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTunes_Backup_Converter
{
    public partial class MainForm : Form
    {
        string databaseUrl = @"https://en.wikipedia.org/wiki/IOS_version_history";
        string currentVersion = "Unknown";
        string backupDefault = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Apple Computer/MobileSync/Backup/";
        public static List<iOS> iOSVersionsList = new List<iOS>();
        FolderBrowserDialog fbdSelectBackup = new FolderBrowserDialog();

        public MainForm()
        {
            InitializeComponent();
            loadiOSDatabase();
            cbBackupName.DataSource = loadBackups(backupDefault);
            if (cbBackupName.Items.Count > 0)
            {
                currentVersion = ((Backup)cbBackupName.SelectedItem).ios.name;
                lbCurrent.Tag = cbBackupName.SelectedItem;
                cbBackupName.SelectedIndex = 0;
                fixAll();
            }
            else
            {
                MessageBox.Show("No backups were found in \"" + backupDefault + "\"", "Error");
                rbtnSelectFromList.Enabled = false;
                rbtnManualSelect.Checked = true;
            }
        }

        private void backUpSelect_CheckedChanged(object sender, EventArgs e)
        {
            fixAll();
        }

        private void fixAll()
        {
            cbBackupName.Enabled = rbtnSelectFromList.Checked;
            txbSelectedPath.Enabled = btnSelectPath.Enabled = rbtnManualSelect.Checked;

            lbCurrent.Text = "Current version: " + currentVersion;
            cbNewVersion.Enabled = currentVersion != "Unknown";

            btnConvert.Enabled = (((rbtnManualSelect.Checked && txbSelectedPath.Text != "") || (rbtnSelectFromList.Checked && cbBackupName.SelectedIndex >= 0)) && cbNewVersion.SelectedIndex >= 0);
        }

        private List<Backup> loadBackups(string path)
        {
            List<Backup> result = new List<Backup>();
            foreach (string folder in Directory.GetDirectories(path))
            {
                try
                {
                    result.Add(new Backup(folder));
                }
                catch { }
            }
            return result;
        }

        private void loadiOSDatabase()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(databaseUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string html = readStream.ReadToEnd();

                response.Close();
                readStream.Close();

                MatchCollection rawData = Regex.Matches(html, "<tr valign=\"top\"\\s*(..+?)\\s</td>", RegexOptions.Singleline);
                foreach (Match m in rawData)
                {
                    iOS ios = new iOS();
                    string raw = "";
                    int index = 0;
                    try
                    {
                        raw = Regex.Matches(m.ToString(), "<th style=(.+?)</th>", RegexOptions.Singleline)[0].ToString();
                    }
                    catch
                    {
                        raw = Regex.Matches(m.ToString(), "style=(.+?)</th>", RegexOptions.Singleline)[0].ToString();
                    }
                    while (true)
                    {
                        raw = raw.Replace("</th>", "").Replace("\n", "").Replace("<sup", "");
                        if (raw[0] != '>')
                        {
                            raw = raw.Remove(0, 1);
                        }
                        else
                        {
                            raw = raw.Remove(0, 1);
                            index = raw.IndexOf("id=");
                            if (index > 0)
                                raw = raw.Substring(0, index);
                            ios.name = raw;
                            index = raw.IndexOf(" ");
                            if (index > 0)
                                raw = raw.Substring(0, index);
                            ios.version = raw;
                            break;
                        }
                    }
                    raw = Regex.Matches(m.ToString(), "<td>(.+?)</td>", RegexOptions.Singleline)[0].ToString();

                    index = raw.IndexOf(">");
                    if (index > 0)
                    {
                        raw = raw.Substring(index + 1, raw.Length - index - 1);
                        index = 0;
                        foreach (char c in raw)
                        {
                            if (c == ' ' || c == '\n' || c == '<')
                            {
                                raw = raw.Substring(0, index);
                                break;
                            }
                            index++;
                        }
                    }
                    ios.buildNumber = raw;
                    iOSVersionsList.Add(ios);
                }
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (fbdSelectBackup.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Backup bp = new Backup(fbdSelectBackup.SelectedPath);
                    if (bp.name != null)
                    {
                        txbSelectedPath.Text = fbdSelectBackup.SelectedPath;
                        txbSelectedPath.Tag = bp;
                        currentVersion = bp.ios.name;
                        lbCurrent.Tag = bp;
                        fixAll();
                    }
                }
                catch (Exception q)
                {
                    MessageBox.Show(q.Message, "Error");
                }
            }
        }

        private void cbBackupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBackupName.SelectedItem != null)
            {
                currentVersion = ((Backup)cbBackupName.SelectedItem).ios.name;
                lbCurrent.Tag = cbBackupName.SelectedItem;
                cbNewVersion.Items.Clear();
                for (int i = 0; i < iOSVersionsList.FindIndex(s => s.version == ((Backup)lbCurrent.Tag).ios.version); i++)
                {
                    cbNewVersion.Items.Insert(0, iOSVersionsList[i]);
                    if (cbNewVersion.Items.Count > 0)
                    {
                        cbNewVersion.SelectedIndex = 0;
                    }
                }
            }
            fixAll();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                ((Backup)lbCurrent.Tag).changeiOSto(((iOS)cbNewVersion.SelectedItem), cbxBackup.Checked, cbxArchive.Checked);
                MessageBox.Show("Convertion complete!\nNow you can restore your device from this backup!", "Success");
            }
            catch(Exception q)
            {
                MessageBox.Show(q.Message, "Error");
            }
            reload();
        }

        private void reload()
        {
            cbBackupName.DataSource = null;
            cbBackupName.DataSource = loadBackups(backupDefault);
            if (cbBackupName.Items.Count > 0)
            {
                currentVersion = ((Backup)cbBackupName.SelectedItem).ios.name;
                lbCurrent.Tag = cbBackupName.SelectedItem;
                cbBackupName.SelectedIndex = 0;
                fixAll();
            }
            else
            {
                rbtnSelectFromList.Enabled = false;
                rbtnManualSelect.Checked = true;
            }
        }
    }
}
