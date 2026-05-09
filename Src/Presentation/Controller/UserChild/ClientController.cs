using Domain.Entity.UsersChild;
using Application.Services;

namespace Presentation.Controller.UserChild
{
    public class ClientController : UsersController<Client>
    {
        public ClientController(IUserService service) : base(service)
        {
            // Aquí puedes agregar métodos que SOLO existan para Clientes
        }
    }
}
