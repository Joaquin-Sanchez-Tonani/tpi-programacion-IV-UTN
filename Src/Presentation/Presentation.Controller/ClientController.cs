using Application.Interfaces;
using Domain.Entity;
using Presentation.Controller;

namespace Presentation.Presentation.Controller
{
    public class ClientController : UsersController<Client>
    {
        public ClientController(IUserService service) : base(service)
        {
            // Aquí puedes agregar métodos que SOLO existan para Clientes
        }
    }
}
