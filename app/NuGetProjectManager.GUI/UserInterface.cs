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
            //XDocument nuspecConfig = XDocument.Load(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\data\nuspecConfig.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("nuspecConfig.xml");
            NuspecConfig testConfig = new NuspecConfig("100");
            //lNuspecOutput.Text = "test: " + testConfig.id.ToString();

            //xdocument erstellen
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
                        new XElement("dependencies", "<dependency id=" + testConfig.dependenciesId + "version=" + testConfig.dependenciesVersion + "/>")
                    )
                )
            );
            xmlNuspec.Save(@"C:\Visual Studios\projects\NuGetProjectManager\tmp\data\xmlNuspec.xml", SaveOptions.None);
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
            public string licenseUrl;
            public string projectUrl;
            public string iconUrl;
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
                version = "no version";
                authors = "no authors";
                owners = "no authors";
                licenseUrl = "no licenseUrl";
                projectUrl = "no projectUrl";
                iconUrl = "no iconUrl";
                requireLicenseAcceptance = "no requireLicenseAcceptance";
                description = "no description";
                releaseNotes = "no releaseNotes";
                copyright = "no copyright";
                tags = "no tags";
                dependenciesId = "no dependencies";
                dependenciesVersion = "1.0";
            }
        }
    }
}
