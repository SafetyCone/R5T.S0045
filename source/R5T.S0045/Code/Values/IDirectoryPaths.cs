using System;

using R5T.T0131;


namespace R5T.S0045
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker
	{
		public string RepositoryOrganizationsDirectoryPath => @"C:\Code\DEV\Git\GitHub";
		public string SourceTree => this.SourceTree;
		public string SourceTree_Local_AppData => @"C:\Users\David\AppData\Local\Atlassian\SourceTree";
	}
}