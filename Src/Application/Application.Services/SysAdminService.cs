using Application.Dtos.Request;
using Application.Interfaces;
using Domain.Entity;
using Domain.Interface;
using Microsoft.Extensions.Configuration;


namespace Application.Services
{
    public class SysAdminService : UserService, ISysAdminService
    {
        private readonly IConfiguration _configuration;
        public SysAdminService(
            IUserRepository repo,
            IPasswordHasherService hasher,
            IUserContext userContext,
            IConfiguration configuration)
            : base(repo, hasher, userContext)
        {
            _configuration = configuration;
        }

        public async Task<User?> UpgradeUsersRol(UpgradeUsersRol request)
        {
            var user = await _repo.GetByEmail(request.Email);

            if (user == null)
                return null;
            
            if(user.Email == _configuration["SeedAdmin:Email"]!){
                return null;
            }

            User newUser;

            switch (request.Rol.ToLower())
            {
                case "admin":
                    newUser = new Admin();
                    break;

                case "sysadmin":
                    newUser = new SysAdmin();
                    break;

                default:
                    newUser = new Client();
                    break;
            }

            newUser.Id = user.Id;
            newUser.Name = user.Name;
            newUser.Email = user.Email;
            newUser.Password = user.Password;
            newUser.Dni = user.Dni;
            newUser.IsActive = user.IsActive;

            await _repo.Delete(user);
            await _repo.Add(newUser);
            await _repo.Save();

            return newUser;
        }
    }
}