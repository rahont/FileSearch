
namespace FileSearch
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gboxFolders = new System.Windows.Forms.GroupBox();
            this.chkbox123 = new System.Windows.Forms.CheckBox();
            this.chkboxProgram86Folder = new System.Windows.Forms.CheckBox();
            this.chkboxProgramFolder = new System.Windows.Forms.CheckBox();
            this.chkboxTempFolder = new System.Windows.Forms.CheckBox();
            this.chkboxRecycleFolder = new System.Windows.Forms.CheckBox();
            this.chkboxWindowsFolder = new System.Windows.Forms.CheckBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.gboxFiles = new System.Windows.Forms.GroupBox();
            this.chkboxXlsm = new System.Windows.Forms.CheckBox();
            this.chkboxXlsb = new System.Windows.Forms.CheckBox();
            this.chkboxXlsx = new System.Windows.Forms.CheckBox();
            this.chkboxXls = new System.Windows.Forms.CheckBox();
            this.chkboxDocm = new System.Windows.Forms.CheckBox();
            this.chkboxRtf = new System.Windows.Forms.CheckBox();
            this.chkboxDocx = new System.Windows.Forms.CheckBox();
            this.chkboxDoc = new System.Windows.Forms.CheckBox();
            this.ttSettings = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAnyFolders = new ALLinONE.MyTextBox();
            this.gboxFolders.SuspendLayout();
            this.gboxFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxFolders
            // 
            this.gboxFolders.Controls.Add(this.chkbox123);
            this.gboxFolders.Controls.Add(this.chkboxProgram86Folder);
            this.gboxFolders.Controls.Add(this.chkboxProgramFolder);
            this.gboxFolders.Controls.Add(this.tbAnyFolders);
            this.gboxFolders.Controls.Add(this.chkboxTempFolder);
            this.gboxFolders.Controls.Add(this.chkboxRecycleFolder);
            this.gboxFolders.Controls.Add(this.chkboxWindowsFolder);
            this.gboxFolders.Location = new System.Drawing.Point(12, 12);
            this.gboxFolders.Name = "gboxFolders";
            this.gboxFolders.Size = new System.Drawing.Size(230, 116);
            this.gboxFolders.TabIndex = 0;
            this.gboxFolders.TabStop = false;
            this.gboxFolders.Text = "Исключить из поиска папки:";
            // 
            // chkbox123
            // 
            this.chkbox123.AutoSize = true;
            this.chkbox123.Enabled = false;
            this.chkbox123.Location = new System.Drawing.Point(94, 65);
            this.chkbox123.Name = "chkbox123";
            this.chkbox123.Size = new System.Drawing.Size(107, 17);
            this.chkbox123.TabIndex = 6;
            this.chkbox123.Text = "А что тут будет?";
            this.chkbox123.UseVisualStyleBackColor = true;
            // 
            // chkboxProgram86Folder
            // 
            this.chkboxProgram86Folder.AutoSize = true;
            this.chkboxProgram86Folder.Checked = true;
            this.chkboxProgram86Folder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxProgram86Folder.Location = new System.Drawing.Point(94, 42);
            this.chkboxProgram86Folder.Name = "chkboxProgram86Folder";
            this.chkboxProgram86Folder.Size = new System.Drawing.Size(115, 17);
            this.chkboxProgram86Folder.TabIndex = 4;
            this.chkboxProgram86Folder.Text = "Program Files (x86)";
            this.chkboxProgram86Folder.UseVisualStyleBackColor = true;
            // 
            // chkboxProgramFolder
            // 
            this.chkboxProgramFolder.AutoSize = true;
            this.chkboxProgramFolder.Checked = true;
            this.chkboxProgramFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxProgramFolder.Location = new System.Drawing.Point(94, 19);
            this.chkboxProgramFolder.Name = "chkboxProgramFolder";
            this.chkboxProgramFolder.Size = new System.Drawing.Size(89, 17);
            this.chkboxProgramFolder.TabIndex = 3;
            this.chkboxProgramFolder.Text = "Program Files";
            this.chkboxProgramFolder.UseVisualStyleBackColor = true;
            // 
            // chkboxTempFolder
            // 
            this.chkboxTempFolder.AutoSize = true;
            this.chkboxTempFolder.Checked = true;
            this.chkboxTempFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxTempFolder.Location = new System.Drawing.Point(6, 65);
            this.chkboxTempFolder.Name = "chkboxTempFolder";
            this.chkboxTempFolder.Size = new System.Drawing.Size(63, 17);
            this.chkboxTempFolder.TabIndex = 2;
            this.chkboxTempFolder.Text = "Temp\'ы";
            this.chkboxTempFolder.UseVisualStyleBackColor = true;
            // 
            // chkboxRecycleFolder
            // 
            this.chkboxRecycleFolder.AutoSize = true;
            this.chkboxRecycleFolder.Checked = true;
            this.chkboxRecycleFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxRecycleFolder.Location = new System.Drawing.Point(6, 42);
            this.chkboxRecycleFolder.Name = "chkboxRecycleFolder";
            this.chkboxRecycleFolder.Size = new System.Drawing.Size(69, 17);
            this.chkboxRecycleFolder.TabIndex = 1;
            this.chkboxRecycleFolder.Text = "Корзина";
            this.chkboxRecycleFolder.UseVisualStyleBackColor = true;
            // 
            // chkboxWindowsFolder
            // 
            this.chkboxWindowsFolder.AutoSize = true;
            this.chkboxWindowsFolder.Checked = true;
            this.chkboxWindowsFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxWindowsFolder.Location = new System.Drawing.Point(6, 19);
            this.chkboxWindowsFolder.Name = "chkboxWindowsFolder";
            this.chkboxWindowsFolder.Size = new System.Drawing.Size(70, 17);
            this.chkboxWindowsFolder.TabIndex = 0;
            this.chkboxWindowsFolder.Text = "Windows";
            this.chkboxWindowsFolder.UseVisualStyleBackColor = true;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAll.Location = new System.Drawing.Point(113, 202);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(130, 23);
            this.btnSaveAll.TabIndex = 3;
            this.btnSaveAll.Text = "Сохранить и закрыть";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefault.Location = new System.Drawing.Point(11, 202);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(96, 23);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "По умолчанию";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // gboxFiles
            // 
            this.gboxFiles.Controls.Add(this.chkboxXlsm);
            this.gboxFiles.Controls.Add(this.chkboxXlsb);
            this.gboxFiles.Controls.Add(this.chkboxXlsx);
            this.gboxFiles.Controls.Add(this.chkboxXls);
            this.gboxFiles.Controls.Add(this.chkboxDocm);
            this.gboxFiles.Controls.Add(this.chkboxRtf);
            this.gboxFiles.Controls.Add(this.chkboxDocx);
            this.gboxFiles.Controls.Add(this.chkboxDoc);
            this.gboxFiles.Location = new System.Drawing.Point(12, 134);
            this.gboxFiles.Name = "gboxFiles";
            this.gboxFiles.Size = new System.Drawing.Size(230, 62);
            this.gboxFiles.TabIndex = 1;
            this.gboxFiles.TabStop = false;
            this.gboxFiles.Text = "Не производить поиск в файлах:";
            // 
            // chkboxXlsm
            // 
            this.chkboxXlsm.AutoSize = true;
            this.chkboxXlsm.Location = new System.Drawing.Point(119, 42);
            this.chkboxXlsm.Name = "chkboxXlsm";
            this.chkboxXlsm.Size = new System.Drawing.Size(49, 17);
            this.chkboxXlsm.TabIndex = 7;
            this.chkboxXlsm.Text = ".xlsm";
            this.chkboxXlsm.UseVisualStyleBackColor = true;
            // 
            // chkboxXlsb
            // 
            this.chkboxXlsb.AutoSize = true;
            this.chkboxXlsb.Location = new System.Drawing.Point(180, 42);
            this.chkboxXlsb.Name = "chkboxXlsb";
            this.chkboxXlsb.Size = new System.Drawing.Size(47, 17);
            this.chkboxXlsb.TabIndex = 6;
            this.chkboxXlsb.Text = ".xlsb";
            this.chkboxXlsb.UseVisualStyleBackColor = true;
            // 
            // chkboxXlsx
            // 
            this.chkboxXlsx.AutoSize = true;
            this.chkboxXlsx.Location = new System.Drawing.Point(61, 42);
            this.chkboxXlsx.Name = "chkboxXlsx";
            this.chkboxXlsx.Size = new System.Drawing.Size(46, 17);
            this.chkboxXlsx.TabIndex = 5;
            this.chkboxXlsx.Text = ".xlsx";
            this.chkboxXlsx.UseVisualStyleBackColor = true;
            // 
            // chkboxXls
            // 
            this.chkboxXls.AutoSize = true;
            this.chkboxXls.Location = new System.Drawing.Point(8, 42);
            this.chkboxXls.Name = "chkboxXls";
            this.chkboxXls.Size = new System.Drawing.Size(41, 17);
            this.chkboxXls.TabIndex = 4;
            this.chkboxXls.Text = ".xls";
            this.chkboxXls.UseVisualStyleBackColor = true;
            // 
            // chkboxDocm
            // 
            this.chkboxDocm.AutoSize = true;
            this.chkboxDocm.Location = new System.Drawing.Point(119, 19);
            this.chkboxDocm.Name = "chkboxDocm";
            this.chkboxDocm.Size = new System.Drawing.Size(55, 17);
            this.chkboxDocm.TabIndex = 3;
            this.chkboxDocm.Text = ".docm";
            this.chkboxDocm.UseVisualStyleBackColor = true;
            // 
            // chkboxRtf
            // 
            this.chkboxRtf.AutoSize = true;
            this.chkboxRtf.Location = new System.Drawing.Point(180, 19);
            this.chkboxRtf.Name = "chkboxRtf";
            this.chkboxRtf.Size = new System.Drawing.Size(38, 17);
            this.chkboxRtf.TabIndex = 2;
            this.chkboxRtf.Text = ".rtf";
            this.chkboxRtf.UseVisualStyleBackColor = true;
            // 
            // chkboxDocx
            // 
            this.chkboxDocx.AutoSize = true;
            this.chkboxDocx.Location = new System.Drawing.Point(61, 19);
            this.chkboxDocx.Name = "chkboxDocx";
            this.chkboxDocx.Size = new System.Drawing.Size(52, 17);
            this.chkboxDocx.TabIndex = 1;
            this.chkboxDocx.Text = ".docx";
            this.chkboxDocx.UseVisualStyleBackColor = true;
            // 
            // chkboxDoc
            // 
            this.chkboxDoc.AutoSize = true;
            this.chkboxDoc.Location = new System.Drawing.Point(8, 19);
            this.chkboxDoc.Name = "chkboxDoc";
            this.chkboxDoc.Size = new System.Drawing.Size(47, 17);
            this.chkboxDoc.TabIndex = 0;
            this.chkboxDoc.Text = ".doc";
            this.chkboxDoc.UseVisualStyleBackColor = true;
            // 
            // ttSettings
            // 
            this.ttSettings.AutoPopDelay = 20000;
            this.ttSettings.InitialDelay = 500;
            this.ttSettings.ReshowDelay = 100;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Исключения"});
            this.listBox1.Location = new System.Drawing.Point(344, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 290);
            this.listBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(490, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 290);
            this.panel1.TabIndex = 5;
            // 
            // tbAnyFolders
            // 
            this.tbAnyFolders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbAnyFolders.Location = new System.Drawing.Point(3, 93);
            this.tbAnyFolders.MaximumSize = new System.Drawing.Size(10000, 20);
            this.tbAnyFolders.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAnyFolders.Name = "tbAnyFolders";
            this.tbAnyFolders.PasswordChar = '\0';
            this.tbAnyFolders.Size = new System.Drawing.Size(224, 20);
            this.tbAnyFolders.TabIndex = 5;
            this.tbAnyFolders.TextMaxLength = 1024;
            this.tbAnyFolders.TextTitle = "Доп. папки через ; (точка с запятой)";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 237);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gboxFiles);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.gboxFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(270, 276);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gboxFolders.ResumeLayout(false);
            this.gboxFolders.PerformLayout();
            this.gboxFiles.ResumeLayout(false);
            this.gboxFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxFolders;
        private System.Windows.Forms.CheckBox chkboxTempFolder;
        private System.Windows.Forms.CheckBox chkboxRecycleFolder;
        private System.Windows.Forms.CheckBox chkboxWindowsFolder;
        private ALLinONE.MyTextBox tbAnyFolders;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.CheckBox chkboxProgram86Folder;
        private System.Windows.Forms.CheckBox chkboxProgramFolder;
        private System.Windows.Forms.GroupBox gboxFiles;
        private System.Windows.Forms.CheckBox chkboxRtf;
        private System.Windows.Forms.CheckBox chkboxDocx;
        private System.Windows.Forms.CheckBox chkboxDoc;
        private System.Windows.Forms.ToolTip ttSettings;
        private System.Windows.Forms.CheckBox chkboxDocm;
        private System.Windows.Forms.CheckBox chkbox123;
        private System.Windows.Forms.CheckBox chkboxXlsm;
        private System.Windows.Forms.CheckBox chkboxXlsb;
        private System.Windows.Forms.CheckBox chkboxXlsx;
        private System.Windows.Forms.CheckBox chkboxXls;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
    }
}