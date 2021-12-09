using System;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tbAnyFolders.Text = Properties.Settings.Default.anyFolders;
            chkboxWindowsFolder.Checked = Properties.Settings.Default.chkbWindows;
            chkboxRecycleFolder.Checked = Properties.Settings.Default.chkbRecycle;
            chkboxTempFolder.Checked = Properties.Settings.Default.chkbTemp;
            chkboxProgramFolder.Checked = Properties.Settings.Default.chkbProgram;
            chkboxProgram86Folder.Checked = Properties.Settings.Default.chkbProgram86;
            chkbox123.Checked = Properties.Settings.Default.chkb123;

            chkboxDoc.Checked = Properties.Settings.Default.chkbDoc;
            chkboxDocx.Checked = Properties.Settings.Default.chkbDocx;
            chkboxDocm.Checked = Properties.Settings.Default.chkbDocm;
            chkboxRtf.Checked = Properties.Settings.Default.chkbRtf;

            chkboxXls.Checked = Properties.Settings.Default.chkbXls;
            chkboxXlsx.Checked = Properties.Settings.Default.chkbXlsx;
            chkboxXlsm.Checked = Properties.Settings.Default.chkbXlsm;
            chkboxXlsb.Checked = Properties.Settings.Default.chkbXlsb;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.anyFolders = tbAnyFolders.Text;
            Properties.Settings.Default.chkbWindows = (chkboxWindowsFolder.Checked);
            Properties.Settings.Default.chkbRecycle = (chkboxRecycleFolder.Checked);
            Properties.Settings.Default.chkbTemp = (chkboxTempFolder.Checked);
            Properties.Settings.Default.chkbProgram = (chkboxProgramFolder.Checked);
            Properties.Settings.Default.chkbProgram86 = (chkboxProgram86Folder.Checked);
            Properties.Settings.Default.chkb123 = (chkbox123.Checked);

            Properties.Settings.Default.chkbDoc = (chkboxDoc.Checked);
            Properties.Settings.Default.chkbDocx = (chkboxDocx.Checked);
            Properties.Settings.Default.chkbDocm = (chkboxDocm.Checked);
            Properties.Settings.Default.chkbRtf = (chkboxRtf.Checked);

            Properties.Settings.Default.chkbXls = (chkboxXls.Checked);
            Properties.Settings.Default.chkbXlsx = (chkboxXlsx.Checked);
            Properties.Settings.Default.chkbXlsm = (chkboxXlsm.Checked);
            Properties.Settings.Default.chkbXlsb = (chkboxXlsb.Checked);

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            chkboxWindowsFolder.Checked = true;
            chkboxRecycleFolder.Checked = true;
            chkboxTempFolder.Checked = true;
            chkboxProgramFolder.Checked = true;
            chkboxProgram86Folder.Checked = true;
            tbAnyFolders.Text = string.Empty;
            chkbox123.Checked = !chkbox123.Checked;

            chkboxDoc.Checked = false;
            chkboxDocx.Checked = false;
            chkboxDocm.Checked = false;
            chkboxRtf.Checked = false;

            chkboxXls.Checked = false;
            chkboxXlsx.Checked = false;
            chkboxXlsm.Checked = false;
            chkboxXlsb.Checked = false;
        }
    }
}
