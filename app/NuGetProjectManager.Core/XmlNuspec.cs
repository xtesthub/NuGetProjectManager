using System.Xml.Linq;

namespace NuGetProjectManager.Core
{
    public class XmlNuspec
    {
        public XDocument CreateNuspec(NuspecConfig config)
        {
            XElement dependencies = new XElement("dependency");
            dependencies.SetAttributeValue("id", config.dependenciesId);
            dependencies.SetAttributeValue("version", config.dependenciesVersion);

            XDocument nuspec = new XDocument(
                new XElement("package",
                    new XElement("metadata",
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
                )
            );
            return nuspec;
        }
    }
}