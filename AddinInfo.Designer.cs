namespace GGJason
{
    partial class AddinInfo
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
            this.finish = new System.Windows.Forms.Button();
            this.classname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(197, 226);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 0;
            this.finish.Text = "button1";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // classname
            // 
            this.classname.AutoSize = true;
            this.classname.Location = new System.Drawing.Point(13, 13);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(33, 12);
            this.classname.TabIndex = 1;
            this.classname.Text = "label1";
            // 
            // AddinInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.finish);
            this.Name = "AddinInfo";
            this.Text = "addin_info";
            this.Load += new System.EventHandler(this.AddinInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label classname;
    }
}