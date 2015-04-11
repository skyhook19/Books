using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Authorization
{
    public class ApplicationUser : IdentityUser
    {
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
    }
}