using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Trabajop4.Infrastructure;

namespace Infrastructure.Repositories
{


    public class SysAdminRepository : UserRepository, ISysAdminRepository
    {
        public SysAdminRepository(ApplicationDbContext context) : base(context)
        {
            // El 'base(context)' le pasa el DBContext a UserRepository
        }
    }
}



