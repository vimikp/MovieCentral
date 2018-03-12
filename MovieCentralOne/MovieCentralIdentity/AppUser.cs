using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace MovieCentralOne.MovieCentralIdentity
{
    public class AppUser : IdentityUser
    {
        public string ExtraProperty { get; set; }
    }
}
