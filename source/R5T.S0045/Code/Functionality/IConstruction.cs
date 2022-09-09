using System;
using System.Linq;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.S0045
{
	[FunctionalityMarker]
	public partial interface IConstruction : IFunctionalityMarker
	{
        public void CreateBookmarkFolderNode()
        {
            var repositoryOrganizationsDirectoryPath = Instances.DirectoryPaths.RepositoryOrganizationsDirectoryPath;

            var organizationRepositoriesDirectoryPaths = F0000.Instances.FileSystemOperator.EnumerateAllChildDirectoryPaths(
                repositoryOrganizationsDirectoryPath);

            var possibleRepositoryDirectoryPaths = organizationRepositoriesDirectoryPaths
                .SelectMany(directoryPath => F0000.Instances.FileSystemOperator.EnumerateAllChildDirectoryPaths(directoryPath))
                ;

            var repositoryDirectoryPaths = possibleRepositoryDirectoryPaths
                .Where(directoryPath => F0019.Instances.GitOperator.IsRepositoryDirectory(directoryPath))
                .Now();

            var bookmarkFolderNode = new BookmarkFolderNode
            {
                Level = 0,
                Name = Instances.TopLevelFolderNames.DEV_GitHub,
            };

            var bookmarkNodes = repositoryDirectoryPaths
                .Select(repositoryDirectoryPath => new BookmarkNode
                {
                    Level = 1,
                    Name = F0002.Instances.PathOperator.GetDirectoryName(repositoryDirectoryPath),
                    Path = repositoryDirectoryPath,
                })
                ;

            bookmarkFolderNode.BookmarkNodes.AddRange(bookmarkNodes);

            var document = Instances.XmlOperator.CreateNewDocument();

            var arrayOfTreeViewNode = Instances.XmlOperator.CreateElement(Instances.XmlElementNames.ArrayOfTreeViewNode);

            document.Add(arrayOfTreeViewNode);

            var bookmarkFolderNodeElement = Instances.XmlOperator.GetBookmarkFolderNode(bookmarkFolderNode);

            var xmlSchemaDefinitionAttribute = Instances.XmlOperator.GetXmlnsXsdAttribute();

            arrayOfTreeViewNode.Add(xmlSchemaDefinitionAttribute);

            var xmlSchemaInstanceAttribute = Instances.XmlOperator.GetXmlnsXsiAttribute();

            arrayOfTreeViewNode.Add(xmlSchemaInstanceAttribute);

            arrayOfTreeViewNode.Add(bookmarkFolderNodeElement);

            Instances.XmlOperator.WriteToFile_EmptyIsOk(
                document,
                Instances.FilePaths.Temp);
        }

		/// <summary>
		/// Start by creating an array of tree view nodes.
		/// </summary>
		public void CreateArrayOfTreeViewNode()
        {
			var document = Instances.XmlOperator.CreateNewDocument();

			var arrayOfTreeViewNode = Instances.XmlOperator.CreateElement(Instances.XmlElementNames.ArrayOfTreeViewNode);

			document.Add(arrayOfTreeViewNode);

            //XNamespace xmlns = "xmlns";
            //var xmlnsXsi = new XAttribute(xmlns + "xsd", Instances.Urls.XmlSchemaDefinition);

            //var xmlSchemaDefinition = Instances.XmlOperator.CreateAttribute(
            //	//Instances.XmlAttributeNames.XmlSchemaDocumentNamespace,
            //	xsdNamespace,
            //	Instances.Urls.XmlSchemaDefinition);

            //arrayOfTreeViewNode.Add(xmlnsXsi);
            //arrayOfTreeViewNode.Add(new XAttribute(XNamespace.Xmlns + "xsd", Instances.Urls.XmlSchemaDefinition));

            var xmlSchemaDefinitionAttribute = Instances.XmlOperator.GetXmlnsXsdAttribute();

            arrayOfTreeViewNode.Add(xmlSchemaDefinitionAttribute);

            var xmlSchemaInstanceAttribute = Instances.XmlOperator.GetXmlnsXsiAttribute();

            arrayOfTreeViewNode.Add(xmlSchemaInstanceAttribute);

            var bookmarkFolderTreeViewNode = new XElement(
                Instances.XmlElementNames.TreeViewNode,
                Instances.XmlOperator.GetBookmarkFolderNodeTypeAttribute());

            arrayOfTreeViewNode.Add(bookmarkFolderTreeViewNode);

            Instances.XmlOperator.WriteToFile_EmptyIsOk(
				document,
				Instances.FilePaths.Temp);
        }
	}
}