using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGJason
{
    
    public partial class AddinGen : Form
    {
        int i = -1;
        List<exClass> allClass;
        Dll dll;
        string vendorID,vendorDescription,path;
        public AddinGen()
        {
            InitializeComponent();
        }

        private void addinGen_Load(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            classes.Items.Clear();
            allClass = new List<exClass>();
            openFileDialog.ShowDialog();
            location.Text = openFileDialog.FileName;
            path = openFileDialog.FileName;

            if (Path.GetExtension(path) == ".dll")
            {
                dll = new Dll(path);
                int i = 0;

                foreach (exClass t in dll.Classes)
                {
                    classes.Items.Add(t);
                }
            }
            else
            {
            }
        }
        

        private void guidGen_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            guid.Text = g.ToString();
        }

        

        private void generateBut_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Autodesk\Revit\Addins\2017";
            sfd.FileName = DateTime.Now.ToString("yyyyMMdd-HHmmss")+".addin";
            sfd.ShowDialog();
            
            StreamWriter sw = new StreamWriter(Path.GetFullPath(sfd.FileName));
            sw.WriteLine(dll.exportAddin());
            sw.Close();

            MessageBox.Show("Success Save to \""+ Path.GetFullPath(sfd.FileName) + "\"","Success Generate",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void vendor_TextChanged(object sender, EventArgs e)
        {
            vendorID = vendor.Text;
        }

        private void VendorDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            vendorDescription = VendorDescriptionBox.Text;
        }

        private void classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i != -1)
            {
                allClass[i].GUID = Guid.Parse(guid.Text);
                allClass[i].Name = name.Text;
            }
            
            i = classes.SelectedIndex;
            type.Text = allClass.ElementAt(i).Type;
            guid.Text = allClass[i].GUID.ToString();
            name.Text = allClass[i].Name;

        }
    }
}
