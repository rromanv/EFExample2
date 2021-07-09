using System;
using System.Collections.Generic;

#nullable disable

namespace EFExample2
{
    public partial class Post
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public long BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
