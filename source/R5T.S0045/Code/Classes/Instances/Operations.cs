using System;


namespace R5T.S0045
{
	public class Operations : IOperations
	{
		#region Infrastructure

	    public static Operations Instance { get; } = new();

	    private Operations()
	    {
        }

	    #endregion
	}
}