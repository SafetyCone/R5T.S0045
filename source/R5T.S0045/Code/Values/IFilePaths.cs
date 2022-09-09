using System;

using R5T.T0131;


namespace R5T.S0045
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string Bookmarks => zBookmarks.Value;
		private static readonly Lazy<string> zBookmarks = new(() => F0002.Instances.PathOperator.GetFilePath(
			Instances.DirectoryPaths.SourceTree_Local_AppData,
			Instances.FileNames.Bookmarks_XML));

		public string Temp => @"C:\Temp\SourceTree Bookmarks.xml";
	}
}