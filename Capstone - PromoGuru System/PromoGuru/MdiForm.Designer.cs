namespace PromoGuru
{
    partial class MdiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontallyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticallyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.windowMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(894, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierMenuItem,
            this.productMenuItem,
            this.customerMenuItem,
            this.orderMenuItem});
            this.newMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMenuItem.Image")));
            this.newMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newMenuItem.Text = "&New";
            // 
            // supplierMenuItem
            // 
            this.supplierMenuItem.Name = "supplierMenuItem";
            this.supplierMenuItem.Size = new System.Drawing.Size(131, 22);
            this.supplierMenuItem.Text = "Supplier";
            // 
            // productMenuItem
            // 
            this.productMenuItem.Name = "productMenuItem";
            this.productMenuItem.Size = new System.Drawing.Size(131, 22);
            this.productMenuItem.Text = "Product";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customerMenuItem.Text = "Customer";
            // 
            // orderMenuItem
            // 
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Size = new System.Drawing.Size(131, 22);
            this.orderMenuItem.Text = "Order";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuItem.Image")));
            this.saveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveMenuItem.Text = "&Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.redoMenuItem,
            this.toolStripSeparator3,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.toolStripSeparator4,
            this.selectAllMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editMenuItem.Text = "&Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(150, 22);
            this.undoMenuItem.Text = "&Undo";
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redoMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutMenuItem.Image")));
            this.cutMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cutMenuItem.Text = "Cu&t";
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyMenuItem.Image")));
            this.copyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(150, 22);
            this.copyMenuItem.Text = "&Copy";
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteMenuItem.Image")));
            this.pasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pasteMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(147, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectAllMenuItem.Text = "Select &All";
            // 
            // windowMenuItem
            // 
            this.windowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierManagerMenuItem,
            this.customerManagerMenuItem,
            this.productManagerMenuItem,
            this.orderManagerMenuItem,
            this.toolStripSeparator1,
            this.viewAllMenuItem,
            this.tileMenuItem,
            this.cascadeMenuItem,
            this.tileHorizontallyMenuItem,
            this.tileVerticallyMenuItem,
            this.toolStripSeparator2,
            this.reportViewerMenuItem});
            this.windowMenuItem.Name = "windowMenuItem";
            this.windowMenuItem.Size = new System.Drawing.Size(57, 20);
            this.windowMenuItem.Text = "Window";
            // 
            // supplierManagerMenuItem
            // 
            this.supplierManagerMenuItem.CheckOnClick = true;
            this.supplierManagerMenuItem.Name = "supplierManagerMenuItem";
            this.supplierManagerMenuItem.Size = new System.Drawing.Size(176, 22);
            this.supplierManagerMenuItem.Text = "Supplier Manager";
            this.supplierManagerMenuItem.Click += new System.EventHandler(this.supplierManagerMenuItem_Click);
            // 
            // customerManagerMenuItem
            // 
            this.customerManagerMenuItem.CheckOnClick = true;
            this.customerManagerMenuItem.Name = "customerManagerMenuItem";
            this.customerManagerMenuItem.Size = new System.Drawing.Size(176, 22);
            this.customerManagerMenuItem.Text = "Customer Manager";
            this.customerManagerMenuItem.Click += new System.EventHandler(this.customerManagerMenuItem_Click);
            // 
            // productManagerMenuItem
            // 
            this.productManagerMenuItem.CheckOnClick = true;
            this.productManagerMenuItem.Name = "productManagerMenuItem";
            this.productManagerMenuItem.Size = new System.Drawing.Size(176, 22);
            this.productManagerMenuItem.Text = "Product Manager";
            this.productManagerMenuItem.Click += new System.EventHandler(this.productManagerMenuItem_Click);
            // 
            // orderManagerMenuItem
            // 
            this.orderManagerMenuItem.CheckOnClick = true;
            this.orderManagerMenuItem.Name = "orderManagerMenuItem";
            this.orderManagerMenuItem.Size = new System.Drawing.Size(176, 22);
            this.orderManagerMenuItem.Text = "Order Manager";
            this.orderManagerMenuItem.Click += new System.EventHandler(this.orderManagerMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // viewAllMenuItem
            // 
            this.viewAllMenuItem.Name = "viewAllMenuItem";
            this.viewAllMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewAllMenuItem.Text = "View All";
            // 
            // tileMenuItem
            // 
            this.tileMenuItem.Name = "tileMenuItem";
            this.tileMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tileMenuItem.Text = "Tile";
            // 
            // cascadeMenuItem
            // 
            this.cascadeMenuItem.Name = "cascadeMenuItem";
            this.cascadeMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cascadeMenuItem.Text = "Cascade";
            // 
            // tileHorizontallyMenuItem
            // 
            this.tileHorizontallyMenuItem.Name = "tileHorizontallyMenuItem";
            this.tileHorizontallyMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tileHorizontallyMenuItem.Text = "Tile Horizontally";
            // 
            // tileVerticallyMenuItem
            // 
            this.tileVerticallyMenuItem.Name = "tileVerticallyMenuItem";
            this.tileVerticallyMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tileVerticallyMenuItem.Text = "Tile Vertically";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpMenuItem.Text = "&Help";
            // 
            // contentsMenuItem
            // 
            this.contentsMenuItem.Name = "contentsMenuItem";
            this.contentsMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsMenuItem.Text = "&Contents";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutMenuItem.Text = "&About...";
            // 
            // reportViewerMenuItem
            // 
            this.reportViewerMenuItem.CheckOnClick = true;
            this.reportViewerMenuItem.Name = "reportViewerMenuItem";
            this.reportViewerMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reportViewerMenuItem.Text = "Report Viewer";
            this.reportViewerMenuItem.Click += new System.EventHandler(this.reportViewerMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 484);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MdiForm";
            this.Text = "MdiForm";
            this.Load += new System.EventHandler(this.MdiForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderManagerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontallyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticallyMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reportViewerMenuItem;
    }
}