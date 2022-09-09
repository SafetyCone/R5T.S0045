using System;


namespace R5T.S0045
{
	public class XmlOperator : IXmlOperator
	{
		#region Infrastructure

	    public static XmlOperator Instance { get; } = new();

	    private XmlOperator()
	    {
        }

	    #endregion
	}
}