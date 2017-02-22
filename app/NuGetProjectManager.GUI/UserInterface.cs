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
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;

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

        private void btnCreateNuspec_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("nuspecConfig.xml");
            NuspecConfig testConfig = new NuspecConfig("100");

            XElement dependencies = new XElement("dependency");
            dependencies.SetAttributeValue("id", testConfig.dependenciesId);
            dependencies.SetAttributeValue("version", testConfig.dependenciesVersion);

            XDocument xmlNuspec = new XDocument(
                new XElement("package",
                    new XElement("metadata",
                        new XElement("id", testConfig.id),
                        new XElement("version", testConfig.version),
                        new XElement("authors", testConfig.authors),
                        new XElement("owners", testConfig.owners),
                        new XElement("licenseUrl", testConfig.licenseUrl),
                        new XElement("projectUrl", testConfig.projectUrl),
                        new XElement("iconUrl", testConfig.iconUrl),
                        new XElement("requireLicenseAcceptance", testConfig.requireLicenseAcceptance),
                        new XElement("description", testConfig.description),
                        new XElement("releaseNotes", testConfig.releaseNotes),
                        new XElement("copyright", testConfig.copyright),
                        new XElement("tags", testConfig.tags),
                        new XElement("dependencies", dependencies)
                    )
                )
            );
            string nugetPath = @"C:\Visual Studios\nuget\nuget.exe";
            string nugetArg = @"C:\Visual Studios\projects\NuGetProjectManager\tmp\data\xmlNuspec.xml.nuspec";
            xmlNuspec.Save(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\data\xmlNuspec.xml.nuspec", SaveOptions.None);
            MessageBox.Show(".nuspec angelegt");
            var dbgP = Process.Start(nugetPath, $"pack \"{nugetArg}\"");
            MessageBox.Show("parsing done");
        }

        private void lNuspecOutput_Click(object sender, EventArgs e)
        {

        }
        struct NuspecConfig
        {
            public string id;
            public string version;
            public string authors;
            public string owners;
            public Uri licenseUrl;
            public Uri projectUrl;
            public Uri iconUrl;
            public string requireLicenseAcceptance;
            public string description;
            public string releaseNotes;
            public string copyright;
            public string tags;
            public string dependenciesId;
            public string dependenciesVersion;

            public NuspecConfig(string _id = "no id")
            {
                id = _id;
                version = "1.0.0";
                authors = "no authors";
                owners = "no authors";
                licenseUrl = new Uri("http://127.0.0.1/");
                projectUrl = new Uri("http://127.0.0.1/");
                iconUrl = new Uri("http://127.0.0.1/");
                requireLicenseAcceptance = "false";
                description = "no description";
                releaseNotes = "no releaseNotes";
                copyright = "no copyright";
                tags = "no tags";
                dependenciesId = "NoDependencies";
                dependenciesVersion = "1.0";
            }
        }
                 
        struct XmlNuspec
        {
            public XDocument XmlNuspec(NuspecConfig config)
            {
                XElement dependencies = new XElement("dependency");
                dependencies.SetAttributeValue("id", config.dependenciesId);
                dependencies.SetAttributeValue("version", config.dependenciesVersion);

                XDocument nuspec = new XDocument(
                    new XElement("package",
                        new XElement("id", config.id),
                        new XElement("version", config.version),
                        new XElement("authors", config.authors),
                        new XElement("owners", config.owners),
                        new XElement("licenseUrl", config.licenseUrl),
                        new XElement("projectUrl", config.projectUrl),
                        new XElement("iconUrl", config.iconUrl),
                        new XElement("requireLicenseAcceptance", config.requireLicenseAcceptance),
                        new XElement("description", config.description),
                        new XElement("releaseNotes", config.releaseNotes),
                        new XElement("copyright", config.copyright),
                        new XElement("tags", config.tags),
                        new XElement("dependencies", dependencies)
                    )    
                );

                return nuspec;
            }
        }
    }
}
