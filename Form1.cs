using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
namespace GGJason
{
    public partial class DisplayForm : System.Windows.Forms.Form
    {
        ExternalCommandData data; 
        string msg;
        ElementSet elements;
        public DisplayForm(ExternalCommandData d, ref string m, ElementSet e)
        {
            data = d;
            msg =  m;
            elements = e;
            InitializeComponent();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://ggjason.tw/revitapi/");
            Process.Start(sInfo);
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            status.Text = "";
            string[] files = ofd.FileNames;
            int count = 0;
            foreach (string file in files)
            {
                if (count != 0)
                    status.Text += ", ";
                //               MessageBox.Show(Path.GetExtension(file));
                status.Text += Path.GetFileName(file) + " : ";
                if (Path.GetExtension(file) == ".dll")
                {

                    Assembly ass = Assembly.LoadFrom(file);
                    int i = 0;
                    
                    foreach (Type t in ass.GetTypes())
                    {
                        if (i++ != 0)
                            status.Text += ", ";
                        status.Text += t;
                        if (t.GetInterface("IExternalCommand") != null)
                        {
                            bool find = false;
                            foreach (TreeNode node in commandsList.Nodes)
                            {
                                if (node.Text == Path.GetFileName(file))
                                {
                                    find = true;
                                    commandsList.Nodes[node.Index].Nodes.Add(t.ToString());
                                }
                            }
                            if (!find)
                            {
                                commandsList.Nodes.Add(Path.GetFileName(file));
                                commandsList.Nodes[commandsList.Nodes.Count - 1].Tag = file;
                                commandsList.Nodes[commandsList.Nodes.Count - 1].Nodes.Add(t.ToString());
                            }
                        }
                        else if (t.GetInterface("IExternalApplication") != null)
                        {
                            bool find = false;
                            foreach (TreeNode node in applicationsList.Nodes)
                            {
                                if (node.Text == Path.GetFileName(file))
                                {
                                    find = true;
                                    applicationsList.Nodes[node.Index].Nodes.Add(t.ToString());
                                }
                            }
                            if (!find)
                            {
                                applicationsList.Nodes.Add(Path.GetFileName(file));
                                applicationsList.Nodes[applicationsList.Nodes.Count - 1].Nodes.Add(t.ToString());
                            }
                        }
                    }
                }
                else
                {
                    status.Text += "Not .dll";
                }
                count++;
            }
        }

        private void commandsList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void commandsList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = sender as TreeNode;
            Assembly assembly = Assembly.LoadFile(node.Tag.ToString());
            foreach(Type t in assembly.GetTypes())
            {
                if (t.Name == node.Text)
                {
                    MethodInfo m = t.GetMethod("Execute");
                    var o = Activator.CreateInstance(t);
                    object[] p = new object[3];
                    p[0] = data;
                    p[1] = msg;
                    p[2] = elements;
                    MessageBox.Show(o.ToString());
                    var result = m.Invoke(o, p);
                }
            }
        }
    }
}
