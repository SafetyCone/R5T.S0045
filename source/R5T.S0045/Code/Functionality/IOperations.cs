using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.S0045
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
		public void CreateBookmarkFolderNode()
        {
			/// Inputs.
			var outputFilePath =
				//Instances.FilePaths.Temp
				Instances.FilePaths.Bookmarks
				;

			var repositoryDirectoryProvidersByTopLevelFolderName = new Dictionary<string, IRepositoryDirectoriesProvider>
			{
				{
					Instances.TopLevelFolderNames.DEV_GitHub,
					new MultipleSubRepositoryDirectoriesProvider(
						new RepositoryOrganizationsDirectoryRepositoryDirectoriesProvider(
							Instances.DirectoryPaths.RepositoryOrganizationsDirectoryPath))
				},
			};

			/// Run.
			var bookmarkFolderNodes = repositoryDirectoryProvidersByTopLevelFolderName
				.Select(pair =>
				{
					var repositoryDirectoryPaths = pair.Value.GetRepositoryDirectories();

					var bookmarkNodes = repositoryDirectoryPaths
						.Select(repositoryDirectoryPath => new BookmarkNode
						{
							Level = 1,
							Name = F0002.Instances.PathOperator.GetDirectoryName(repositoryDirectoryPath),
							Path = repositoryDirectoryPath,
						})
						;

					var bookmarkFolderNode = new BookmarkFolderNode
					{
						Level = 0,
						Name = pair.Key,
					};

					bookmarkFolderNode.BookmarkNodes.AddRange(bookmarkNodes);

					return bookmarkFolderNode;
				});

			var document = Instances.XmlOperator.CreateNewDocumentWithRoot(Instances.XmlElementNames.ArrayOfTreeViewNode);

			var arrayOfTreeViewNode = document.Root;

			var bookmarkFolderNodeElements = bookmarkFolderNodes
				.Select(bookmarkFolderNode => Instances.XmlOperator.GetBookmarkFolderNode(bookmarkFolderNode))
				;

			arrayOfTreeViewNode.Add(bookmarkFolderNodeElements);

			Instances.XmlOperator.WriteToFile_EmptyIsOk(
				document,
				outputFilePath);
		}
	}
}