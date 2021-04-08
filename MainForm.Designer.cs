
namespace FileSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectList = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.lbSearchResult = new System.Windows.Forms.ListBox();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.gboxFoundList = new System.Windows.Forms.GroupBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblInFileFoundCount = new System.Windows.Forms.Label();
            this.lblFileFolder = new System.Windows.Forms.Label();
            this.lblFileFolderFoundCount = new System.Windows.Forms.Label();
            this.cboxWhereSearch = new System.Windows.Forms.ComboBox();
            this.pnlWhereSearch = new System.Windows.Forms.Panel();
            this.pnlWhatSearch = new System.Windows.Forms.Panel();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSearchFileInProgress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fdOpenPCList = new System.Windows.Forms.OpenFileDialog();
            this.pnlActiveFileSearch = new System.Windows.Forms.Panel();
            this.lblActiveFileSearch = new System.Windows.Forms.Label();
            this.ttFileSearch = new System.Windows.Forms.ToolTip(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbWhatSearch = new ALLinONE.MyTextBox();
            this.gboxFoundList.SuspendLayout();
            this.pnlWhereSearch.SuspendLayout();
            this.pnlWhatSearch.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.pnlActiveFileSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectList
            // 
            this.btnSelectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectList.Location = new System.Drawing.Point(144, 3);
            this.btnSelectList.Name = "btnSelectList";
            this.btnSelectList.Size = new System.Drawing.Size(111, 21);
            this.btnSelectList.TabIndex = 1;
            this.btnSelectList.Text = "Указать список...";
            this.btnSelectList.UseVisualStyleBackColor = true;
            this.btnSelectList.Click += new System.EventHandler(this.btnSelectList_Click);
            // 
            // btnGO
            // 
            this.btnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGO.Location = new System.Drawing.Point(278, 32);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(79, 39);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "Запустить поиск";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchResult.FormattingEnabled = true;
            this.lbSearchResult.Location = new System.Drawing.Point(5, 16);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(333, 199);
            this.lbSearchResult.TabIndex = 6;
            this.lbSearchResult.DoubleClick += new System.EventHandler(this.lbSearchResult_DoubleClick);
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(3, 0);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(98, 13);
            this.lblSearchResult.TabIndex = 4;
            this.lblSearchResult.Text = "Результат поиска";
            // 
            // gboxFoundList
            // 
            this.gboxFoundList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxFoundList.Controls.Add(this.lblFile);
            this.gboxFoundList.Controls.Add(this.lblInFileFoundCount);
            this.gboxFoundList.Controls.Add(this.lblFileFolder);
            this.gboxFoundList.Controls.Add(this.lblFileFolderFoundCount);
            this.gboxFoundList.Location = new System.Drawing.Point(3, 25);
            this.gboxFoundList.Name = "gboxFoundList";
            this.gboxFoundList.Size = new System.Drawing.Size(252, 54);
            this.gboxFoundList.TabIndex = 8;
            this.gboxFoundList.TabStop = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFile.Location = new System.Drawing.Point(40, 33);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(103, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "Найдено в файлах:";
            // 
            // lblInFileFoundCount
            // 
            this.lblInFileFoundCount.AutoSize = true;
            this.lblInFileFoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInFileFoundCount.Location = new System.Drawing.Point(142, 33);
            this.lblInFileFoundCount.Name = "lblInFileFoundCount";
            this.lblInFileFoundCount.Size = new System.Drawing.Size(59, 13);
            this.lblInFileFoundCount.TabIndex = 2;
            this.lblInFileFoundCount.Text = "пока что 0";
            // 
            // lblFileFolder
            // 
            this.lblFileFolder.AutoSize = true;
            this.lblFileFolder.Location = new System.Drawing.Point(6, 16);
            this.lblFileFolder.Name = "lblFileFolder";
            this.lblFileFolder.Size = new System.Drawing.Size(137, 13);
            this.lblFileFolder.TabIndex = 1;
            this.lblFileFolder.Text = "Найдено файлов и папок:";
            // 
            // lblFileFolderFoundCount
            // 
            this.lblFileFolderFoundCount.AutoSize = true;
            this.lblFileFolderFoundCount.Location = new System.Drawing.Point(142, 16);
            this.lblFileFolderFoundCount.Name = "lblFileFolderFoundCount";
            this.lblFileFolderFoundCount.Size = new System.Drawing.Size(59, 13);
            this.lblFileFolderFoundCount.TabIndex = 0;
            this.lblFileFolderFoundCount.Text = "пока что 0";
            // 
            // cboxWhereSearch
            // 
            this.cboxWhereSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxWhereSearch.FormattingEnabled = true;
            this.cboxWhereSearch.Location = new System.Drawing.Point(3, 3);
            this.cboxWhereSearch.Name = "cboxWhereSearch";
            this.cboxWhereSearch.Size = new System.Drawing.Size(138, 21);
            this.cboxWhereSearch.TabIndex = 0;
            this.cboxWhereSearch.Text = "Список ПК пуст";
            // 
            // pnlWhereSearch
            // 
            this.pnlWhereSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWhereSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWhereSearch.Controls.Add(this.cboxWhereSearch);
            this.pnlWhereSearch.Controls.Add(this.btnSelectList);
            this.pnlWhereSearch.Location = new System.Drawing.Point(12, 12);
            this.pnlWhereSearch.Name = "pnlWhereSearch";
            this.pnlWhereSearch.Size = new System.Drawing.Size(260, 29);
            this.pnlWhereSearch.TabIndex = 0;
            // 
            // pnlWhatSearch
            // 
            this.pnlWhatSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWhatSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWhatSearch.Controls.Add(this.tbWhatSearch);
            this.pnlWhatSearch.Controls.Add(this.gboxFoundList);
            this.pnlWhatSearch.Location = new System.Drawing.Point(12, 47);
            this.pnlWhatSearch.Name = "pnlWhatSearch";
            this.pnlWhatSearch.Size = new System.Drawing.Size(260, 84);
            this.pnlWhatSearch.TabIndex = 1;
            // 
            // pnlResult
            // 
            this.pnlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.Controls.Add(this.button2);
            this.pnlResult.Controls.Add(this.lblSearchFileInProgress);
            this.pnlResult.Controls.Add(this.button1);
            this.pnlResult.Controls.Add(this.lbSearchResult);
            this.pnlResult.Controls.Add(this.lblSearchResult);
            this.pnlResult.Location = new System.Drawing.Point(12, 158);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(345, 225);
            this.pnlResult.TabIndex = 5;
            this.pnlResult.TabStop = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(265, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSearchFileInProgress
            // 
            this.lblSearchFileInProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchFileInProgress.AutoSize = true;
            this.lblSearchFileInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchFileInProgress.Location = new System.Drawing.Point(68, 95);
            this.lblSearchFileInProgress.Name = "lblSearchFileInProgress";
            this.lblSearchFileInProgress.Size = new System.Drawing.Size(206, 31);
            this.lblSearchFileInProgress.TabIndex = 13;
            this.lblSearchFileInProgress.Text = "ИДЕТ ПОИСК";
            this.lblSearchFileInProgress.UseWaitCursor = true;
            this.lblSearchFileInProgress.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(265, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fdOpenPCList
            // 
            this.fdOpenPCList.DefaultExt = "txt";
            this.fdOpenPCList.FileName = "Список ПК.txt";
            this.fdOpenPCList.Filter = "txt file|*.txt|All Files|*.*";
            this.fdOpenPCList.Title = "Выбери файл со списком ПК";
            // 
            // pnlActiveFileSearch
            // 
            this.pnlActiveFileSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActiveFileSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActiveFileSearch.Controls.Add(this.lblActiveFileSearch);
            this.pnlActiveFileSearch.Location = new System.Drawing.Point(12, 137);
            this.pnlActiveFileSearch.Name = "pnlActiveFileSearch";
            this.pnlActiveFileSearch.Size = new System.Drawing.Size(345, 15);
            this.pnlActiveFileSearch.TabIndex = 14;
            // 
            // lblActiveFileSearch
            // 
            this.lblActiveFileSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveFileSearch.Location = new System.Drawing.Point(0, 0);
            this.lblActiveFileSearch.Name = "lblActiveFileSearch";
            this.lblActiveFileSearch.Size = new System.Drawing.Size(343, 13);
            this.lblActiveFileSearch.TabIndex = 0;
            // 
            // ttFileSearch
            // 
            this.ttFileSearch.AutoPopDelay = 20000;
            this.ttFileSearch.InitialDelay = 500;
            this.ttFileSearch.ReshowDelay = 100;
            this.ttFileSearch.ToolTipTitle = "Вот тебе подсказка:";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(278, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "UserName";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(278, 77);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(79, 21);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Настройки...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUnload
            // 
            this.btnUnload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnload.Location = new System.Drawing.Point(278, 97);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(79, 34);
            this.btnUnload.TabIndex = 4;
            this.btnUnload.Text = "Выгрузить в файл...";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Результат поиска";
            this.saveFileDialog.Filter = "Текстовый файл|*.txt";
            // 
            // tbWhatSearch
            // 
            this.tbWhatSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWhatSearch.Location = new System.Drawing.Point(3, 3);
            this.tbWhatSearch.MaximumSize = new System.Drawing.Size(10000, 20);
            this.tbWhatSearch.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbWhatSearch.Name = "tbWhatSearch";
            this.tbWhatSearch.PasswordChar = '\0';
            this.tbWhatSearch.Size = new System.Drawing.Size(252, 20);
            this.tbWhatSearch.TabIndex = 2;
            this.tbWhatSearch.TextMaxLength = 1024;
            this.tbWhatSearch.TextTitle = "Что ищем? Имя или часть имени файла/папки";
            this.tbWhatSearch.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbWhatSearch_KeyDownEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 385);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlActiveFileSearch);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlWhatSearch);
            this.Controls.Add(this.pnlWhereSearch);
            this.Controls.Add(this.btnGO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(384, 424);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gboxFoundList.ResumeLayout(false);
            this.gboxFoundList.PerformLayout();
            this.pnlWhereSearch.ResumeLayout(false);
            this.pnlWhatSearch.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlActiveFileSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ALLinONE.MyTextBox tbWhatSearch;
        private System.Windows.Forms.Button btnSelectList;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.ListBox lbSearchResult;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.GroupBox gboxFoundList;
        private System.Windows.Forms.ComboBox cboxWhereSearch;
        private System.Windows.Forms.Panel pnlWhereSearch;
        private System.Windows.Forms.Panel pnlWhatSearch;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.OpenFileDialog fdOpenPCList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFileFolderFoundCount;
        private System.Windows.Forms.Label lblFileFolder;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblInFileFoundCount;
        private System.Windows.Forms.Label lblSearchFileInProgress;
        private System.Windows.Forms.Panel pnlActiveFileSearch;
        private System.Windows.Forms.Label lblActiveFileSearch;
        private System.Windows.Forms.ToolTip ttFileSearch;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button2;
    }
}

