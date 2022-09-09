using System;
using System.Collections.Generic;
using System.Linq;


namespace R5T.S0045
{
    public class MultipleSubRepositoryDirectoriesProvider : IRepositoryDirectoriesProvider
    {
        private IRepositoryDirectoriesProvider[] RepositoryDirectoriesProviders { get; }


        public MultipleSubRepositoryDirectoriesProvider(
            params IRepositoryDirectoriesProvider[] repositoryDirectoriesProviders)
        {
            this.RepositoryDirectoriesProviders = repositoryDirectoriesProviders;
        }

        public IEnumerable<string> GetRepositoryDirectories()
        {
            var output = this.RepositoryDirectoriesProviders
                .SelectMany(repositoryDirectoryProvider => repositoryDirectoryProvider.GetRepositoryDirectories())
                ;

            return output;
        }
    }
}
