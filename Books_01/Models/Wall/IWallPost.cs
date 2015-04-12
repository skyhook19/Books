using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_01.Models.Wall
{
    interface IWallPost
    {
        Guid id { get;  }
        PostType type { get; }
        void Like();
        void DisLike();
    }
}
