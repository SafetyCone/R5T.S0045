using System;


namespace R5T.S0045
{
    public class BookmarkNode
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Path { get; set; }


        public override string ToString()
        {
            var representation = $"{this.Name}: {this.Path}";
            return representation;
        }
    }
}
