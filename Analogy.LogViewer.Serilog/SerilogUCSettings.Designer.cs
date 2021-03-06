﻿namespace Analogy.LogViewer.Serilog
{
    partial class SerilogUCSettings
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.lblLayout = new System.Windows.Forms.Label();
            this.txtbSupportedFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtbDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.rbtnCLEF = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.rbRegexFile = new System.Windows.Forms.RadioButton();
            this.tcSetttings = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbGuidFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbRegularExpressions = new System.Windows.Forms.ListBox();
            this.gbresult = new System.Windows.Forms.GroupBox();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtbTest = new System.Windows.Forms.TextBox();
            this.lblLogTest = new System.Windows.Forms.Label();
            this.txtbDateTimeFormat = new System.Windows.Forms.TextBox();
            this.txtbRegEx = new System.Windows.Forms.TextBox();
            this.lblDateTimeFormat = new System.Windows.Forms.Label();
            this.lblRegex = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtbOpenFileFilters = new System.Windows.Forms.TextBox();
            this.lblOpenfilesFilters = new System.Windows.Forms.Label();
            this.btnTestFilter = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtbIgnoreColumn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteIgnoreColumn = new System.Windows.Forms.Button();
            this.btnIgnoreColumn = new System.Windows.Forms.Button();
            this.lstbIgnoreColumn = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcSetttings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbresult.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(579, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSettings.Location = new System.Drawing.Point(440, 6);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(133, 47);
            this.btnExportSettings.TabIndex = 2;
            this.btnExportSettings.Text = "Export Settings";
            this.btnExportSettings.UseVisualStyleBackColor = true;
            this.btnExportSettings.Click += new System.EventHandler(this.btnExportSettings_Click);
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(9, 12);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(60, 18);
            this.lblLayout.TabIndex = 3;
            this.lblLayout.Text = "Format:";
            // 
            // txtbSupportedFiles
            // 
            this.txtbSupportedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbSupportedFiles.Location = new System.Drawing.Point(198, 137);
            this.txtbSupportedFiles.Name = "txtbSupportedFiles";
            this.txtbSupportedFiles.Size = new System.Drawing.Size(515, 26);
            this.txtbSupportedFiles.TabIndex = 9;
            this.txtbSupportedFiles.Text = "*.Clef";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supported Log Formats (use ; as separator):";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(297, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 47);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import settings";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtbDirectory
            // 
            this.txtbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDirectory.Location = new System.Drawing.Point(198, 82);
            this.txtbDirectory.Name = "txtbDirectory";
            this.txtbDirectory.Size = new System.Drawing.Size(454, 26);
            this.txtbDirectory.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Default Logs Location:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(666, 82);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(47, 22);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // rbtnCLEF
            // 
            this.rbtnCLEF.AutoSize = true;
            this.rbtnCLEF.Checked = true;
            this.rbtnCLEF.Location = new System.Drawing.Point(93, 9);
            this.rbtnCLEF.Name = "rbtnCLEF";
            this.rbtnCLEF.Size = new System.Drawing.Size(231, 22);
            this.rbtnCLEF.TabIndex = 14;
            this.rbtnCLEF.TabStop = true;
            this.rbtnCLEF.Text = "Compact Log Event File (CLEF)";
            this.rbtnCLEF.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            this.rbJson.AutoSize = true;
            this.rbJson.Location = new System.Drawing.Point(93, 57);
            this.rbJson.Name = "rbJson";
            this.rbJson.Size = new System.Drawing.Size(153, 22);
            this.rbJson.TabIndex = 15;
            this.rbJson.Text = "Json Log Event File";
            this.rbJson.UseVisualStyleBackColor = true;
            // 
            // rbRegexFile
            // 
            this.rbRegexFile.AutoSize = true;
            this.rbRegexFile.Location = new System.Drawing.Point(93, 33);
            this.rbRegexFile.Name = "rbRegexFile";
            this.rbRegexFile.Size = new System.Drawing.Size(289, 22);
            this.rbRegexFile.TabIndex = 16;
            this.rbRegexFile.Text = "Text file - use regular expression parser";
            this.rbRegexFile.UseVisualStyleBackColor = true;
            // 
            // tcSetttings
            // 
            this.tcSetttings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSetttings.Controls.Add(this.tabPage2);
            this.tcSetttings.Location = new System.Drawing.Point(11, 177);
            this.tcSetttings.Name = "tcSetttings";
            this.tcSetttings.SelectedIndex = 0;
            this.tcSetttings.Size = new System.Drawing.Size(696, 319);
            this.tcSetttings.TabIndex = 45;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbGuidFormat);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lstbRegularExpressions);
            this.tabPage2.Controls.Add(this.gbresult);
            this.tabPage2.Controls.Add(this.txtbTest);
            this.tabPage2.Controls.Add(this.lblLogTest);
            this.tabPage2.Controls.Add(this.txtbDateTimeFormat);
            this.tabPage2.Controls.Add(this.txtbRegEx);
            this.tabPage2.Controls.Add(this.lblDateTimeFormat);
            this.tabPage2.Controls.Add(this.lblRegex);
            this.tabPage2.Controls.Add(this.btnTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text file - Regular Expression Parser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbGuidFormat
            // 
            this.txtbGuidFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbGuidFormat.Location = new System.Drawing.Point(258, 58);
            this.txtbGuidFormat.Name = "txtbGuidFormat";
            this.txtbGuidFormat.Size = new System.Drawing.Size(360, 26);
            this.txtbGuidFormat.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 47);
            this.label1.TabIndex = 57;
            this.label1.Text = "Guid Format (The format parameter can be \"N\", \"D\", \"B\", \"P\", or \"X\". If format is" +
    " null or an empty string (\"\"), \"D\" is used):";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(592, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 25);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(635, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 25);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstbRegularExpressions
            // 
            this.lstbRegularExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbRegularExpressions.FormattingEnabled = true;
            this.lstbRegularExpressions.ItemHeight = 18;
            this.lstbRegularExpressions.Location = new System.Drawing.Point(9, 113);
            this.lstbRegularExpressions.Name = "lstbRegularExpressions";
            this.lstbRegularExpressions.Size = new System.Drawing.Size(571, 130);
            this.lstbRegularExpressions.TabIndex = 54;
            // 
            // gbresult
            // 
            this.gbresult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbresult.Controls.Add(this.lblResultMessage);
            this.gbresult.Controls.Add(this.lblResult);
            this.gbresult.Location = new System.Drawing.Point(9, 294);
            this.gbresult.Name = "gbresult";
            this.gbresult.Size = new System.Drawing.Size(571, 2);
            this.gbresult.TabIndex = 52;
            this.gbresult.TabStop = false;
            this.gbresult.Text = "Result";
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultMessage.Location = new System.Drawing.Point(3, 41);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(565, 0);
            this.lblResultMessage.TabIndex = 31;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Location = new System.Drawing.Point(3, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(565, 19);
            this.lblResult.TabIndex = 30;
            // 
            // txtbTest
            // 
            this.txtbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTest.Location = new System.Drawing.Point(119, 266);
            this.txtbTest.Name = "txtbTest";
            this.txtbTest.Size = new System.Drawing.Size(461, 26);
            this.txtbTest.TabIndex = 51;
            // 
            // lblLogTest
            // 
            this.lblLogTest.AccessibleDescription = "";
            this.lblLogTest.AutoSize = true;
            this.lblLogTest.Location = new System.Drawing.Point(6, 269);
            this.lblLogTest.Name = "lblLogTest";
            this.lblLogTest.Size = new System.Drawing.Size(109, 18);
            this.lblLogTest.TabIndex = 50;
            this.lblLogTest.Text = "Log line to test:";
            // 
            // txtbDateTimeFormat
            // 
            this.txtbDateTimeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDateTimeFormat.Location = new System.Drawing.Point(188, 29);
            this.txtbDateTimeFormat.Name = "txtbDateTimeFormat";
            this.txtbDateTimeFormat.Size = new System.Drawing.Size(494, 26);
            this.txtbDateTimeFormat.TabIndex = 48;
            this.txtbDateTimeFormat.Text = "yyyy-MM-dd HH:mm:ss,fff";
            // 
            // txtbRegEx
            // 
            this.txtbRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRegEx.Location = new System.Drawing.Point(188, 6);
            this.txtbRegEx.Name = "txtbRegEx";
            this.txtbRegEx.Size = new System.Drawing.Size(494, 26);
            this.txtbRegEx.TabIndex = 49;
            // 
            // lblDateTimeFormat
            // 
            this.lblDateTimeFormat.AccessibleDescription = "";
            this.lblDateTimeFormat.AutoSize = true;
            this.lblDateTimeFormat.Location = new System.Drawing.Point(6, 37);
            this.lblDateTimeFormat.Name = "lblDateTimeFormat";
            this.lblDateTimeFormat.Size = new System.Drawing.Size(149, 18);
            this.lblDateTimeFormat.TabIndex = 46;
            this.lblDateTimeFormat.Text = "DateTime log format:";
            // 
            // lblRegex
            // 
            this.lblRegex.AccessibleDescription = "";
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(6, 10);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(163, 18);
            this.lblRegex.TabIndex = 47;
            this.lblRegex.Text = "Log Regular Expression:";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(635, 266);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(47, 25);
            this.btnTest.TabIndex = 44;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtbOpenFileFilters
            // 
            this.txtbOpenFileFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbOpenFileFilters.Location = new System.Drawing.Point(198, 109);
            this.txtbOpenFileFilters.Name = "txtbOpenFileFilters";
            this.txtbOpenFileFilters.Size = new System.Drawing.Size(454, 26);
            this.txtbOpenFileFilters.TabIndex = 47;
            // 
            // lblOpenfilesFilters
            // 
            this.lblOpenfilesFilters.AutoEllipsis = true;
            this.lblOpenfilesFilters.Location = new System.Drawing.Point(13, 107);
            this.lblOpenfilesFilters.Name = "lblOpenfilesFilters";
            this.lblOpenfilesFilters.Size = new System.Drawing.Size(184, 22);
            this.lblOpenfilesFilters.TabIndex = 46;
            this.lblOpenfilesFilters.Text = "Open file Filter:";
            // 
            // btnTestFilter
            // 
            this.btnTestFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestFilter.Location = new System.Drawing.Point(666, 109);
            this.btnTestFilter.Name = "btnTestFilter";
            this.btnTestFilter.Size = new System.Drawing.Size(47, 25);
            this.btnTestFilter.TabIndex = 48;
            this.btnTestFilter.Text = "Test";
            this.btnTestFilter.UseVisualStyleBackColor = true;
            this.btnTestFilter.Click += new System.EventHandler(this.btnTestFilter_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(725, 584);
            this.tabControlMain.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLayout);
            this.tabPage1.Controls.Add(this.btnTestFilter);
            this.tabPage1.Controls.Add(this.rbtnCLEF);
            this.tabPage1.Controls.Add(this.txtbOpenFileFilters);
            this.tabPage1.Controls.Add(this.rbJson);
            this.tabPage1.Controls.Add(this.btnOpenFolder);
            this.tabPage1.Controls.Add(this.lblOpenfilesFilters);
            this.tabPage1.Controls.Add(this.txtbDirectory);
            this.tabPage1.Controls.Add(this.rbRegexFile);
            this.tabPage1.Controls.Add(this.txtbSupportedFiles);
            this.tabPage1.Controls.Add(this.tcSetttings);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtbIgnoreColumn);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnDeleteIgnoreColumn);
            this.tabPage3.Controls.Add(this.btnIgnoreColumn);
            this.tabPage3.Controls.Add(this.lstbIgnoreColumn);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(717, 553);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Extra Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtbIgnoreColumn
            // 
            this.txtbIgnoreColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbIgnoreColumn.Location = new System.Drawing.Point(6, 46);
            this.txtbIgnoreColumn.Name = "txtbIgnoreColumn";
            this.txtbIgnoreColumn.Size = new System.Drawing.Size(649, 26);
            this.txtbIgnoreColumn.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "";
            this.label4.AutoEllipsis = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(711, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Dynamic columns: Ignore the following entries in the dynamic columns generation:";
            // 
            // btnDeleteIgnoreColumn
            // 
            this.btnDeleteIgnoreColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteIgnoreColumn.Location = new System.Drawing.Point(615, 133);
            this.btnDeleteIgnoreColumn.Name = "btnDeleteIgnoreColumn";
            this.btnDeleteIgnoreColumn.Size = new System.Drawing.Size(93, 25);
            this.btnDeleteIgnoreColumn.TabIndex = 61;
            this.btnDeleteIgnoreColumn.Text = "Delete";
            this.btnDeleteIgnoreColumn.UseVisualStyleBackColor = true;
            this.btnDeleteIgnoreColumn.Click += new System.EventHandler(this.btnDeleteIgnoreColumn_Click);
            // 
            // btnIgnoreColumn
            // 
            this.btnIgnoreColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnoreColumn.Location = new System.Drawing.Point(661, 46);
            this.btnIgnoreColumn.Name = "btnIgnoreColumn";
            this.btnIgnoreColumn.Size = new System.Drawing.Size(47, 25);
            this.btnIgnoreColumn.TabIndex = 60;
            this.btnIgnoreColumn.Text = "Add";
            this.btnIgnoreColumn.UseVisualStyleBackColor = true;
            this.btnIgnoreColumn.Click += new System.EventHandler(this.btnIgnoreColumn_Click);
            // 
            // lstbIgnoreColumn
            // 
            this.lstbIgnoreColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbIgnoreColumn.FormattingEnabled = true;
            this.lstbIgnoreColumn.ItemHeight = 18;
            this.lstbIgnoreColumn.Location = new System.Drawing.Point(6, 78);
            this.lstbIgnoreColumn.Name = "lstbIgnoreColumn";
            this.lstbIgnoreColumn.Size = new System.Drawing.Size(603, 472);
            this.lstbIgnoreColumn.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnExportSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 56);
            this.panel1.TabIndex = 50;
            // 
            // SerilogUCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "SerilogUCSettings";
            this.Size = new System.Drawing.Size(725, 640);
            this.Load += new System.EventHandler(this.NLogSettings_Load);
            this.tcSetttings.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbresult.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.TextBox txtbSupportedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtbDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.RadioButton rbtnCLEF;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.RadioButton rbRegexFile;
        private System.Windows.Forms.TabControl tcSetttings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbGuidFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstbRegularExpressions;
        private System.Windows.Forms.GroupBox gbresult;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtbTest;
        private System.Windows.Forms.Label lblLogTest;
        private System.Windows.Forms.TextBox txtbDateTimeFormat;
        private System.Windows.Forms.TextBox txtbRegEx;
        private System.Windows.Forms.Label lblDateTimeFormat;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtbOpenFileFilters;
        private System.Windows.Forms.Label lblOpenfilesFilters;
        private System.Windows.Forms.Button btnTestFilter;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbIgnoreColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteIgnoreColumn;
        private System.Windows.Forms.Button btnIgnoreColumn;
        private System.Windows.Forms.ListBox lstbIgnoreColumn;
    }
}
