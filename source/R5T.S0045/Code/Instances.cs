using System;


namespace R5T.S0045
{
    public static class Instances
    {
        public static IConstruction Construction => S0045.Construction.Instance;
        public static IDirectoryPaths DirectoryPaths => S0045.DirectoryPaths.Instance;
        public static IFileNames FileNames => S0045.FileNames.Instance;
        public static IFilePaths FilePaths => S0045.FilePaths.Instance;
        public static IOperations Operations => S0045.Operations.Instance;
        public static ITopLevelFolderNames TopLevelFolderNames => S0045.TopLevelFolderNames.Instance;
        public static IUrls Urls => S0045.Urls.Instance;
        public static IXmlAttributeNames XmlAttributeNames => S0045.XmlAttributeNames.Instance;
        public static IXmlElementNames XmlElementNames => S0045.XmlElementNames.Instance;
        public static F0000.IXElementOperator XElementOperator => F0000.XElementOperator.Instance;
        public static IXmlOperator XmlOperator => S0045.XmlOperator.Instance;
        public static IXmlValues XmlValues => S0045.XmlValues.Instance;
    }
}