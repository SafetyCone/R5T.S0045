using System;


namespace R5T.S0045
{
	public class TopLevelFolderNames : ITopLevelFolderNames
	{
		#region Infrastructure

	    public static TopLevelFolderNames Instance { get; } = new();

	    private TopLevelFolderNames()
	    {
        }

	    #endregion
	}
}