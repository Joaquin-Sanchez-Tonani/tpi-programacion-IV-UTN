using Application.Tools;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services.UsersChild
{
    public class SysAdminService : UserService, ISysAdminService
    {
        public SysAdminService(IUserRepository repo, IPasswordHasherService hasher)
            : base(repo, hasher)
        {
        }
    }
}




