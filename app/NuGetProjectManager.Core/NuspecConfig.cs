using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetProjectManager.Core
{
    public class NuspecConfig
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
        public string fileScr;
        public string fileTarget;
        /*
         *  file.SetAttributeValue("src", config.src);
         *  file.SetAttributeValue("target", config.target);
         */

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
            fileScr = "";
            fileTarget = "";
        }
    }
}