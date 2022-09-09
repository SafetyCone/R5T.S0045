using System;

using R5T.T0131;


namespace R5T.S0045
{
	[ValuesMarker]
	public partial interface IXmlElementNames : IValuesMarker
	{
		public string ArrayOfTreeViewNode => "ArrayOfTreeViewNode";
		public string TreeViewNode => "TreeViewNode";

		public string Level => "Level";
		public string IsExpanded => "IsExpanded";
		public string IsLeaf => "IsLeaf";
		public string Name => "Name";
		public string Children => "Children";
		public string CanSelect => "CanSelect";
		public string HasError => "HasError";

		public string RepoType => "RepoType";
		public string Path => "Path";
	}
}