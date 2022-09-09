using System;


namespace R5T.S0045
{
    public static class Instances
    {
        public static IConstruction Construction { get; } = S0045.Construction.Instance;
        public static IDirectoryPaths DirectoryPaths { get; } = S0045.DirectoryPaths.Instance;
        public static IFileNames FileNames { get; } = S0045.FileNames.Instance;
        public static IFilePaths FilePaths { get; } = S0045.FilePaths.Instance;
        public static IOperations Operations { get; } = S0045.Operations.Instance;
        public static ITopLevelFolderNames TopLevelFolderNames { get; } = S0045.TopLevelFolderNames.Instance;
        public static IUrls Urls { get; } = S0045.Urls.Instance;
        public static IXmlAttributeNames XmlAttributeNames { get; } = S0045.XmlAttributeNames.Instance;
        public static IXmlElementNames XmlElementNames { get; } = S0045.XmlElementNames.Instance;
        public static IXmlOperator XmlOperator { get; } = S0045.XmlOperator.Instance;
        public static IXmlValues XmlValues { get; } = S0045.XmlValues.Instance;
    }
}