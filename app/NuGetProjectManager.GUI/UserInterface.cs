using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using NuGetProjectManager.Core;

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
            //System.IO.DirectoryInfo parentDirectory = new System.IO.DirectoryInfo(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\assemblies");
            foreach (System.IO.FileInfo f in parentDirectory.GetFiles())
            {
                lbProjectList.Items.Add(f.Name);
            }
        }

        private void lbProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbAssemblieSelect.Items.Clear();
            var selectedValue = lbProjectList.SelectedItem.ToString();
            clbAssemblieSelect.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\projectlist\" + selectedValue));
        }

        private void btnCreateNuspec_Click(object sender, EventArgs e)
        {
            string AssemblieList = "";
            if (clbAssemblieSelect.CheckedItems.Count != 0)
            {
                for (int x = 0; x <= clbAssemblieSelect.CheckedItems.Count - 1; x++)
                {
                    if(x > 0)
                    {
                        AssemblieList = AssemblieList + clbAssemblieSelect.CheckedItems[x].ToString() + ",";
                    }
                    else
                    {
                        AssemblieList = clbAssemblieSelect.CheckedItems[x].ToString();
                    }
                }

                MessageBox.Show(AssemblieList);
                NuspecConfig testConfig = new NuspecConfig("812");
                XmlNuspec testSpec = new XmlNuspec();
                XDocument testXDoc = testSpec.CreateNuspec(testConfig);

                testXDoc.Save(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\data\xmlNuspec.xml.nuspec", SaveOptions.None);
                string nugetPath = @"C:\Visual Studios\nuget\nuget.exe";
                string nugetArg = @"C:\Visual Studios\projects\NuGetProjectManager\tmp\data\xmlNuspec.xml.nuspec";
                var dbgP = Process.Start(nugetPath, $"pack \"{nugetArg}\"");
                MessageBox.Show("parsing done");
            }
            else
            {
                MessageBox.Show("Keine Einträge ausgewählt.");
            }
        }
    }
}