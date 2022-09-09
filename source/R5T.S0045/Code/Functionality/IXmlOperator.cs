using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.S0045
{
	[FunctionalityMarker]
	public partial interface IXmlOperator : IFunctionalityMarker,
		F0000.IXmlOperator
	{
		public XAttribute GetBookmarkFolderNodeTypeAttribute()
        {
			var output = this.GetXsiTypeAttribute(Instances.XmlValues.BookmarkFolderNodeTypeName);
			return output;
        }

		public XAttribute GetBookmarkNodeTypeAttribute()
		{
			var output = this.GetXsiTypeAttribute(Instances.XmlValues.BookmarkNodeTypeName);
			return output;
		}

		public XElement GetBookmarkFolderNode(BookmarkFolderNode bookmarkFolderNode)
        {
			var bookmarkNodes = this.GetBookmarkNodes(bookmarkFolderNode.BookmarkNodes);

			var output = new XElement(
				Instances.XmlElementNames.TreeViewNode,
				this.GetBookmarkFolderNodeTypeAttribute(),
				new XElement(
					Instances.XmlElementNames.Level,
					bookmarkFolderNode.Level),
				new XElement(
					Instances.XmlElementNames.IsExpanded,
					true),
				new XElement(
					Instances.XmlElementNames.IsLeaf,
					false),
				new XElement(
					Instances.XmlElementNames.Name,
					bookmarkFolderNode.Name),
				new XElement(
					Instances.XmlElementNames.Children,
					bookmarkNodes),
				new XElement(
					Instances.XmlElementNames.CanSelect,
					true),
				new XElement(
					Instances.XmlElementNames.HasError,
					false));

			return output;
		}

		public IEnumerable<XElement> GetBookmarkNodes(IEnumerable<BookmarkNode> bookmarkNodes)
        {
			var output = bookmarkNodes
				.Select(bookmarkNode => Instances.XmlOperator.GetBookmarkNode(bookmarkNode))
				;

			return output;
		}

		public XElement GetBookmarkNode(BookmarkNode bookmarkNode)
        {
			var output = new XElement(
				Instances.XmlElementNames.TreeViewNode,
				this.GetBookmarkNodeTypeAttribute(),
				new XElement(
					Instances.XmlElementNames.Level,
					bookmarkNode.Level),
				new XElement(
					Instances.XmlElementNames.IsExpanded,
					false),
				new XElement(
					Instances.XmlElementNames.IsLeaf,
					true),
				new XElement(
					Instances.XmlElementNames.Name,
					bookmarkNode.Name),
				new XElement(
					Instances.XmlElementNames.Children),
				new XElement(
					Instances.XmlElementNames.CanSelect,
					true),
				new XElement(
					Instances.XmlElementNames.HasError,
					false),
				new XElement(
					Instances.XmlElementNames.RepoType,
					Instances.XmlValues.GitRepositoryType),
				new XElement(
					Instances.XmlElementNames.Path,
					bookmarkNode.Path));

			return output;
        }
	}
}