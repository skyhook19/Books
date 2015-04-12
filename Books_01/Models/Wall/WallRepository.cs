using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Wall
{
    public class WallRepository
    {
        List<IWallPost> posts = new List<IWallPost>();
        public void DeletePost(Guid id)
        {
            posts.RemoveAll(m => m.id == id);
        }
        public void MakeRepost(Guid sourcePostId)
        {
            Repost rep = new Repost(sourcePostId);
            posts.Add(rep);
        }
    }
}