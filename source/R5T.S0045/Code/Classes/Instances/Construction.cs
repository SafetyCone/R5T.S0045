using System;


namespace R5T.S0045
{
	public class Construction : IConstruction
	{
		#region Infrastructure

	    public static Construction Instance { get; } = new();

	    private Construction()
	    {
        }

	    #endregion
	}
}