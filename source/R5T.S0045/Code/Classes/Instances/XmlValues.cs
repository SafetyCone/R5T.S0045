using System;


namespace R5T.S0045
{
	public class XmlValues : IXmlValues
	{
		#region Infrastructure

	    public static XmlValues Instance { get; } = new();

	    private XmlValues()
	    {
        }

	    #endregion
	}
}