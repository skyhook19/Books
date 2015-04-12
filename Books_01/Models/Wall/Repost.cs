using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Wall
{
    public class Repost:IWallPost
    {
        public PostType type { get { return type; } private set; }
        public Guid id { get { return id; } private set; }
        DateTime date;
        Guid sourceID;
        public Repost(Guid sourcePostId)
        {
            sourceID = sourcePostId;
            date = DateTime.Now;
            type = PostType.Repost;
            id = new Guid();
        }
        public void Like()
        {

        }
        public void DisLike()
        {

        }
    }
}