﻿using Construction.Shared.Entities;
using Microsoft.AspNetCore.Identity;

namespace Construction.API.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string nombre);
        Task<IdentityResult> AdduserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}
