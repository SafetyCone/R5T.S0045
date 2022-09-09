using System;


namespace R5T.S0045
{
	public class FileNames : IFileNames
	{
		#region Infrastructure

	    public static FileNames Instance { get; } = new();

	    private FileNames()
	    {
        }

	    #endregion
	}
}