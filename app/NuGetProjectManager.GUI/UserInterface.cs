using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NuGetProjectManager.GUI
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnFillProjectList_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo parentDirectory = new System.IO.DirectoryInfo(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\projectList");
            foreach (System.IO.FileInfo f in parentDirectory.GetFiles())
            {
                lbProjectList.Items.Add(f.Name);
            }
        }

        private void btnFillAssembleList_Click(object sender, EventArgs e)
        {
            var selectedValue = lbProjectList.SelectedItem.ToString();
            clbAssemblieSelect.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\projectList\" + selectedValue));         
        }
    }
}
