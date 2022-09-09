using System;


namespace R5T.S0045
{
	public class XmlElementNames : IXmlElementNames
	{
		#region Infrastructure

	    public static XmlElementNames Instance { get; } = new();

	    private XmlElementNames()
	    {
        }

	    #endregion
	}
}