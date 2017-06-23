namespace GGJason
{
    partial class main
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
            this.sign = new System.Windows.Forms.Label();
            this.mainFrame = new System.Windows.Forms.TabControl();
            this.commandPage = new System.Windows.Forms.TabPage();
            this.commandsList = new System.Windows.Forms.TreeView();
            this.appPage = new System.Windows.Forms.TabPage();
            this.applicationsList = new System.Windows.Forms.TreeView();
            this.folderPage = new System.Windows.Forms.TabPage();
            this.folderList = new System.Windows.Forms.TreeView();
            this.load = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.folder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.install = new System.Windows.Forms.Button();
            this.online = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.info = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.addinGen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainFrame.SuspendLayout();
            this.commandPage.SuspendLayout();
            this.appPage.SuspendLayout();
            this.folderPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Location = new System.Drawing.Point(554, 222);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 12);
            this.sign.TabIndex = 0;
            this.sign.Text = "V 0.4 GGJason";
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // mainFrame
            // 
            this.mainFrame.Controls.Add(this.commandPage);
            this.mainFrame.Controls.Add(this.appPage);
            this.mainFrame.Controls.Add(this.folderPage);
            this.mainFrame.Location = new System.Drawing.Point(118, 37);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.SelectedIndex = 0;
            this.mainFrame.Size = new System.Drawing.Size(402, 197);
            this.mainFrame.TabIndex = 2;
            // 
            // commandPage
            // 
            this.commandPage.Controls.Add(this.commandsList);
            this.commandPage.Location = new System.Drawing.Point(4, 22);
            this.commandPage.Name = "commandPage";
            this.commandPage.Padding = new System.Windows.Forms.Padding(3);
            this.commandPage.Size = new System.Drawing.Size(394, 171);
            this.commandPage.TabIndex = 0;
            this.commandPage.Tag = "";
            this.commandPage.Text = "Loaded Commands";
            this.commandPage.UseVisualStyleBackColor = true;
            // 
            // commandsList
            // 
            this.commandsList.CheckBoxes = true;
            this.commandsList.Location = new System.Drawing.Point(6, 6);
            this.commandsList.Name = "commandsList";
            this.commandsList.Size = new System.Drawing.Size(382, 159);
            this.commandsList.TabIndex = 6;
            this.commandsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.commandsList_AfterSelect);
            this.commandsList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.commandsList_NodeMouseClick);
            this.commandsList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.commandsList_NodeMouseDoubleClick);
            // 
            // appPage
            // 
            this.appPage.Controls.Add(this.applicationsList);
            this.appPage.Location = new System.Drawing.Point(4, 22);
            this.appPage.Name = "appPage";
            this.appPage.Padding = new System.Windows.Forms.Padding(3);
            this.appPage.Size = new System.Drawing.Size(394, 171);
            this.appPage.TabIndex = 1;
            this.appPage.Tag = "";
            this.appPage.Text = "Loaded Applications";
            this.appPage.UseVisualStyleBackColor = true;
            // 
            // applicationsList
            // 
            this.applicationsList.CheckBoxes = true;
            this.applicationsList.Location = new System.Drawing.Point(6, 6);
            this.applicationsList.Name = "applicationsList";
            this.applicationsList.Size = new System.Drawing.Size(382, 159);
            this.applicationsList.TabIndex = 0;
            // 
            // folderPage
            // 
            this.folderPage.Controls.Add(this.folderList);
            this.folderPage.Location = new System.Drawing.Point(4, 22);
            this.folderPage.Name = "folderPage";
            this.folderPage.Size = new System.Drawing.Size(394, 171);
            this.folderPage.TabIndex = 2;
            this.folderPage.Text = "Loaded Folder";
            this.folderPage.UseVisualStyleBackColor = true;
            // 
            // folderList
            // 
            this.folderList.CheckBoxes = true;
            this.folderList.Location = new System.Drawing.Point(6, 6);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(382, 159);
            this.folderList.TabIndex = 1;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(8, 21);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(86, 32);
            this.load.TabIndex = 3;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(16, 59);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(69, 32);
            this.run.TabIndex = 4;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(16, 21);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(69, 32);
            this.remove.TabIndex = 5;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(118, 6);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(402, 22);
            this.status.TabIndex = 7;
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(8, 59);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(86, 32);
            this.folder.TabIndex = 9;
            this.folder.Text = "Load Folder";
            this.folder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.install);
            this.groupBox1.Controls.Add(this.online);
            this.groupBox1.Controls.Add(this.load);
            this.groupBox1.Controls.Add(this.folder);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add-in Source";
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(8, 97);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(86, 32);
            this.install.TabIndex = 11;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // online
            // 
            this.online.Location = new System.Drawing.Point(8, 135);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(86, 32);
            this.online.TabIndex = 10;
            this.online.Text = "Online Source";
            this.online.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.info);
            this.groupBox2.Controls.Add(this.export);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.remove);
            this.groupBox2.Controls.Add(this.run);
            this.groupBox2.Location = new System.Drawing.Point(526, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 210);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add-in Action";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(16, 97);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(69, 32);
            this.info.TabIndex = 8;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(16, 173);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(69, 32);
            this.export.TabIndex = 7;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 135);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(69, 32);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // addinGen
            // 
            this.addinGen.Location = new System.Drawing.Point(20, 192);
            this.addinGen.Name = "addinGen";
            this.addinGen.Size = new System.Drawing.Size(86, 42);
            this.addinGen.TabIndex = 12;
            this.addinGen.Text = ".Addin Generator";
            this.addinGen.UseVisualStyleBackColor = true;
            this.addinGen.Click += new System.EventHandler(this.addinGen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 240);
            this.Controls.Add(this.addinGen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Add-In Manager";
            this.Load += new System.EventHandler(this.main_Load);
            this.mainFrame.ResumeLayout(false);
            this.commandPage.ResumeLayout(false);
            this.appPage.ResumeLayout(false);
            this.folderPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.TabControl mainFrame;
        private System.Windows.Forms.TabPage commandPage;
        private System.Windows.Forms.TabPage appPage;
        private System.Windows.Forms.TreeView commandsList;
        private System.Windows.Forms.TreeView applicationsList;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.TabPage folderPage;
        private System.Windows.Forms.TreeView folderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button online;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button addinGen;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}