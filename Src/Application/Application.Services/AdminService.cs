using Application.Interfaces;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{

    public class AdminService : UserService, IAdminService
    {
        public AdminService(IUserRepository repo, IPasswordHasherService hasher)
            : base(repo, hasher)
        {
        }
    }
}
