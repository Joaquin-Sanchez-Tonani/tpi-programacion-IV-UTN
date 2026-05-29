using Application.Dtos.Request;
using Application.Dtos.Request.Admin;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IAdminService : IUserService
    {

        Task<Class?> CreteClass(CreateClassAdminRequest request);



    }
}
