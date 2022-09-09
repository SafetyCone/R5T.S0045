using System;


namespace R5T.S0045
{
	public class XmlAttributeNames : IXmlAttributeNames
	{
		#region Infrastructure

	    public static XmlAttributeNames Instance { get; } = new();

	    private XmlAttributeNames()
	    {
        }

	    #endregion
	}
}