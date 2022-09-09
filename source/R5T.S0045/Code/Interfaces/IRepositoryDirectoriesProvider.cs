using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.S0045
{
    [UtilityTypeMarker]
    public interface IRepositoryDirectoriesProvider
    {
        public IEnumerable<string> GetRepositoryDirectories();
    }
}
