using Application.Dtos.Request.Admin;
using Application.Interfaces;
using Domain.Entity;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{

    public class AdminService : UserService, IAdminService
    {
        private readonly IClassRepository _repo;
        public AdminService(IUserRepository repo, IPasswordHasherService hasher, IUserContext userContext, IClassRepository classRepo)
            : base(repo, hasher, userContext)
        {
                _repo = classRepo;
        }

        public async Task<Class?> CreteClass(CreateClassAdminRequest request)
        {
            if (request == null) { return null; };

            var clase = new Class
            {
                Name = request.Name,
                Max_Users = request.Max_Users,
            };

            await _repo.Add(clase);
            await _repo.Save();

            return clase;
        }
    }
}
