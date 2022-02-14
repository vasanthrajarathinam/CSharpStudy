using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpFeatures
{
    public class NullConditionalOperator
    {
        Post post = new Post();
        public NullConditionalOperator()
        {
            var title = post?.title;
        }
    }

    public class Comments
    { 
    
    }

    public class Title
    {

    }

    public class Tag
    {

    }

    public class Post
    {

        public Title title { get; set; } = new Title();

        public List<Tag> tags { get; set; }

        public List<Comments> comments { get; set; }
    }
}
