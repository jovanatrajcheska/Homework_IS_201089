using ISDomain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISServices.Interface
{
    public interface IUserService
    {
        bool ChangeUserRole(string userId);
        List<CinemaApplicationUser> findAll();
        bool IsAdmin(string userId);
    }
}
