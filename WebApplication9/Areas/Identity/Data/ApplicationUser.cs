using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication9.Areas.Identity.Data;

// Add profile data for application users by adding properties to the WebApplication9User class
public class ApplicationUser : IdentityUser
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
}

