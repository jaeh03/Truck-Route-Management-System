﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreIdentity.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUsers>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) :
                base(options)
        { }
    }
}
