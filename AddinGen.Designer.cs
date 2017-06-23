namespace GGJason
{
    partial class AddinGen
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
            this.vendor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.guid = new System.Windows.Forms.TextBox();
            this.guidGen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.classDescription = new System.Windows.Forms.TextBox();
            this.classes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VendorDescriptionBox = new System.Windows.Forms.TextBox();
            this.generateBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendor
            // 
            this.vendor.Location = new System.Drawing.Point(120, 15);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(121, 22);
            this.vendor.TabIndex = 0;
            this.vendor.TextChanged += new System.EventHandler(this.vendor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(81, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 22);
            this.name.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Addin ID: ";
            // 
            // guid
            // 
            this.guid.Location = new System.Drawing.Point(162, 126);
            this.guid.Name = "guid";
            this.guid.Size = new System.Drawing.Size(300, 22);
            this.guid.TabIndex = 10;
            // 
            // guidGen
            // 
            this.guidGen.Location = new System.Drawing.Point(81, 126);
            this.guidGen.Name = "guidGen";
            this.guidGen.Size = new System.Drawing.Size(75, 23);
            this.guidGen.TabIndex = 11;
            this.guidGen.Text = "Regenerate";
            this.guidGen.UseVisualStyleBackColor = true;
            this.guidGen.Click += new System.EventHandler(this.guidGen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.classDescription);
            this.groupBox1.Controls.Add(this.classes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.guidGen);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.guid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 160);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Description";
            // 
            // classDescription
            // 
            this.classDescription.Location = new System.Drawing.Point(239, 40);
            this.classDescription.Multiline = true;
            this.classDescription.Name = "classDescription";
            this.classDescription.Size = new System.Drawing.Size(223, 80);
            this.classDescription.TabIndex = 17;
            // 
            // classes
            // 
            this.classes.FormattingEnabled = true;
            this.classes.Location = new System.Drawing.Point(81, 15);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(152, 20);
            this.classes.TabIndex = 16;
            this.classes.SelectedIndexChanged += new System.EventHandler(this.classes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Class: ";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(79, 76);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(14, 12);
            this.type.TabIndex = 14;
            this.type.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Addin Type: ";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(123, 9);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 16;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(204, 9);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(278, 22);
            this.location.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Location (Assembly):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.VendorDescriptionBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.vendor);
            this.groupBox2.Location = new System.Drawing.Point(14, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 104);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendor Infomation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vendor Description: ";
            // 
            // VendorDescriptionBox
            // 
            this.VendorDescriptionBox.Location = new System.Drawing.Point(120, 43);
            this.VendorDescriptionBox.Multiline = true;
            this.VendorDescriptionBox.Name = "VendorDescriptionBox";
            this.VendorDescriptionBox.Size = new System.Drawing.Size(342, 52);
            this.VendorDescriptionBox.TabIndex = 19;
            this.VendorDescriptionBox.TextChanged += new System.EventHandler(this.VendorDescriptionBox_TextChanged);
            // 
            // generateBut
            // 
            this.generateBut.Location = new System.Drawing.Point(401, 326);
            this.generateBut.Name = "generateBut";
            this.generateBut.Size = new System.Drawing.Size(75, 23);
            this.generateBut.TabIndex = 18;
            this.generateBut.Text = "Generate";
            this.generateBut.UseVisualStyleBackColor = true;
            this.generateBut.Click += new System.EventHandler(this.generateBut_Click);
            // 
            // AddinGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.generateBut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddinGen";
            this.Text = ".Addin Generator";
            this.Load += new System.EventHandler(this.addinGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox guid;
        private System.Windows.Forms.Button guidGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox classes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox classDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VendorDescriptionBox;
        private System.Windows.Forms.Button generateBut;
    }
}