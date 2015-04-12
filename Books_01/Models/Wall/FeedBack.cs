using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Wall
{
    public class FeedBack:IWallPost
    {

        public Guid id
        {
            get { throw new NotImplementedException(); }
        }

        public void Like()
        {
            throw new NotImplementedException();
        }

        public void DisLike()
        {
            throw new NotImplementedException();
        }
    }
}