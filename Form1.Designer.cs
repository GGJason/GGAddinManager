namespace GGJason
{
    partial class DisplayForm
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
            this.tagPage1 = new System.Windows.Forms.TabPage();
            this.commandsList = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.applicationsList = new System.Windows.Forms.TreeView();
            this.load = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.status = new System.Windows.Forms.TextBox();
            this.mainFrame.SuspendLayout();
            this.tagPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Location = new System.Drawing.Point(427, 307);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 12);
            this.sign.TabIndex = 0;
            this.sign.Text = "V 0.2 GGJason";
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // mainFrame
            // 
            this.mainFrame.Controls.Add(this.tagPage1);
            this.mainFrame.Controls.Add(this.tabPage2);
            this.mainFrame.Location = new System.Drawing.Point(12, 28);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.SelectedIndex = 0;
            this.mainFrame.Size = new System.Drawing.Size(490, 197);
            this.mainFrame.TabIndex = 2;
            // 
            // tagPage1
            // 
            this.tagPage1.Controls.Add(this.commandsList);
            this.tagPage1.Location = new System.Drawing.Point(4, 22);
            this.tagPage1.Name = "tagPage1";
            this.tagPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tagPage1.Size = new System.Drawing.Size(482, 171);
            this.tagPage1.TabIndex = 0;
            this.tagPage1.Tag = "";
            this.tagPage1.Text = "Loaded Commands";
            this.tagPage1.UseVisualStyleBackColor = true;
            // 
            // commandsList
            // 
            this.commandsList.CheckBoxes = true;
            this.commandsList.Location = new System.Drawing.Point(6, 6);
            this.commandsList.Name = "commandsList";
            this.commandsList.Size = new System.Drawing.Size(470, 159);
            this.commandsList.TabIndex = 6;
            this.commandsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.commandsList_AfterSelect);
            this.commandsList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.commandsList_NodeMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.applicationsList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "";
            this.tabPage2.Text = "Loaded Applications";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // applicationsList
            // 
            this.applicationsList.Location = new System.Drawing.Point(6, 6);
            this.applicationsList.Name = "applicationsList";
            this.applicationsList.Size = new System.Drawing.Size(470, 159);
            this.applicationsList.TabIndex = 0;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(429, 227);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(69, 32);
            this.load.TabIndex = 3;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(354, 227);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(69, 32);
            this.run.TabIndex = 4;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(354, 265);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(69, 32);
            this.remove.TabIndex = 5;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(514, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(22, 303);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(401, 22);
            this.status.TabIndex = 7;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 335);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.run);
            this.Controls.Add(this.load);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.sign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DisplayForm";
            this.Text = "Add-In Manager";
            this.mainFrame.ResumeLayout(false);
            this.tagPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.TabControl mainFrame;
        private System.Windows.Forms.TabPage tagPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView commandsList;
        private System.Windows.Forms.TreeView applicationsList;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox status;
    }
}