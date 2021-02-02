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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("00009A00", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("0000C480", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("0000E124", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TRITON.LUX", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(h2omod));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataViewBin = new System.Windows.Forms.TextBox();
            this.dataViewTText = new System.Windows.Forms.TabPage();
            this.dataViewText = new System.Windows.Forms.TextBox();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.luxViewRoot = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.spCnt.Panel1.SuspendLayout();
            this.spCnt.Panel2.SuspendLayout();
            this.spCnt.SuspendLayout();
            this.dataViewTabs.SuspendLayout();
            this.dataViewTImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewImage)).BeginInit();
            this.dataViewTBin.SuspendLayout();
            this.dataViewTText.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.luxViewRoot.SuspendLayout();
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
            this.menuBar.Size = new System.Drawing.Size(520, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
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
            this.luxView.ImageIndex = 0;
            this.luxView.ImageList = this.comGfxKeys;
            this.luxView.Location = new System.Drawing.Point(0, 0);
            this.luxView.Name = "luxView";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "test01addr";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "00009A00";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "test02addr";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "0000C480";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "0000E124";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "0000E124";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "test01";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "TRITON.LUX";
            this.luxView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.luxView.SelectedImageIndex = 0;
            this.luxView.Size = new System.Drawing.Size(132, 458);
            this.luxView.TabIndex = 1;
            this.luxView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.selectLuxFile);
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
            this.spCnt.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.spCnt.Size = new System.Drawing.Size(520, 458);
            this.spCnt.SplitterDistance = 132;
            this.spCnt.TabIndex = 2;
            // 
            // dataViewTabs
            // 
            this.dataViewTabs.Controls.Add(this.dataViewTImage);
            this.dataViewTabs.Controls.Add(this.dataViewTBin);
            this.dataViewTabs.Controls.Add(this.dataViewTText);
            this.dataViewTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewTabs.Location = new System.Drawing.Point(0, 0);
            this.dataViewTabs.Name = "dataViewTabs";
            this.dataViewTabs.SelectedIndex = 0;
            this.dataViewTabs.Size = new System.Drawing.Size(384, 458);
            this.dataViewTabs.TabIndex = 0;
            // 
            // dataViewTImage
            // 
            this.dataViewTImage.Controls.Add(this.dataViewImage);
            this.dataViewTImage.Location = new System.Drawing.Point(4, 22);
            this.dataViewTImage.Name = "dataViewTImage";
            this.dataViewTImage.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTImage.Size = new System.Drawing.Size(376, 432);
            this.dataViewTImage.TabIndex = 0;
            this.dataViewTImage.Text = "Image View";
            this.dataViewTImage.UseVisualStyleBackColor = true;
            // 
            // dataViewImage
            // 
            this.dataViewImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataViewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataViewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewImage.Location = new System.Drawing.Point(3, 3);
            this.dataViewImage.Name = "dataViewImage";
            this.dataViewImage.Size = new System.Drawing.Size(370, 426);
            this.dataViewImage.TabIndex = 0;
            this.dataViewImage.TabStop = false;
            // 
            // dataViewTBin
            // 
            this.dataViewTBin.Controls.Add(this.dataViewBin);
            this.dataViewTBin.Location = new System.Drawing.Point(4, 22);
            this.dataViewTBin.Name = "dataViewTBin";
            this.dataViewTBin.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTBin.Size = new System.Drawing.Size(376, 432);
            this.dataViewTBin.TabIndex = 1;
            this.dataViewTBin.Text = "Binary View";
            this.dataViewTBin.UseVisualStyleBackColor = true;
            // 
            // dataViewBin
            // 
            this.dataViewBin.BackColor = System.Drawing.SystemColors.Window;
            this.dataViewBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewBin.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataViewBin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataViewBin.Location = new System.Drawing.Point(3, 3);
            this.dataViewBin.Multiline = true;
            this.dataViewBin.Name = "dataViewBin";
            this.dataViewBin.ReadOnly = true;
            this.dataViewBin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataViewBin.Size = new System.Drawing.Size(370, 426);
            this.dataViewBin.TabIndex = 0;
            this.dataViewBin.Text = "        |00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F\r\n--------+--------------" +
    "---------------------------------\r\n00000000|00 00 00 00 00 00 00 00 00 00 00 00 " +
    "00 00 00 00";
            this.dataViewBin.WordWrap = false;
            // 
            // dataViewTText
            // 
            this.dataViewTText.Controls.Add(this.dataViewText);
            this.dataViewTText.Location = new System.Drawing.Point(4, 22);
            this.dataViewTText.Name = "dataViewTText";
            this.dataViewTText.Size = new System.Drawing.Size(376, 432);
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
            this.dataViewText.Size = new System.Drawing.Size(376, 432);
            this.dataViewText.TabIndex = 0;
            this.dataViewText.Text = "<root>\r\n    <node>Value</node>\r\n</root>";
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
            this.toolBar.Size = new System.Drawing.Size(520, 25);
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
            this.luxViewRoot.Size = new System.Drawing.Size(520, 458);
            this.luxViewRoot.TabIndex = 4;
            // 
            // h2omod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 507);
            this.Controls.Add(this.luxViewRoot);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "h2omod";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HydroMod";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.spCnt.Panel1.ResumeLayout(false);
            this.spCnt.Panel2.ResumeLayout(false);
            this.spCnt.ResumeLayout(false);
            this.dataViewTabs.ResumeLayout(false);
            this.dataViewTImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewImage)).EndInit();
            this.dataViewTBin.ResumeLayout(false);
            this.dataViewTBin.PerformLayout();
            this.dataViewTText.ResumeLayout(false);
            this.dataViewTText.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.luxViewRoot.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox dataViewBin;
        private System.Windows.Forms.TextBox dataViewText;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

