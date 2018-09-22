using System;
using Microsoft.AspNetCore.Identity;

namespace Paneeltjes.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string GivenName { get; set; }

        public string Surname { get; set; }
    }
}
