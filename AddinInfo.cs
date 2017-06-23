using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGJason
{
    public partial class AddinInfo : Form
    {
        Dll dll;
        public AddinInfo(string path)
        {
            InitializeComponent();
            dll = new Dll(path);
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddinInfo_Load(object sender, EventArgs e)
        {
            classname.Text = dll.toString();
        }
    }
}
