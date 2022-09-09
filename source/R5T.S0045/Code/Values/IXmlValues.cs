using System;

using R5T.T0131;


namespace R5T.S0045
{
	[ValuesMarker]
	public partial interface IXmlValues : IValuesMarker
	{
		public string BookmarkFolderNodeTypeName => "BookmarkFolderNode";
		public string BookmarkNodeTypeName => "BookmarkNode";
		public string GitRepositoryType => "Git";
	}
}