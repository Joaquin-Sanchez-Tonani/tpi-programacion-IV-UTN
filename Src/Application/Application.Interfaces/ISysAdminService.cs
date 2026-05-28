using Application.Dtos.Request;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace Application.Interfaces
{
    public interface ISysAdminService : IUserService
    {
        Task<User?> UpgradeUsersRol(UpgradeUsersRol request);

    }
}
