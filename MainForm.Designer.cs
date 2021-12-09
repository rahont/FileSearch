
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblInFileFoundCount = new System.Windows.Forms.Label();
            this.lblFileFolder = new System.Windows.Forms.Label();
            this.lblFileFolderFoundCount = new System.Windows.Forms.Label();
            this.cboxWhereSearch = new System.Windows.Forms.ComboBox();
            this.pnlWhereSearch = new System.Windows.Forms.Panel();
            this.pnlWhatSearch = new System.Windows.Forms.Panel();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colNamePC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoundIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchFileInProgress = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnErrorLog = new System.Windows.Forms.Button();
            this.fdOpenPCList = new System.Windows.Forms.OpenFileDialog();
            this.pnlActiveFileSearch = new System.Windows.Forms.Panel();
            this.lblActiveFileSearch = new System.Windows.Forms.Label();
            this.btnUnload = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbWhatSearch = new ALLinONE.MyTextBox();
            this.contextMenuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuDGV_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxFoundList.SuspendLayout();
            this.pnlWhereSearch.SuspendLayout();
            this.pnlWhatSearch.SuspendLayout();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlActiveFileSearch.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectList
            // 
            this.btnSelectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectList.Location = new System.Drawing.Point(307, 3);
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
            this.btnGO.Location = new System.Drawing.Point(441, 29);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(79, 34);
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
            this.lbSearchResult.HorizontalScrollbar = true;
            this.lbSearchResult.IntegralHeight = false;
            this.lbSearchResult.Location = new System.Drawing.Point(5, 16);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(496, 285);
            this.lbSearchResult.TabIndex = 6;
            this.lbSearchResult.Visible = false;
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
            this.gboxFoundList.Controls.Add(this.button4);
            this.gboxFoundList.Controls.Add(this.button3);
            this.gboxFoundList.Controls.Add(this.button2);
            this.gboxFoundList.Controls.Add(this.button1);
            this.gboxFoundList.Controls.Add(this.btnSettings);
            this.gboxFoundList.Controls.Add(this.lblFile);
            this.gboxFoundList.Controls.Add(this.lblInFileFoundCount);
            this.gboxFoundList.Controls.Add(this.lblFileFolder);
            this.gboxFoundList.Controls.Add(this.lblFileFolderFoundCount);
            this.gboxFoundList.Location = new System.Drawing.Point(3, 25);
            this.gboxFoundList.Name = "gboxFoundList";
            this.gboxFoundList.Size = new System.Drawing.Size(415, 54);
            this.gboxFoundList.TabIndex = 8;
            this.gboxFoundList.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(330, 29);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(79, 21);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Настройки...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            this.toolTip.SetToolTip(this.lblFile, "Количество найденных совпадений в файле");
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
            this.toolTip.SetToolTip(this.lblInFileFoundCount, "Количество найденных совпадений в файле");
            // 
            // lblFileFolder
            // 
            this.lblFileFolder.AutoSize = true;
            this.lblFileFolder.Location = new System.Drawing.Point(6, 16);
            this.lblFileFolder.Name = "lblFileFolder";
            this.lblFileFolder.Size = new System.Drawing.Size(137, 13);
            this.lblFileFolder.TabIndex = 1;
            this.lblFileFolder.Text = "Найдено файлов и папок:";
            this.toolTip.SetToolTip(this.lblFileFolder, "Количество найденных совпадений в имени файла/папки");
            // 
            // lblFileFolderFoundCount
            // 
            this.lblFileFolderFoundCount.AutoSize = true;
            this.lblFileFolderFoundCount.Location = new System.Drawing.Point(142, 16);
            this.lblFileFolderFoundCount.Name = "lblFileFolderFoundCount";
            this.lblFileFolderFoundCount.Size = new System.Drawing.Size(59, 13);
            this.lblFileFolderFoundCount.TabIndex = 0;
            this.lblFileFolderFoundCount.Text = "пока что 0";
            this.toolTip.SetToolTip(this.lblFileFolderFoundCount, "Количество найденных совпадений в имени файла/папки");
            // 
            // cboxWhereSearch
            // 
            this.cboxWhereSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxWhereSearch.FormattingEnabled = true;
            this.cboxWhereSearch.Location = new System.Drawing.Point(3, 3);
            this.cboxWhereSearch.Name = "cboxWhereSearch";
            this.cboxWhereSearch.Size = new System.Drawing.Size(301, 21);
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
            this.pnlWhereSearch.Location = new System.Drawing.Point(12, 30);
            this.pnlWhereSearch.Name = "pnlWhereSearch";
            this.pnlWhereSearch.Size = new System.Drawing.Size(423, 29);
            this.pnlWhereSearch.TabIndex = 0;
            // 
            // pnlWhatSearch
            // 
            this.pnlWhatSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWhatSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWhatSearch.Controls.Add(this.tbWhatSearch);
            this.pnlWhatSearch.Controls.Add(this.gboxFoundList);
            this.pnlWhatSearch.Location = new System.Drawing.Point(12, 65);
            this.pnlWhatSearch.Name = "pnlWhatSearch";
            this.pnlWhatSearch.Size = new System.Drawing.Size(423, 84);
            this.pnlWhatSearch.TabIndex = 1;
            // 
            // pnlResult
            // 
            this.pnlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.Controls.Add(this.dgvList);
            this.pnlResult.Controls.Add(this.lblSearchFileInProgress);
            this.pnlResult.Controls.Add(this.lbSearchResult);
            this.pnlResult.Controls.Add(this.lblSearchResult);
            this.pnlResult.Location = new System.Drawing.Point(12, 176);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(508, 308);
            this.pnlResult.TabIndex = 5;
            this.pnlResult.TabStop = true;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNamePC,
            this.colFilePath,
            this.colFoundIn,
            this.colDateChange});
            this.dgvList.Location = new System.Drawing.Point(6, 18);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(495, 283);
            this.dgvList.TabIndex = 14;
            // 
            // colNamePC
            // 
            this.colNamePC.HeaderText = "Имя/Адрес ПК";
            this.colNamePC.Name = "colNamePC";
            this.colNamePC.ReadOnly = true;
            // 
            // colFilePath
            // 
            this.colFilePath.HeaderText = "Путь к файлу";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            // 
            // colFoundIn
            // 
            this.colFoundIn.HeaderText = "Найдено в";
            this.colFoundIn.Name = "colFoundIn";
            this.colFoundIn.ReadOnly = true;
            // 
            // colDateChange
            // 
            this.colDateChange.HeaderText = "Дата изменения";
            this.colDateChange.Name = "colDateChange";
            this.colDateChange.ReadOnly = true;
            // 
            // lblSearchFileInProgress
            // 
            this.lblSearchFileInProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchFileInProgress.AutoSize = true;
            this.lblSearchFileInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchFileInProgress.Location = new System.Drawing.Point(150, 137);
            this.lblSearchFileInProgress.Name = "lblSearchFileInProgress";
            this.lblSearchFileInProgress.Size = new System.Drawing.Size(206, 31);
            this.lblSearchFileInProgress.TabIndex = 13;
            this.lblSearchFileInProgress.Text = "ИДЕТ ПОИСК";
            this.lblSearchFileInProgress.UseWaitCursor = true;
            this.lblSearchFileInProgress.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(441, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 34);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Остановить поиск";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnErrorLog
            // 
            this.btnErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErrorLog.Location = new System.Drawing.Point(441, 69);
            this.btnErrorLog.Name = "btnErrorLog";
            this.btnErrorLog.Size = new System.Drawing.Size(79, 34);
            this.btnErrorLog.TabIndex = 5;
            this.btnErrorLog.TabStop = false;
            this.btnErrorLog.Tag = "btnTagTest";
            this.btnErrorLog.Text = "Количество ошибок: 0";
            this.btnErrorLog.UseVisualStyleBackColor = true;
            this.btnErrorLog.Visible = false;
            this.btnErrorLog.Click += new System.EventHandler(this.btnErrorLog_Click);
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
            this.pnlActiveFileSearch.Location = new System.Drawing.Point(12, 155);
            this.pnlActiveFileSearch.Name = "pnlActiveFileSearch";
            this.pnlActiveFileSearch.Size = new System.Drawing.Size(508, 15);
            this.pnlActiveFileSearch.TabIndex = 14;
            // 
            // lblActiveFileSearch
            // 
            this.lblActiveFileSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveFileSearch.Location = new System.Drawing.Point(0, 0);
            this.lblActiveFileSearch.Name = "lblActiveFileSearch";
            this.lblActiveFileSearch.Size = new System.Drawing.Size(506, 13);
            this.lblActiveFileSearch.TabIndex = 0;
            // 
            // btnUnload
            // 
            this.btnUnload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnload.Location = new System.Drawing.Point(441, 116);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemInfo,
            this.toolStripMenuItemUserName});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(531, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings,
            this.toolStripSeparator1,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemSettings.Text = "Настройки";
            this.ToolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemInfo.Text = "Справка";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAbout.Text = "О программе";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemUserName
            // 
            this.toolStripMenuItemUserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemUserName.Name = "toolStripMenuItemUserName";
            this.toolStripMenuItemUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItemUserName.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItemUserName.Text = "UserName";
            this.toolStripMenuItemUserName.ToolTipText = "Имя пользователя";
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
            this.tbWhatSearch.Size = new System.Drawing.Size(415, 20);
            this.tbWhatSearch.TabIndex = 2;
            this.tbWhatSearch.TextMaxLength = 1024;
            this.tbWhatSearch.TextTitle = "Что ищем? Имя или часть имени файла/папки";
            this.tbWhatSearch.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbWhatSearch_KeyDownEvent);
            // 
            // contextMenuDGV
            // 
            this.contextMenuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuDGV_Delete});
            this.contextMenuDGV.Name = "contextMenuDGV";
            this.contextMenuDGV.Size = new System.Drawing.Size(191, 48);
            // 
            // contextMenuDGV_Delete
            // 
            this.contextMenuDGV_Delete.Name = "contextMenuDGV_Delete";
            this.contextMenuDGV_Delete.Size = new System.Drawing.Size(190, 22);
            this.contextMenuDGV_Delete.Text = "Удалить выделенные";
            this.contextMenuDGV_Delete.Click += new System.EventHandler(this.contextMenuDGV_Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 488);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.btnErrorLog);
            this.Controls.Add(this.pnlActiveFileSearch);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlWhatSearch);
            this.Controls.Add(this.pnlWhereSearch);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(384, 424);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gboxFoundList.ResumeLayout(false);
            this.gboxFoundList.PerformLayout();
            this.pnlWhereSearch.ResumeLayout(false);
            this.pnlWhatSearch.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlActiveFileSearch.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuDGV.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnErrorLog;
        private System.Windows.Forms.Label lblFileFolderFoundCount;
        private System.Windows.Forms.Label lblFileFolder;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblInFileFoundCount;
        private System.Windows.Forms.Label lblSearchFileInProgress;
        private System.Windows.Forms.Panel pnlActiveFileSearch;
        private System.Windows.Forms.Label lblActiveFileSearch;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamePC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoundIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateChange;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuDGV;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDGV_Delete;
    }
}

