using System;

using R5T.T0131;


namespace R5T.S0045
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string Bookmarks_XML => "bookmarks.xml";
	}
}