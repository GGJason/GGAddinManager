using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace GGJason
{
    class Addin
    {
    }

    class Dll
    {
        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private List<exClass> _classes;
        public List<exClass> Classes
        {
            get { return _classes; }
            set { _classes = value; }
        }
        public Dll(string location)
        {
            Location = location;
            Classes = new List<exClass>();
            if (Path.GetExtension(Location) == ".dll")
            {
                Assembly ass = Assembly.LoadFrom(Location);
                foreach (Type t in ass.GetTypes())
                {
                    if (t.GetInterface("IExternalCommand") != null)
                        Classes.Add(new exClass(Location, t.ToString(), "Command"));

                    else if (t.GetInterface("IExternalApplication") != null)
                        Classes.Add(new exClass(Location, t.ToString(), "Application"));

                }
            }

        }
        public string exportAddin()
        {
            string str = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>\n<RevitAddIns > ";
            foreach (exClass ele in Classes)
                str += (Manifest(ele));

            str += "</RevitAddIns > ";
            return str;
        }
        public static string Manifest(exClass c)
        {
            string exp = "<AddIn Type = \"" + c.Type + "\" >\n";
            exp += "<Name>" + c.Name + "</Name>\n";
            exp += "<FullClassName>" + c.ClassName + "</FullClassName>\n";
            exp += "<Text>" + c.Text + "</Text>\n";
            exp += "<Description>" + c.Text + "</Description>\n";
            exp += "<VisibilityMode>" + c.Visibility + "</VisibilityMode>\n";
            exp += "<AddInId>" + c.GUID.ToString() + "</AddInId>\n";

            exp += "<Assembly>" + c.Location + "</Assembly>\n";
            exp += "<VendorId>ADSK</VendorId>\n";
            exp += "<VendorDescription>http://www.autodesk.com</VendorDescription>\n";
            exp += "</AddIn>\n";
            return exp;
        }
        public string toString()
        {
            string str = Location + ":";
            foreach (exClass c in Classes)
            {
                str += " " + c.ClassName + ",";
            }
            return str;
        }
        public static string repeatFileName(string fullPath)
        {
            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            string extension = Path.GetExtension(fullPath);
            string path = Path.GetDirectoryName(fullPath);
            string newFullPath = fullPath;

            while (File.Exists(newFullPath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(path, tempFileName + extension);
            }
            return newFullPath;

        }
    }
    public class exClass
    {
        public const string AlwaysVisible = "AlwaysVisible";
        public const string NotVisibleInProject = "NotVisibleInProject";
        public const string NotVisibleInFamily = "NotVisibleInFamily";
        public const string NotVisibleWhenNoActiveDocument = "NotVisibleWhenNoActiveDocument";
        public const string NotVisibleInArchitecture = "NotVisibleInArchitecture";
        public const string NotVisibleInStructure = "NotVisibleInStructure";
        public const string NotVisibleInMechanical = "NotVisibleInMechanical";
        public const string NotVisibleInElectrical = "NotVisibleInElectrical";
        public const string NotVisibleInPlumbing = "NotVisibleInPlumbing";
        public const string NotVisibleInMEP = "NotVisibleInMEP";
        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _classname;
        public string ClassName
        {
            get { return _classname; }
            set { _classname = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _visibility;
        public string Visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }
        private Guid _guid;
        public Guid GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }

        public exClass(string path, string name, string type)
        {
            Location = path;
            ClassName = name;
            Name = name;
            Type = type;
            GUID = Guid.NewGuid();
            Visibility = AlwaysVisible;
        }
    }
}
