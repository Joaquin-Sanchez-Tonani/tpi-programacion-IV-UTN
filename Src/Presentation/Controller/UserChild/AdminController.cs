using Application.Services;
using Domain.Entity.UsersChild;

namespace Presentation.Controller.UserChild
{


    public class AdminController : UsersController<Admin>
    {
        public AdminController(IUserService service) : base(service)
        {
            // Aquí puedes agregar métodos que SOLO existan para admins
        }
    }
}
