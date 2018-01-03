namespace Video_Downloader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.searchProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.searchListView = new System.Windows.Forms.ListView();
            this.searchContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.downloadTabPage = new System.Windows.Forms.TabPage();
            this.btnBrowse = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveToTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.locationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.downloadProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.downloadUrlTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDownload = new MaterialSkin.Controls.MaterialFlatButton();
            this.urlLabel = new MaterialSkin.Controls.MaterialLabel();
            this.convertTabPage = new System.Windows.Forms.TabPage();
            this.convertProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnLoadTo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSaveTo = new MaterialSkin.Controls.MaterialFlatButton();
            this.fileSaveTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.qualityComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.fileLoadTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConvert = new MaterialSkin.Controls.MaterialFlatButton();
            this.activityTabPage = new System.Windows.Forms.TabPage();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStart = new System.Windows.Forms.ToolStripButton();
            this.toolStartAll = new System.Windows.Forms.ToolStripButton();
            this.toolPause = new System.Windows.Forms.ToolStripButton();
            this.toolPauseAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemove = new System.Windows.Forms.ToolStripButton();
            this.toolRemoveCompleted = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMoveSelectionsUp = new System.Windows.Forms.ToolStripButton();
            this.toolMoveSelectionsDown = new System.Windows.Forms.ToolStripButton();
            this.activityListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playTabPage = new System.Windows.Forms.TabPage();
            this.axShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TabControl.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.searchContextMenuStrip.SuspendLayout();
            this.downloadTabPage.SuspendLayout();
            this.convertTabPage.SuspendLayout();
            this.activityTabPage.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.playTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.searchTabPage);
            this.TabControl.Controls.Add(this.downloadTabPage);
            this.TabControl.Controls.Add(this.convertTabPage);
            this.TabControl.Controls.Add(this.activityTabPage);
            this.TabControl.Controls.Add(this.playTabPage);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(12, 180);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(768, 466);
            this.TabControl.TabIndex = 0;
            // 
            // searchTabPage
            // 
            this.searchTabPage.BackColor = System.Drawing.Color.White;
            this.searchTabPage.Controls.Add(this.searchProgressBar);
            this.searchTabPage.Controls.Add(this.searchListView);
            this.searchTabPage.Controls.Add(this.searchTextField);
            this.searchTabPage.Controls.Add(this.btnSearch);
            this.searchTabPage.Location = new System.Drawing.Point(4, 25);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(760, 437);
            this.searchTabPage.TabIndex = 0;
            this.searchTabPage.Text = "Search";
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProgressBar.Depth = 0;
            this.searchProgressBar.Location = new System.Drawing.Point(6, 426);
            this.searchProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(751, 5);
            this.searchProgressBar.TabIndex = 5;
            // 
            // searchListView
            // 
            this.searchListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchListView.ContextMenuStrip = this.searchContextMenuStrip;
            this.searchListView.Location = new System.Drawing.Point(6, 51);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(747, 380);
            this.searchListView.TabIndex = 2;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            // 
            // searchContextMenuStrip
            // 
            this.searchContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchContextMenuStrip.Depth = 0;
            this.searchContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.addToActivityToolStripMenuItem});
            this.searchContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchContextMenuStrip.Name = "materialContextMenuStrip1";
            this.searchContextMenuStrip.Size = new System.Drawing.Size(184, 82);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // addToActivityToolStripMenuItem
            // 
            this.addToActivityToolStripMenuItem.Name = "addToActivityToolStripMenuItem";
            this.addToActivityToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addToActivityToolStripMenuItem.Text = "Add to Activity";
            this.addToActivityToolStripMenuItem.Click += new System.EventHandler(this.addToActivityToolStripMenuItem_Click);
            // 
            // searchTextField
            // 
            this.searchTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextField.Depth = 0;
            this.searchTextField.Hint = "";
            this.searchTextField.Location = new System.Drawing.Point(6, 17);
            this.searchTextField.MaxLength = 32767;
            this.searchTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.PasswordChar = '\0';
            this.searchTextField.SelectedText = "";
            this.searchTextField.SelectionLength = 0;
            this.searchTextField.SelectionStart = 0;
            this.searchTextField.Size = new System.Drawing.Size(594, 28);
            this.searchTextField.TabIndex = 0;
            this.searchTextField.TabStop = false;
            this.searchTextField.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = global::Video_Downloader.Properties.Resources.ic_search_black_48dp_2x;
            this.btnSearch.Location = new System.Drawing.Point(637, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(116, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // downloadTabPage
            // 
            this.downloadTabPage.BackColor = System.Drawing.Color.White;
            this.downloadTabPage.Controls.Add(this.btnBrowse);
            this.downloadTabPage.Controls.Add(this.saveToTextField);
            this.downloadTabPage.Controls.Add(this.locationLabel);
            this.downloadTabPage.Controls.Add(this.resolutionComboBox);
            this.downloadTabPage.Controls.Add(this.materialLabel1);
            this.downloadTabPage.Controls.Add(this.downloadProgressBar);
            this.downloadTabPage.Controls.Add(this.downloadUrlTextField);
            this.downloadTabPage.Controls.Add(this.btnDownload);
            this.downloadTabPage.Controls.Add(this.urlLabel);
            this.downloadTabPage.Location = new System.Drawing.Point(4, 25);
            this.downloadTabPage.Name = "downloadTabPage";
            this.downloadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadTabPage.Size = new System.Drawing.Size(760, 437);
            this.downloadTabPage.TabIndex = 1;
            this.downloadTabPage.Text = "Download";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.Icon = global::Video_Downloader.Properties.Resources.ic_folder_open_black_48dp_2x;
            this.btnBrowse.Location = new System.Drawing.Point(380, 71);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Primary = false;
            this.btnBrowse.Size = new System.Drawing.Size(133, 36);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Tag = "";
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // saveToTextField
            // 
            this.saveToTextField.Depth = 0;
            this.saveToTextField.Hint = "";
            this.saveToTextField.Location = new System.Drawing.Point(117, 79);
            this.saveToTextField.MaxLength = 32767;
            this.saveToTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveToTextField.Name = "saveToTextField";
            this.saveToTextField.PasswordChar = '\0';
            this.saveToTextField.SelectedText = "";
            this.saveToTextField.SelectionLength = 0;
            this.saveToTextField.SelectionStart = 0;
            this.saveToTextField.Size = new System.Drawing.Size(256, 28);
            this.saveToTextField.TabIndex = 8;
            this.saveToTextField.TabStop = false;
            this.saveToTextField.UseSystemPasswordChar = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Depth = 0;
            this.locationLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.locationLabel.Location = new System.Drawing.Point(34, 83);
            this.locationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(77, 24);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Save to:";
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "360\t",
            "480",
            "720"});
            this.resolutionComboBox.Location = new System.Drawing.Point(117, 47);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(178, 30);
            this.resolutionComboBox.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Resolution:";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressBar.Depth = 0;
            this.downloadProgressBar.Location = new System.Drawing.Point(6, 421);
            this.downloadProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(526, 5);
            this.downloadProgressBar.TabIndex = 4;
            // 
            // downloadUrlTextField
            // 
            this.downloadUrlTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadUrlTextField.Depth = 0;
            this.downloadUrlTextField.Hint = "";
            this.downloadUrlTextField.Location = new System.Drawing.Point(117, 13);
            this.downloadUrlTextField.MaxLength = 32767;
            this.downloadUrlTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadUrlTextField.Name = "downloadUrlTextField";
            this.downloadUrlTextField.PasswordChar = '\0';
            this.downloadUrlTextField.SelectedText = "";
            this.downloadUrlTextField.SelectionLength = 0;
            this.downloadUrlTextField.SelectionStart = 0;
            this.downloadUrlTextField.Size = new System.Drawing.Size(575, 28);
            this.downloadUrlTextField.TabIndex = 3;
            this.downloadUrlTextField.TabStop = false;
            this.downloadUrlTextField.UseSystemPasswordChar = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.Icon = global::Video_Downloader.Properties.Resources.ic_file_download_black_48dp_2x;
            this.btnDownload.Location = new System.Drawing.Point(609, 395);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = false;
            this.btnDownload.Size = new System.Drawing.Size(144, 36);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Depth = 0;
            this.urlLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.urlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.urlLabel.Location = new System.Drawing.Point(73, 13);
            this.urlLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(38, 24);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "Url:";
            // 
            // convertTabPage
            // 
            this.convertTabPage.BackColor = System.Drawing.Color.White;
            this.convertTabPage.Controls.Add(this.convertProgressBar);
            this.convertTabPage.Controls.Add(this.btnLoadTo);
            this.convertTabPage.Controls.Add(this.btnSaveTo);
            this.convertTabPage.Controls.Add(this.fileSaveTextField);
            this.convertTabPage.Controls.Add(this.materialLabel5);
            this.convertTabPage.Controls.Add(this.qualityComboBox);
            this.convertTabPage.Controls.Add(this.materialLabel4);
            this.convertTabPage.Controls.Add(this.typeComboBox);
            this.convertTabPage.Controls.Add(this.materialLabel3);
            this.convertTabPage.Controls.Add(this.fileLoadTextField);
            this.convertTabPage.Controls.Add(this.materialLabel2);
            this.convertTabPage.Controls.Add(this.btnConvert);
            this.convertTabPage.Location = new System.Drawing.Point(4, 25);
            this.convertTabPage.Name = "convertTabPage";
            this.convertTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.convertTabPage.Size = new System.Drawing.Size(760, 437);
            this.convertTabPage.TabIndex = 2;
            this.convertTabPage.Text = "Convert";
            // 
            // convertProgressBar
            // 
            this.convertProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertProgressBar.Depth = 0;
            this.convertProgressBar.Location = new System.Drawing.Point(6, 413);
            this.convertProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.convertProgressBar.Name = "convertProgressBar";
            this.convertProgressBar.Size = new System.Drawing.Size(526, 5);
            this.convertProgressBar.TabIndex = 11;
            // 
            // btnLoadTo
            // 
            this.btnLoadTo.AutoSize = true;
            this.btnLoadTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadTo.Depth = 0;
            this.btnLoadTo.Icon = global::Video_Downloader.Properties.Resources.ic_folder_open_black_48dp_2x;
            this.btnLoadTo.Location = new System.Drawing.Point(185, 6);
            this.btnLoadTo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadTo.Name = "btnLoadTo";
            this.btnLoadTo.Primary = false;
            this.btnLoadTo.Size = new System.Drawing.Size(44, 36);
            this.btnLoadTo.TabIndex = 10;
            this.btnLoadTo.UseVisualStyleBackColor = true;
            this.btnLoadTo.Click += new System.EventHandler(this.btnLoadTo_Click);
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.AutoSize = true;
            this.btnSaveTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveTo.Depth = 0;
            this.btnSaveTo.Icon = global::Video_Downloader.Properties.Resources.ic_folder_black_48dp_2x;
            this.btnSaveTo.Location = new System.Drawing.Point(185, 125);
            this.btnSaveTo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Primary = false;
            this.btnSaveTo.Size = new System.Drawing.Size(44, 36);
            this.btnSaveTo.TabIndex = 9;
            this.btnSaveTo.UseVisualStyleBackColor = true;
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // fileSaveTextField
            // 
            this.fileSaveTextField.Depth = 0;
            this.fileSaveTextField.Hint = "";
            this.fileSaveTextField.Location = new System.Drawing.Point(250, 133);
            this.fileSaveTextField.MaxLength = 32767;
            this.fileSaveTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileSaveTextField.Name = "fileSaveTextField";
            this.fileSaveTextField.PasswordChar = '\0';
            this.fileSaveTextField.SelectedText = "";
            this.fileSaveTextField.SelectionLength = 0;
            this.fileSaveTextField.SelectionStart = 0;
            this.fileSaveTextField.Size = new System.Drawing.Size(358, 28);
            this.fileSaveTextField.TabIndex = 8;
            this.fileSaveTextField.TabStop = false;
            this.fileSaveTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(101, 130);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 24);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Save to:";
            // 
            // qualityComboBox
            // 
            this.qualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qualityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityComboBox.FormattingEnabled = true;
            this.qualityComboBox.Location = new System.Drawing.Point(185, 90);
            this.qualityComboBox.Name = "qualityComboBox";
            this.qualityComboBox.Size = new System.Drawing.Size(254, 30);
            this.qualityComboBox.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(2, 93);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(170, 24);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Conversion quality:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            ".mp3",
            ".mp4",
            ".aac",
            ".ogg",
            ".avi",
            ".mov",
            ".wma",
            ".flv",
            ".wav",
            ".wmv"});
            this.typeComboBox.Location = new System.Drawing.Point(185, 54);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(254, 30);
            this.typeComboBox.TabIndex = 4;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 60);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Convert video to:";
            // 
            // fileLoadTextField
            // 
            this.fileLoadTextField.Depth = 0;
            this.fileLoadTextField.Hint = "";
            this.fileLoadTextField.Location = new System.Drawing.Point(250, 13);
            this.fileLoadTextField.MaxLength = 32767;
            this.fileLoadTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileLoadTextField.Name = "fileLoadTextField";
            this.fileLoadTextField.PasswordChar = '\0';
            this.fileLoadTextField.SelectedText = "";
            this.fileLoadTextField.SelectionLength = 0;
            this.fileLoadTextField.SelectionStart = 0;
            this.fileLoadTextField.Size = new System.Drawing.Size(358, 28);
            this.fileLoadTextField.TabIndex = 2;
            this.fileLoadTextField.TabStop = false;
            this.fileLoadTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(150, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Select video file:";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.AutoSize = true;
            this.btnConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert.Depth = 0;
            this.btnConvert.Icon = global::Video_Downloader.Properties.Resources.ic_loop_black_48dp_2x;
            this.btnConvert.Location = new System.Drawing.Point(626, 392);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Primary = false;
            this.btnConvert.Size = new System.Drawing.Size(127, 36);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // activityTabPage
            // 
            this.activityTabPage.Controls.Add(this.toolStripMain);
            this.activityTabPage.Controls.Add(this.activityListView);
            this.activityTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityTabPage.Location = new System.Drawing.Point(4, 25);
            this.activityTabPage.Name = "activityTabPage";
            this.activityTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.activityTabPage.Size = new System.Drawing.Size(760, 437);
            this.activityTabPage.TabIndex = 3;
            this.activityTabPage.Text = "Activity";
            this.activityTabPage.UseVisualStyleBackColor = true;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStart,
            this.toolStartAll,
            this.toolPause,
            this.toolPauseAll,
            this.toolStripSeparator2,
            this.toolRemove,
            this.toolRemoveCompleted,
            this.toolStripSeparator3,
            this.toolMoveSelectionsUp,
            this.toolMoveSelectionsDown});
            this.toolStripMain.Location = new System.Drawing.Point(-4, 3);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(783, 40);
            this.toolStripMain.TabIndex = 2;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(179, 37);
            this.toolStripButton1.Text = "New Video Download";
            this.toolStripButton1.ToolTipText = "New Video Download (from YouTube, GoogleVideo, Break...)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStart
            // 
            this.toolStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStart.Image")));
            this.toolStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStart.Name = "toolStart";
            this.toolStart.Size = new System.Drawing.Size(24, 37);
            this.toolStart.Text = "Start";
            this.toolStart.Click += new System.EventHandler(this.toolStart_Click);
            // 
            // toolStartAll
            // 
            this.toolStartAll.CheckOnClick = true;
            this.toolStartAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStartAll.Image")));
            this.toolStartAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStartAll.Name = "toolStartAll";
            this.toolStartAll.Size = new System.Drawing.Size(86, 37);
            this.toolStartAll.Text = "Start All";
            this.toolStartAll.ToolTipText = "Starst all Downloads";
            this.toolStartAll.Click += new System.EventHandler(this.toolStartAll_Click);
            // 
            // toolPause
            // 
            this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPause.Image = ((System.Drawing.Image)(resources.GetObject("toolPause.Image")));
            this.toolPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPause.Name = "toolPause";
            this.toolPause.Size = new System.Drawing.Size(24, 37);
            this.toolPause.Text = "Pause";
            this.toolPause.Click += new System.EventHandler(this.toolPause_Click);
            // 
            // toolPauseAll
            // 
            this.toolPauseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPauseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolPauseAll.Image")));
            this.toolPauseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPauseAll.Name = "toolPauseAll";
            this.toolPauseAll.Size = new System.Drawing.Size(24, 37);
            this.toolPauseAll.Text = "Pause All";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolRemove
            // 
            this.toolRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolRemove.Image")));
            this.toolRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemove.Name = "toolRemove";
            this.toolRemove.Size = new System.Drawing.Size(24, 37);
            this.toolRemove.Text = "Remove";
            this.toolRemove.Click += new System.EventHandler(this.toolRemove_Click);
            // 
            // toolRemoveCompleted
            // 
            this.toolRemoveCompleted.Image = ((System.Drawing.Image)(resources.GetObject("toolRemoveCompleted.Image")));
            this.toolRemoveCompleted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveCompleted.Name = "toolRemoveCompleted";
            this.toolRemoveCompleted.Size = new System.Drawing.Size(165, 37);
            this.toolRemoveCompleted.Text = "Remove Completed";
            this.toolRemoveCompleted.Click += new System.EventHandler(this.toolRemoveCompleted_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // toolMoveSelectionsUp
            // 
            this.toolMoveSelectionsUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveSelectionsUp.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveSelectionsUp.Image")));
            this.toolMoveSelectionsUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveSelectionsUp.Name = "toolMoveSelectionsUp";
            this.toolMoveSelectionsUp.Size = new System.Drawing.Size(24, 37);
            this.toolMoveSelectionsUp.Text = "Move Selections Up";
            this.toolMoveSelectionsUp.Click += new System.EventHandler(this.toolMoveSelectionsUp_Click);
            // 
            // toolMoveSelectionsDown
            // 
            this.toolMoveSelectionsDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveSelectionsDown.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveSelectionsDown.Image")));
            this.toolMoveSelectionsDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveSelectionsDown.Name = "toolMoveSelectionsDown";
            this.toolMoveSelectionsDown.Size = new System.Drawing.Size(24, 37);
            this.toolMoveSelectionsDown.Text = "Move Selections Down";
            this.toolMoveSelectionsDown.Click += new System.EventHandler(this.toolMoveSelectionsDown_Click);
            // 
            // activityListView
            // 
            this.activityListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.activityListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.activityListView.FullRowSelect = true;
            this.activityListView.GridLines = true;
            this.activityListView.Location = new System.Drawing.Point(-4, 46);
            this.activityListView.Name = "activityListView";
            this.activityListView.Size = new System.Drawing.Size(758, 395);
            this.activityListView.TabIndex = 0;
            this.activityListView.UseCompatibleStateImageBehavior = false;
            this.activityListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Completed";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Progress";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Added";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "URL";
            this.columnHeader6.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Location";
            this.columnHeader7.Width = 158;
            // 
            // playTabPage
            // 
            this.playTabPage.Controls.Add(this.axShockwaveFlash);
            this.playTabPage.Location = new System.Drawing.Point(4, 25);
            this.playTabPage.Name = "playTabPage";
            this.playTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playTabPage.Size = new System.Drawing.Size(760, 437);
            this.playTabPage.TabIndex = 4;
            this.playTabPage.Text = "Play";
            this.playTabPage.UseVisualStyleBackColor = true;
            // 
            // axShockwaveFlash
            // 
            this.axShockwaveFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axShockwaveFlash.Enabled = true;
            this.axShockwaveFlash.Location = new System.Drawing.Point(40, 36);
            this.axShockwaveFlash.Name = "axShockwaveFlash";
            this.axShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState")));
            this.axShockwaveFlash.Size = new System.Drawing.Size(518, 267);
            this.axShockwaveFlash.TabIndex = 0;
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Location = new System.Drawing.Point(0, 142);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(795, 32);
            this.TabSelector.TabIndex = 1;
            this.TabSelector.Text = "materialTabSelector";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Video_Downloader.Properties.Resources.Screen_Shot_2012_12_09_at_11_00_23_AM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 658);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabControl);
            this.Name = "frmMain";
            this.Text = "Video Downloader";
            this.TabControl.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.searchTabPage.PerformLayout();
            this.searchContextMenuStrip.ResumeLayout(false);
            this.downloadTabPage.ResumeLayout(false);
            this.downloadTabPage.PerformLayout();
            this.convertTabPage.ResumeLayout(false);
            this.convertTabPage.PerformLayout();
            this.activityTabPage.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.playTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabPage downloadTabPage;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchTextField;
        private MaterialSkin.Controls.MaterialContextMenuStrip searchContextMenuStrip;
        private System.Windows.Forms.ListView searchListView;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private System.Windows.Forms.TabPage convertTabPage;
        private System.Windows.Forms.TabPage playTabPage;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash;
        private MaterialSkin.Controls.MaterialLabel urlLabel;
        private MaterialSkin.Controls.MaterialFlatButton btnDownload;
        private MaterialSkin.Controls.MaterialSingleLineTextField downloadUrlTextField;
        private MaterialSkin.Controls.MaterialProgressBar downloadProgressBar;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel locationLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField saveToTextField;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowse;
        private MaterialSkin.Controls.MaterialProgressBar searchProgressBar;
        private System.Windows.Forms.ToolStripMenuItem addToActivityToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton btnConvert;
        private MaterialSkin.Controls.MaterialSingleLineTextField fileLoadTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox qualityComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveTo;
        private MaterialSkin.Controls.MaterialSingleLineTextField fileSaveTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton btnLoadTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage activityTabPage;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStart;
        private System.Windows.Forms.ToolStripButton toolStartAll;
        private System.Windows.Forms.ToolStripButton toolPause;
        private System.Windows.Forms.ToolStripButton toolPauseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolRemove;
        private System.Windows.Forms.ToolStripButton toolRemoveCompleted;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolMoveSelectionsUp;
        private System.Windows.Forms.ToolStripButton toolMoveSelectionsDown;
        private System.Windows.Forms.ListView activityListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.ComponentModel.BackgroundWorker searchBackgroundWorker;
        private MaterialSkin.Controls.MaterialProgressBar convertProgressBar;
    }
}

