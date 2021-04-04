using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            chkboxDoc.Checked = Properties.Settings.Default.chkbDoc;
            chkboxDocx.Checked = Properties.Settings.Default.chkbDocx;
            chkboxRtf.Checked = Properties.Settings.Default.chkbRtf;

            if (Properties.Settings.Default.rbtnOptimizationSpeed) rbtnSpeed.Checked = true;
            else rbtnSaveResources.Checked = true;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.anyFolders = tbAnyFolders.Text;
            Properties.Settings.Default.chkbWindows = (chkboxWindowsFolder.Checked);
            Properties.Settings.Default.chkbRecycle = (chkboxRecycleFolder.Checked);
            Properties.Settings.Default.chkbTemp = (chkboxTempFolder.Checked);
            Properties.Settings.Default.chkbProgram = (chkboxProgramFolder.Checked);
            Properties.Settings.Default.chkbProgram86 = (chkboxProgram86Folder.Checked);

            Properties.Settings.Default.chkbDoc = (chkboxDoc.Checked);
            Properties.Settings.Default.chkbDocx = (chkboxDocx.Checked);
            Properties.Settings.Default.chkbRtf = (chkboxRtf.Checked);

            Properties.Settings.Default.rbtnOptimizationSpeed = (rbtnSpeed.Checked);

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

            chkboxDoc.Checked = false;
            chkboxDocx.Checked = false;
            chkboxRtf.Checked = false;

            rbtnSpeed.Checked = true;
        }

        private void Settings__MouseHover(object sender, EventArgs e)
        {
            if ((sender as GroupBox)?.Name == "gboxOptimization")
            {
                ttSettings.SetToolTip(gboxOptimization, "Скорость: Значительно ускоряет поиск, но может потреблять много ОЗУ\r\n" +
                    "Ресурсы: Потребляет мало ОЗУ, но уходит очень много времени на поиск в файле");
            }
            if ((sender as RadioButton)?.Name == "rbtnSpeed")
            {
                ttSettings.SetToolTip(rbtnSpeed, "Значительно ускоряет поиск, но может потреблять много ОЗУ");
            }
            if ((sender as RadioButton)?.Name == "rbtnSaveResources")
            {
                ttSettings.SetToolTip(rbtnSaveResources, "Потребляет мало ОЗУ, но уходит очень много времени на поиск в файле");
            }
        }
    }
}
