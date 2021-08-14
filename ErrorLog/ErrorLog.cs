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
    public partial class ErrorLog : Form
    {
        public ErrorLog()
        {
            InitializeComponent();
        }

        private void ErrorLog_Load(object sender, EventArgs e)
        {
            LoadLog();

            tbLog.DeselectAll();
        }

        private void LoadLog()
        {
            foreach (var item in ErrorLogMethods.ErrorList)
            {
                tbLog.Text += item + "\r\n";
            }
        }
    }
}
