﻿using ISDomain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISDomain.Identity
{
    public enum Role
    {
        ROLE_USER,
        ROLE_ADMIN,
    }
    public class CinemaApplicationUser : IdentityUser
    {
        public Role Role { get; set; } = Role.ROLE_USER;
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
