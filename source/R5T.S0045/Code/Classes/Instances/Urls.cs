using System;


namespace R5T.S0045
{
	public class Urls : IUrls
	{
		#region Infrastructure

	    public static Urls Instance { get; } = new();

	    private Urls()
	    {
        }

	    #endregion
	}
}