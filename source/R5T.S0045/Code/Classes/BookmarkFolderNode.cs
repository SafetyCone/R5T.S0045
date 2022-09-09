using System;
using System.Collections.Generic;


namespace R5T.S0045
{
    public class BookmarkFolderNode
    {
        public int Level { get; set; }
        public string Name { get; set; }

        public List<BookmarkNode> BookmarkNodes { get; } = new();


        public override string ToString()
        {
            var representation = this.Name;
            return representation;
        }
    }
}
