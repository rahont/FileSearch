
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gboxFolders = new System.Windows.Forms.GroupBox();
            this.chkboxTempFolder = new System.Windows.Forms.CheckBox();
            this.chkboxRecycleFolder = new System.Windows.Forms.CheckBox();
            this.chkboxWindowsFolder = new System.Windows.Forms.CheckBox();
            this.tbAnyFolders = new ALLinONE.MyTextBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.chkboxProgramFolder = new System.Windows.Forms.CheckBox();
            this.chkboxProgram86Folder = new System.Windows.Forms.CheckBox();
            this.gboxFiles = new System.Windows.Forms.GroupBox();
            this.chkboxDoc = new System.Windows.Forms.CheckBox();
            this.chkboxDocx = new System.Windows.Forms.CheckBox();
            this.chkboxRtf = new System.Windows.Forms.CheckBox();
            this.gboxFolders.SuspendLayout();
            this.gboxFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxFolders
            // 
            this.gboxFolders.Controls.Add(this.chkboxProgram86Folder);
            this.gboxFolders.Controls.Add(this.chkboxProgramFolder);
            this.gboxFolders.Controls.Add(this.tbAnyFolders);
            this.gboxFolders.Controls.Add(this.chkboxTempFolder);
            this.gboxFolders.Controls.Add(this.chkboxRecycleFolder);
            this.gboxFolders.Controls.Add(this.chkboxWindowsFolder);
            this.gboxFolders.Location = new System.Drawing.Point(12, 12);
            this.gboxFolders.Name = "gboxFolders";
            this.gboxFolders.Size = new System.Drawing.Size(217, 116);
            this.gboxFolders.TabIndex = 0;
            this.gboxFolders.TabStop = false;
            this.gboxFolders.Text = "Исключить из поиска папки:";
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
            this.chkboxTempFolder.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
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
            this.chkboxRecycleFolder.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
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
            this.chkboxWindowsFolder.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // tbAnyFolders
            // 
            this.tbAnyFolders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbAnyFolders.Location = new System.Drawing.Point(3, 93);
            this.tbAnyFolders.MaximumSize = new System.Drawing.Size(10000, 20);
            this.tbAnyFolders.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAnyFolders.Name = "tbAnyFolders";
            this.tbAnyFolders.PasswordChar = '\0';
            this.tbAnyFolders.Size = new System.Drawing.Size(211, 20);
            this.tbAnyFolders.TabIndex = 3;
            this.tbAnyFolders.TextMaxLength = 1024;
            this.tbAnyFolders.TextTitle = "Дополнительные папки через ;";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAll.Location = new System.Drawing.Point(106, 183);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(123, 23);
            this.btnSaveAll.TabIndex = 1;
            this.btnSaveAll.Text = "Сохранить и закрыть";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefault.Location = new System.Drawing.Point(12, 183);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(88, 23);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "По умолчанию";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // chkboxProgramFolder
            // 
            this.chkboxProgramFolder.AutoSize = true;
            this.chkboxProgramFolder.Checked = true;
            this.chkboxProgramFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxProgramFolder.Location = new System.Drawing.Point(94, 19);
            this.chkboxProgramFolder.Name = "chkboxProgramFolder";
            this.chkboxProgramFolder.Size = new System.Drawing.Size(89, 17);
            this.chkboxProgramFolder.TabIndex = 4;
            this.chkboxProgramFolder.Text = "Program Files";
            this.chkboxProgramFolder.UseVisualStyleBackColor = true;
            // 
            // chkboxProgram86Folder
            // 
            this.chkboxProgram86Folder.AutoSize = true;
            this.chkboxProgram86Folder.Checked = true;
            this.chkboxProgram86Folder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxProgram86Folder.Location = new System.Drawing.Point(94, 42);
            this.chkboxProgram86Folder.Name = "chkboxProgram86Folder";
            this.chkboxProgram86Folder.Size = new System.Drawing.Size(115, 17);
            this.chkboxProgram86Folder.TabIndex = 5;
            this.chkboxProgram86Folder.Text = "Program Files (x86)";
            this.chkboxProgram86Folder.UseVisualStyleBackColor = true;
            // 
            // gboxFiles
            // 
            this.gboxFiles.Controls.Add(this.chkboxRtf);
            this.gboxFiles.Controls.Add(this.chkboxDocx);
            this.gboxFiles.Controls.Add(this.chkboxDoc);
            this.gboxFiles.Location = new System.Drawing.Point(12, 134);
            this.gboxFiles.Name = "gboxFiles";
            this.gboxFiles.Size = new System.Drawing.Size(217, 42);
            this.gboxFiles.TabIndex = 3;
            this.gboxFiles.TabStop = false;
            this.gboxFiles.Text = "Исключить из поиска файлы:";
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
            // chkboxRtf
            // 
            this.chkboxRtf.AutoSize = true;
            this.chkboxRtf.Location = new System.Drawing.Point(119, 19);
            this.chkboxRtf.Name = "chkboxRtf";
            this.chkboxRtf.Size = new System.Drawing.Size(38, 17);
            this.chkboxRtf.TabIndex = 2;
            this.chkboxRtf.Text = ".rtf";
            this.chkboxRtf.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 218);
            this.Controls.Add(this.gboxFiles);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.gboxFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
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
    }
}