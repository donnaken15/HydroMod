namespace HydroMod
{
    partial class h2omod
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("00009A00", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("0000C480", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("0000E124", 3, 3);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TRITON.LUX", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(h2omod));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.replaceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLuxDiag = new System.Windows.Forms.OpenFileDialog();
            this.luxView = new System.Windows.Forms.TreeView();
            this.comGfxKeys = new System.Windows.Forms.ImageList(this.components);
            this.spCnt = new System.Windows.Forms.SplitContainer();
            this.dataViewTabs = new System.Windows.Forms.TabControl();
            this.dataViewTImage = new System.Windows.Forms.TabPage();
            this.dataViewImage = new System.Windows.Forms.PictureBox();
            this.dataViewTBin = new System.Windows.Forms.TabPage();
            this.dataViewBin = new Be.Windows.Forms.HexBox();
            this.dataViewTText = new System.Windows.Forms.TabPage();
            this.dataViewText = new System.Windows.Forms.TextBox();
            this.dataViewTMeta = new System.Windows.Forms.TabPage();
            this.luxTextMeta = new System.Windows.Forms.Label();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.luxViewRoot = new System.Windows.Forms.Panel();
            this.saveLuxFDiag = new System.Windows.Forms.SaveFileDialog();
            this.luxFileCtxtM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.replaceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.luxCtnrCtxtM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.extractAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luxCtnrXtrctDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCnt)).BeginInit();
            this.spCnt.Panel1.SuspendLayout();
            this.spCnt.Panel2.SuspendLayout();
            this.spCnt.SuspendLayout();
            this.dataViewTabs.SuspendLayout();
            this.dataViewTImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewImage)).BeginInit();
            this.dataViewTBin.SuspendLayout();
            this.dataViewTText.SuspendLayout();
            this.dataViewTMeta.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.luxViewRoot.SuspendLayout();
            this.luxFileCtxtM.SuspendLayout();
            this.luxCtnrCtxtM.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0);
            this.menuBar.Size = new System.Drawing.Size(1078, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.replaceDataToolStripMenuItem,
            this.eraseDataToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::HydroMod.Properties.Resources.openHS;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.findLux);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::HydroMod.Properties.Resources.saveHS;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeLux);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(130, 6);
            // 
            // replaceDataToolStripMenuItem
            // 
            this.replaceDataToolStripMenuItem.Image = global::HydroMod.Properties.Resources.Unnestrelatedfiles_7219_32;
            this.replaceDataToolStripMenuItem.Name = "replaceDataToolStripMenuItem";
            this.replaceDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.replaceDataToolStripMenuItem.Text = "Replace File";
            // 
            // eraseDataToolStripMenuItem
            // 
            this.eraseDataToolStripMenuItem.Image = global::HydroMod.Properties.Resources.DeleteHS;
            this.eraseDataToolStripMenuItem.Name = "eraseDataToolStripMenuItem";
            this.eraseDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.eraseDataToolStripMenuItem.Text = "Erase File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Image = global::HydroMod.Properties.Resources.saveHS;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveLuxFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // legendToolStripMenuItem
            // 
            this.legendToolStripMenuItem.Image = global::HydroMod.Properties.Resources.LegendHS;
            this.legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.legendToolStripMenuItem.Text = "Legend";
            this.legendToolStripMenuItem.Click += new System.EventHandler(this.showLegend);
            // 
            // openLuxDiag
            // 
            this.openLuxDiag.FileName = "TRITON.LUX";
            this.openLuxDiag.Filter = "Generic LUX|*.lux|Triton LUX|triton.lux|Any file|*.*";
            this.openLuxDiag.Multiselect = true;
            this.openLuxDiag.RestoreDirectory = true;
            this.openLuxDiag.Title = "Open H2Overdrive Data File";
            this.openLuxDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.findLuxOk);
            // 
            // luxView
            // 
            this.luxView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luxView.FullRowSelect = true;
            this.luxView.ImageIndex = 0;
            this.luxView.ImageList = this.comGfxKeys;
            this.luxView.Location = new System.Drawing.Point(0, 0);
            this.luxView.Name = "luxView";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "test01addr";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "00009A00";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "test02addr";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "0000C480";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "0000E124";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "0000E124";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "test01";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "TRITON.LUX";
            this.luxView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.luxView.SelectedImageIndex = 0;
            this.luxView.Size = new System.Drawing.Size(219, 661);
            this.luxView.TabIndex = 1;
            this.luxView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.selectLuxFile);
            this.luxView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.luxViewClick);
            // 
            // comGfxKeys
            // 
            this.comGfxKeys.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("comGfxKeys.ImageStream")));
            this.comGfxKeys.TransparentColor = System.Drawing.Color.Transparent;
            this.comGfxKeys.Images.SetKeyName(0, "Unknown");
            this.comGfxKeys.Images.SetKeyName(1, "Container");
            this.comGfxKeys.Images.SetKeyName(2, "Image");
            this.comGfxKeys.Images.SetKeyName(3, "Audio");
            this.comGfxKeys.Images.SetKeyName(4, "XML");
            this.comGfxKeys.Images.SetKeyName(5, "INI");
            this.comGfxKeys.Images.SetKeyName(6, "Consolelog");
            // 
            // spCnt
            // 
            this.spCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCnt.Location = new System.Drawing.Point(0, 0);
            this.spCnt.Name = "spCnt";
            // 
            // spCnt.Panel1
            // 
            this.spCnt.Panel1.Controls.Add(this.luxView);
            // 
            // spCnt.Panel2
            // 
            this.spCnt.Panel2.Controls.Add(this.dataViewTabs);
            this.spCnt.Size = new System.Drawing.Size(1078, 661);
            this.spCnt.SplitterDistance = 219;
            this.spCnt.TabIndex = 2;
            // 
            // dataViewTabs
            // 
            this.dataViewTabs.Controls.Add(this.dataViewTImage);
            this.dataViewTabs.Controls.Add(this.dataViewTBin);
            this.dataViewTabs.Controls.Add(this.dataViewTText);
            this.dataViewTabs.Controls.Add(this.dataViewTMeta);
            this.dataViewTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewTabs.Location = new System.Drawing.Point(0, 0);
            this.dataViewTabs.Name = "dataViewTabs";
            this.dataViewTabs.SelectedIndex = 0;
            this.dataViewTabs.Size = new System.Drawing.Size(855, 661);
            this.dataViewTabs.TabIndex = 0;
            // 
            // dataViewTImage
            // 
            this.dataViewTImage.AutoScroll = true;
            this.dataViewTImage.Controls.Add(this.dataViewImage);
            this.dataViewTImage.Location = new System.Drawing.Point(4, 22);
            this.dataViewTImage.Name = "dataViewTImage";
            this.dataViewTImage.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTImage.Size = new System.Drawing.Size(847, 635);
            this.dataViewTImage.TabIndex = 0;
            this.dataViewTImage.Text = "Image View";
            this.dataViewTImage.UseVisualStyleBackColor = true;
            // 
            // dataViewImage
            // 
            this.dataViewImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataViewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataViewImage.Location = new System.Drawing.Point(3, 3);
            this.dataViewImage.Name = "dataViewImage";
            this.dataViewImage.Size = new System.Drawing.Size(512, 512);
            this.dataViewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dataViewImage.TabIndex = 0;
            this.dataViewImage.TabStop = false;
            // 
            // dataViewTBin
            // 
            this.dataViewTBin.Controls.Add(this.dataViewBin);
            this.dataViewTBin.Location = new System.Drawing.Point(4, 22);
            this.dataViewTBin.Name = "dataViewTBin";
            this.dataViewTBin.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTBin.Size = new System.Drawing.Size(847, 635);
            this.dataViewTBin.TabIndex = 1;
            this.dataViewTBin.Text = "Binary View";
            this.dataViewTBin.UseVisualStyleBackColor = true;
            // 
            // dataViewBin
            // 
            this.dataViewBin.ColumnInfoVisible = true;
            this.dataViewBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewBin.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataViewBin.GroupSize = 1;
            this.dataViewBin.InfoForeColor = System.Drawing.Color.Black;
            this.dataViewBin.LineInfoVisible = true;
            this.dataViewBin.Location = new System.Drawing.Point(3, 3);
            this.dataViewBin.Name = "dataViewBin";
            this.dataViewBin.ReadOnly = true;
            this.dataViewBin.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.dataViewBin.Size = new System.Drawing.Size(841, 629);
            this.dataViewBin.TabIndex = 1;
            this.dataViewBin.UseFixedBytesPerLine = true;
            this.dataViewBin.VScrollBarVisible = true;
            // 
            // dataViewTText
            // 
            this.dataViewTText.Controls.Add(this.dataViewText);
            this.dataViewTText.Location = new System.Drawing.Point(4, 22);
            this.dataViewTText.Name = "dataViewTText";
            this.dataViewTText.Size = new System.Drawing.Size(847, 635);
            this.dataViewTText.TabIndex = 2;
            this.dataViewTText.Text = "Text View";
            this.dataViewTText.UseVisualStyleBackColor = true;
            // 
            // dataViewText
            // 
            this.dataViewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataViewText.Location = new System.Drawing.Point(0, 0);
            this.dataViewText.Multiline = true;
            this.dataViewText.Name = "dataViewText";
            this.dataViewText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataViewText.Size = new System.Drawing.Size(847, 635);
            this.dataViewText.TabIndex = 0;
            // 
            // dataViewTMeta
            // 
            this.dataViewTMeta.Controls.Add(this.luxTextMeta);
            this.dataViewTMeta.Location = new System.Drawing.Point(4, 22);
            this.dataViewTMeta.Name = "dataViewTMeta";
            this.dataViewTMeta.Size = new System.Drawing.Size(847, 635);
            this.dataViewTMeta.TabIndex = 3;
            this.dataViewTMeta.Text = "Information";
            this.dataViewTMeta.UseVisualStyleBackColor = true;
            // 
            // luxTextMeta
            // 
            this.luxTextMeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luxTextMeta.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luxTextMeta.Location = new System.Drawing.Point(0, 0);
            this.luxTextMeta.Name = "luxTextMeta";
            this.luxTextMeta.Padding = new System.Windows.Forms.Padding(10);
            this.luxTextMeta.Size = new System.Drawing.Size(847, 635);
            this.luxTextMeta.TabIndex = 0;
            this.luxTextMeta.Text = "No file selected";
            // 
            // toolBar
            // 
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1078, 25);
            this.toolBar.TabIndex = 3;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::HydroMod.Properties.Resources.openHS;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.findLux);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::HydroMod.Properties.Resources.saveHS;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // luxViewRoot
            // 
            this.luxViewRoot.Controls.Add(this.spCnt);
            this.luxViewRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luxViewRoot.Location = new System.Drawing.Point(0, 49);
            this.luxViewRoot.Name = "luxViewRoot";
            this.luxViewRoot.Size = new System.Drawing.Size(1078, 661);
            this.luxViewRoot.TabIndex = 4;
            // 
            // saveLuxFDiag
            // 
            this.saveLuxFDiag.Filter = "Any file|*.*";
            this.saveLuxFDiag.RestoreDirectory = true;
            this.saveLuxFDiag.Title = "Save this file";
            this.saveLuxFDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.saveLuxFDiagOk);
            // 
            // luxFileCtxtM
            // 
            this.luxFileCtxtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luxFileCtxtM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceFileToolStripMenuItem,
            this.eraseFileToolStripMenuItem,
            this.saveFileToolStripMenuItem1});
            this.luxFileCtxtM.Name = "luxFileCtxtM";
            this.luxFileCtxtM.Size = new System.Drawing.Size(134, 70);
            // 
            // replaceFileToolStripMenuItem
            // 
            this.replaceFileToolStripMenuItem.Image = global::HydroMod.Properties.Resources.Unnestrelatedfiles_7219_32;
            this.replaceFileToolStripMenuItem.Name = "replaceFileToolStripMenuItem";
            this.replaceFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.replaceFileToolStripMenuItem.Text = "Replace File";
            // 
            // eraseFileToolStripMenuItem
            // 
            this.eraseFileToolStripMenuItem.Image = global::HydroMod.Properties.Resources.DeleteHS;
            this.eraseFileToolStripMenuItem.Name = "eraseFileToolStripMenuItem";
            this.eraseFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.eraseFileToolStripMenuItem.Text = "Erase File";
            // 
            // saveFileToolStripMenuItem1
            // 
            this.saveFileToolStripMenuItem1.Image = global::HydroMod.Properties.Resources.saveHS;
            this.saveFileToolStripMenuItem1.Name = "saveFileToolStripMenuItem1";
            this.saveFileToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.saveFileToolStripMenuItem1.Text = "Save File";
            this.saveFileToolStripMenuItem1.Click += new System.EventHandler(this.saveLuxFile);
            // 
            // luxCtnrCtxtM
            // 
            this.luxCtnrCtxtM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractAllToolStripMenuItem,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem1});
            this.luxCtnrCtxtM.Name = "luxCtnrCtxtM";
            this.luxCtnrCtxtM.Size = new System.Drawing.Size(131, 54);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeLux);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // extractAllToolStripMenuItem
            // 
            this.extractAllToolStripMenuItem.Name = "extractAllToolStripMenuItem";
            this.extractAllToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.extractAllToolStripMenuItem.Text = "Extract All...";
            this.extractAllToolStripMenuItem.Click += new System.EventHandler(this.luxCtnrXtrctAll);
            // 
            // luxCtnrXtrctDiag
            // 
            this.luxCtnrXtrctDiag.Description = "Extract all files from this Lux.";
            // 
            // h2omod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 710);
            this.Controls.Add(this.luxViewRoot);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "h2omod";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HydroMod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.spCnt.Panel1.ResumeLayout(false);
            this.spCnt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCnt)).EndInit();
            this.spCnt.ResumeLayout(false);
            this.dataViewTabs.ResumeLayout(false);
            this.dataViewTImage.ResumeLayout(false);
            this.dataViewTImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewImage)).EndInit();
            this.dataViewTBin.ResumeLayout(false);
            this.dataViewTText.ResumeLayout(false);
            this.dataViewTText.PerformLayout();
            this.dataViewTMeta.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.luxViewRoot.ResumeLayout(false);
            this.luxFileCtxtM.ResumeLayout(false);
            this.luxCtnrCtxtM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openLuxDiag;
        private System.Windows.Forms.TreeView luxView;
        private System.Windows.Forms.SplitContainer spCnt;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel luxViewRoot;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem replaceDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseDataToolStripMenuItem;
        private System.Windows.Forms.ImageList comGfxKeys;
        private System.Windows.Forms.TabControl dataViewTabs;
        private System.Windows.Forms.TabPage dataViewTImage;
        private System.Windows.Forms.TabPage dataViewTBin;
        private System.Windows.Forms.TabPage dataViewTText;
        private System.Windows.Forms.PictureBox dataViewImage;
        private System.Windows.Forms.TextBox dataViewText;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage dataViewTMeta;
        private System.Windows.Forms.Label luxTextMeta;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveLuxFDiag;
        private System.Windows.Forms.ContextMenuStrip luxFileCtxtM;
        private System.Windows.Forms.ToolStripMenuItem replaceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem1;
        private Be.Windows.Forms.HexBox dataViewBin;
        private System.Windows.Forms.ContextMenuStrip luxCtnrCtxtM;
        private System.Windows.Forms.ToolStripMenuItem extractAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.FolderBrowserDialog luxCtnrXtrctDiag;
    }
}

