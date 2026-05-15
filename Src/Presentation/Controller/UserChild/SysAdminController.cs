using Application.Services;
using Domain.Entity.UsersChild;

namespace Presentation.Controller.UserChild
{


    public class SysAdminController : UsersController<SysAdmin>
    {
        public SysAdminController(IUserService service) : base(service)
        {
            // Aquí puedes agregar métodos que SOLO existan para Clientes
        }
    }
}

