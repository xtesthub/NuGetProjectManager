using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using NuGetProjectManager.Core;
using System.Configuration;
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
            System.IO.DirectoryInfo parentDirectory = new System.IO.DirectoryInfo(ConfigurationManager.AppSettings["pathToProjectList"]);
            foreach (System.IO.FileInfo file in parentDirectory.GetFiles())
            {
                lbProjectList.Items.Add(file.Name);
            }
        }

        private void lbProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbAssemblySelect.Items.Clear();
            var selectedValue = lbProjectList.SelectedItem.ToString();
            clbAssemblySelect.Items.AddRange(System.IO.File.ReadAllLines(ConfigurationManager.AppSettings["pathToProjectList"] + selectedValue));
        }

        private void btnCreateNuspec_Click(object sender, EventArgs e)
        {
            //copy selected Files to buildDirectory
            //File.Copy(ConfigurationManager.AppSettings["pathToProjectList"], ConfigurationManager.AppSettings["pathToBuildDirectory"]);
            string AssemblyList = "";
            if (clbAssemblySelect.CheckedItems.Count != 0)
            {
                for (int x = 0; x <= clbAssemblySelect.CheckedItems.Count - 1; x++)
                {
                    string filePath = ConfigurationManager.AppSettings["pathToAssemblies"] + clbAssemblySelect.CheckedItems[x].ToString();
                    if(!Directory.Exists(ConfigurationManager.AppSettings["pathToBuildDirectory"]))
                    {
                        Directory.CreateDirectory(ConfigurationManager.AppSettings["pathToBuildDirectory"]);
                        MessageBox.Show(ConfigurationManager.AppSettings["pathToBuildDirectory"] + " nicht gefunden. Verzeichnis wurde angelegt.");

                    }

                    string destinationPath = ConfigurationManager.AppSettings["pathToBuildDirectory"] + clbAssemblySelect.CheckedItems[x].ToString();
                    if (!File.Exists(destinationPath))
                    {
                        File.Copy(filePath, destinationPath);
                    }
                    else
                    {
                        MessageBox.Show("Datei befindet sich bereits im Zielverzeichnis.");
                    }
                    


                    if (x > 0)
                    {
                        AssemblyList += "," + clbAssemblySelect.CheckedItems[x].ToString();                        
                    }
                    else
                    {
                        AssemblyList = clbAssemblySelect.CheckedItems[x].ToString();
                    }

                }

                MessageBox.Show(AssemblyList);
                NuspecConfig testConfig = new NuspecConfig(AssemblyList);
                XmlNuspec testSpec = new XmlNuspec();
                XDocument testXDoc = testSpec.CreateNuspec(testConfig);

                testXDoc.Save(ConfigurationManager.AppSettings["pathToNuspecFile"], SaveOptions.None);
                string nugetPath = ConfigurationManager.AppSettings["pathToNugetExe"];
                string nugetArg = ConfigurationManager.AppSettings["pathToNuspecFile"];

                var dbgP = Process.Start(nugetPath, $"pack \"{nugetArg}\"");
                MessageBox.Show("parsing done");
            }
            else
            {
                MessageBox.Show("Keine Einträge ausgewählt.");
            }
        }

        private void newListBoxProjectDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] subdirectoryEntries = Directory.GetDirectories();
            foreach (string subdirectory in subdirectoryEntries)
            {
                newListBoxProjectDir.Items.Add(subdirectory);
            }
        }
    }
}