using System;
using System.Collections.Generic;
using System.Linq;


namespace R5T.S0045
{
    public class RepositoryOrganizationsDirectoryRepositoryDirectoriesProvider : IRepositoryDirectoriesProvider
    {
        private string RepositoryOrganizationsDiretoryPath { get; }


        public RepositoryOrganizationsDirectoryRepositoryDirectoriesProvider(
            string repositoryOrganizationsDirectoryPath)
        {
            this.RepositoryOrganizationsDiretoryPath = repositoryOrganizationsDirectoryPath;
        }

        public IEnumerable<string> GetRepositoryDirectories()
        {
            var organizationRepositoriesDirectoryPaths = F0000.Instances.FileSystemOperator.EnumerateAllChildDirectoryPaths(
                this.RepositoryOrganizationsDiretoryPath);

            var possibleRepositoryDirectoryPaths = organizationRepositoriesDirectoryPaths
                .SelectMany(directoryPath => F0000.Instances.FileSystemOperator.EnumerateAllChildDirectoryPaths(directoryPath))
                ;

            var repositoryDirectoryPaths = possibleRepositoryDirectoryPaths
                .Where(directoryPath => F0019.Instances.GitOperator.IsRepositoryDirectory(directoryPath))
                ;

            return repositoryDirectoryPaths;
        }
    }
}
