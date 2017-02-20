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
            lNuspecOutput.Text = "test: " + testConfig.id.ToString();
        }

        private void lNuspecOutput_Click(object sender, EventArgs e)
        {

        }
        struct NuspecConfig
        {
            public string id;
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

            public NuspecConfig(string _id = "no id", string _authors = "no authors", string _owners = "no owners",
                                string _licenseUrl = "no licenseUrl", string _projectUrl = "no projectUrl",
                                string _iconUrl = "no iconUrl", string _requireLicenseAcceptance = "no requireLicenseAcceptance",
                                string _description = "no description", string _releaseNotes = "no releaseNotes",
                                string _copyright = "no copyright", string _tags = "no tags")
            {
                id = _id;
                authors = _authors;
                owners = _owners;
                licenseUrl = _licenseUrl;
                projectUrl = _projectUrl;
                iconUrl = _iconUrl;
                requireLicenseAcceptance = _requireLicenseAcceptance;
                description = _description;
                releaseNotes = _releaseNotes;
                copyright = _copyright;
                tags = _tags;
            }
        }
    }
}
