using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace GGJason
{
    public partial class main : System.Windows.Forms.Form
    {
        ExternalCommandData data;
        string msg;
        ElementSet elements;
        public main(ExternalCommandData d, ref string m, ElementSet e)
        {
            data = d;
            msg = m;
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
                                    commandsList.Nodes[node.Index].Nodes[node.Nodes.Count - 1].Tag = file;
                                }
                            }
                            if (!find)
                            {
                                commandsList.Nodes.Add(Path.GetFileName(file));
                                commandsList.Nodes[commandsList.Nodes.Count - 1].Tag = file;
                                commandsList.Nodes[commandsList.Nodes.Count - 1].Nodes.Add(t.ToString());
                                commandsList.Nodes[commandsList.Nodes.Count - 1].Nodes[commandsList.Nodes.Count - 1].Tag = file;
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

            TreeNode node = e.Node;
    
            Assembly assembly = Assembly.LoadFile(node.Tag.ToString());
            foreach (Type t in assembly.GetTypes())
            {
                if (t.Name == node.Text)
                {
 /*                   Type type = LoadDllWithReflection(node.Tag.ToString(),"Execute");

                    IExternalCommand command = GetCommandFromType(type);

                    command.Execute(data,ref msg,elements);
 */                   MethodInfo m = t.GetMethod("Execute");
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
        public static Type LoadDll(string dllLocation, string className)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllLocation);
                Type type = assembly.GetType(className);
                return type;
            }
            catch (ReflectionTypeLoadException ex)
            {
                var exceptions = ex.LoaderExceptions;
                foreach (var failedType in ex.Types)
                {
                    if (failedType != null)
                        Debug.WriteLine(failedType.FullName);
                }
                foreach (Exception loadException in exceptions)
                {
                    Debug.WriteLine(loadException.ToString());
                }
                
            }
            return null;
        }


        public static Type LoadDllWithReflection(string dllLocation,string className)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllLocation);
                Type type = assembly.GetType(className);
                return type;
            }
            catch (ReflectionTypeLoadException ex)
            {
                var exceptions = ex.LoaderExceptions;
                foreach (var failedType in ex.Types)
                {
                    if (failedType != null)
                        Debug.WriteLine(failedType.FullName);
                }
                foreach (Exception loadException in exceptions)
                {
                    Debug.WriteLine(loadException.ToString());
                }
            }
            return null;
        }

        public static IExternalCommand GetCommandFromType(Type type)
        {
            IExternalCommand command = Activator.CreateInstance(type)
     as IExternalCommand;

            if (command == null)
                throw new Exception("Could not get Remote Command");
            return command;
        }

        private void commandsList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            
            string[] files = Directory.GetFiles(@"C:\ProgramData\Autodesk\Revit\Addins\2017");
            int count = 0;
            folderList.Nodes.Add(@"C:\ProgramData\Autodesk\Revit\Addins\2017");
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".dll" || Path.GetExtension(file) == ".dll")
                {

                    Assembly ass = Assembly.LoadFrom(file);
                    int i = 0;

                    foreach (Type t in ass.GetTypes())
                    {
                        if (t.GetInterface("IExternalCommand") != null)
                        {
                            bool find = false;
                            foreach (TreeNode node in folderList.Nodes)
                            {
                                if (node.Text == Path.GetFileName(file))
                                {
                                    find = true;
                                    folderList.Nodes[node.Index].Nodes.Add(t.ToString());
                                    folderList.Nodes[node.Index].Nodes[node.Nodes.Count - 1].Tag = file;
                                }
                            }
                            if (!find)
                            {
                                folderList.Nodes.Add(Path.GetFileName(file));
                                folderList.Nodes[folderList.Nodes.Count - 1].Tag = file;
                                folderList.Nodes[folderList.Nodes.Count - 1].Nodes.Add(t.ToString());
                                folderList.Nodes[folderList.Nodes.Count - 1].Nodes[folderList.Nodes[folderList.Nodes.Count - 1].Nodes.Count - 1].Tag = file;
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
                }
                count++;
            }
        }

        private void addinGen_Click(object sender, EventArgs e)
        {
            AddinGen addg = new AddinGen();
            addg.Show();
        }

        private void install_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string addinpath = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Autodesk\Revit\Addins\2017\" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".addin";
                string dllpath = Dll.repeatFileName(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Autodesk\Revit\Addins\2017\" + Path.GetFileName(ofd.FileName));
                //MessageBox.Show(dllpath);
                File.Copy(Path.GetFullPath(ofd.FileName), dllpath);
                Dll d = new Dll(dllpath);

                StreamWriter sw = new StreamWriter(addinpath);
                sw.WriteLine(d.exportAddin());
                sw.Close();

                MessageBox.Show("Success Save to \"" + d.toString() + "\" and create .addin manifest file.", "Success Install", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            TreeView tv = null ;
            switch (mainFrame.SelectedIndex)
            {
                case 0:
                    tv = commandsList;
                    break;
                case 1:
                    tv = applicationsList;
                    break;
                case 2:
                    tv = folderList;
                    break;
            }
            AddinInfo ai = new AddinInfo(tv.SelectedNode.Tag.ToString());
            ai.Show();
        }
    }
}
  
