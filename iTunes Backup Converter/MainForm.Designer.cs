namespace iTunes_Backup_Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.dudBackupName = new System.Windows.Forms.DomainUpDown();
            this.dudNewVersion = new System.Windows.Forms.DomainUpDown();
            this.lbChangeTo = new System.Windows.Forms.Label();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.txbSelectedPath = new System.Windows.Forms.TextBox();
            this.lbOr = new System.Windows.Forms.Label();
            this.rbtnManualSelect = new System.Windows.Forms.RadioButton();
            this.rbtnSelectFromList = new System.Windows.Forms.RadioButton();
            this.gbVersion = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbAdditional = new System.Windows.Forms.GroupBox();
            this.cbxArchive = new System.Windows.Forms.CheckBox();
            this.cbxBackup = new System.Windows.Forms.CheckBox();
            this.gbSelect.SuspendLayout();
            this.gbVersion.SuspendLayout();
            this.gbAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(270, 75);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(25, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Location = new System.Drawing.Point(18, 20);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(81, 13);
            this.lbCurrent.TabIndex = 3;
            this.lbCurrent.Text = "Current version:";
            // 
            // dudBackupName
            // 
            this.dudBackupName.BackColor = System.Drawing.Color.White;
            this.dudBackupName.Location = new System.Drawing.Point(159, 19);
            this.dudBackupName.Name = "dudBackupName";
            this.dudBackupName.ReadOnly = true;
            this.dudBackupName.Size = new System.Drawing.Size(136, 20);
            this.dudBackupName.TabIndex = 4;
            // 
            // dudNewVersion
            // 
            this.dudNewVersion.BackColor = System.Drawing.Color.White;
            this.dudNewVersion.Location = new System.Drawing.Point(91, 39);
            this.dudNewVersion.Name = "dudNewVersion";
            this.dudNewVersion.ReadOnly = true;
            this.dudNewVersion.Size = new System.Drawing.Size(91, 20);
            this.dudNewVersion.TabIndex = 6;
            // 
            // lbChangeTo
            // 
            this.lbChangeTo.AutoSize = true;
            this.lbChangeTo.Location = new System.Drawing.Point(18, 41);
            this.lbChangeTo.Name = "lbChangeTo";
            this.lbChangeTo.Size = new System.Drawing.Size(67, 13);
            this.lbChangeTo.TabIndex = 7;
            this.lbChangeTo.Text = "Change it to:";
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.txbSelectedPath);
            this.gbSelect.Controls.Add(this.lbOr);
            this.gbSelect.Controls.Add(this.rbtnManualSelect);
            this.gbSelect.Controls.Add(this.rbtnSelectFromList);
            this.gbSelect.Controls.Add(this.btnSelectPath);
            this.gbSelect.Controls.Add(this.dudBackupName);
            this.gbSelect.Location = new System.Drawing.Point(12, 12);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(301, 104);
            this.gbSelect.TabIndex = 8;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select backup";
            // 
            // txbSelectedPath
            // 
            this.txbSelectedPath.BackColor = System.Drawing.Color.White;
            this.txbSelectedPath.Location = new System.Drawing.Point(21, 77);
            this.txbSelectedPath.Name = "txbSelectedPath";
            this.txbSelectedPath.ReadOnly = true;
            this.txbSelectedPath.Size = new System.Drawing.Size(243, 20);
            this.txbSelectedPath.TabIndex = 5;
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Location = new System.Drawing.Point(66, 39);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(40, 13);
            this.lbOr.TabIndex = 2;
            this.lbOr.Text = "----or----";
            // 
            // rbtnManualSelect
            // 
            this.rbtnManualSelect.AutoSize = true;
            this.rbtnManualSelect.Location = new System.Drawing.Point(21, 55);
            this.rbtnManualSelect.Name = "rbtnManualSelect";
            this.rbtnManualSelect.Size = new System.Drawing.Size(137, 17);
            this.rbtnManualSelect.TabIndex = 1;
            this.rbtnManualSelect.TabStop = true;
            this.rbtnManualSelect.Text = "Manually select backup";
            this.rbtnManualSelect.UseVisualStyleBackColor = true;
            this.rbtnManualSelect.CheckedChanged += new System.EventHandler(this.backUpSelect_CheckedChanged);
            // 
            // rbtnSelectFromList
            // 
            this.rbtnSelectFromList.AutoSize = true;
            this.rbtnSelectFromList.Location = new System.Drawing.Point(21, 19);
            this.rbtnSelectFromList.Name = "rbtnSelectFromList";
            this.rbtnSelectFromList.Size = new System.Drawing.Size(132, 17);
            this.rbtnSelectFromList.TabIndex = 0;
            this.rbtnSelectFromList.TabStop = true;
            this.rbtnSelectFromList.Text = "Select backup from list";
            this.rbtnSelectFromList.UseVisualStyleBackColor = true;
            this.rbtnSelectFromList.CheckedChanged += new System.EventHandler(this.backUpSelect_CheckedChanged);
            // 
            // gbVersion
            // 
            this.gbVersion.Controls.Add(this.lbCurrent);
            this.gbVersion.Controls.Add(this.dudNewVersion);
            this.gbVersion.Controls.Add(this.lbChangeTo);
            this.gbVersion.Location = new System.Drawing.Point(12, 122);
            this.gbVersion.Name = "gbVersion";
            this.gbVersion.Size = new System.Drawing.Size(301, 65);
            this.gbVersion.TabIndex = 9;
            this.gbVersion.TabStop = false;
            this.gbVersion.Text = "Backup iOS version";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(125, 262);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // gbAdditional
            // 
            this.gbAdditional.Controls.Add(this.cbxArchive);
            this.gbAdditional.Controls.Add(this.cbxBackup);
            this.gbAdditional.Location = new System.Drawing.Point(12, 193);
            this.gbAdditional.Name = "gbAdditional";
            this.gbAdditional.Size = new System.Drawing.Size(301, 63);
            this.gbAdditional.TabIndex = 11;
            this.gbAdditional.TabStop = false;
            this.gbAdditional.Text = "Additional settings";
            // 
            // cbxArchive
            // 
            this.cbxArchive.AutoSize = true;
            this.cbxArchive.Checked = true;
            this.cbxArchive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxArchive.Location = new System.Drawing.Point(6, 42);
            this.cbxArchive.Name = "cbxArchive";
            this.cbxArchive.Size = new System.Drawing.Size(101, 17);
            this.cbxArchive.TabIndex = 1;
            this.cbxArchive.Text = "Archive backup";
            this.cbxArchive.UseVisualStyleBackColor = true;
            // 
            // cbxBackup
            // 
            this.cbxBackup.AutoSize = true;
            this.cbxBackup.Checked = true;
            this.cbxBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBackup.Location = new System.Drawing.Point(6, 19);
            this.cbxBackup.Name = "cbxBackup";
            this.cbxBackup.Size = new System.Drawing.Size(120, 17);
            this.cbxBackup.TabIndex = 0;
            this.cbxBackup.Text = "Backup original files";
            this.cbxBackup.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 289);
            this.Controls.Add(this.gbAdditional);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbVersion);
            this.Controls.Add(this.gbSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTunes Backup Converter";
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.gbVersion.ResumeLayout(false);
            this.gbVersion.PerformLayout();
            this.gbAdditional.ResumeLayout(false);
            this.gbAdditional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.DomainUpDown dudBackupName;
        private System.Windows.Forms.DomainUpDown dudNewVersion;
        private System.Windows.Forms.Label lbChangeTo;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.TextBox txbSelectedPath;
        private System.Windows.Forms.Label lbOr;
        private System.Windows.Forms.RadioButton rbtnManualSelect;
        private System.Windows.Forms.RadioButton rbtnSelectFromList;
        private System.Windows.Forms.GroupBox gbVersion;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox gbAdditional;
        private System.Windows.Forms.CheckBox cbxArchive;
        private System.Windows.Forms.CheckBox cbxBackup;
    }
}

