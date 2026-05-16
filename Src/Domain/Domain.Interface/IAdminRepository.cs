using Domain.Entity;

namespace Domain.Interface
{
    public interface IAdminRepository : IUserRepository
    {
        Task<IEnumerable<Class>> GetAll();

<<<<<<< HEAD:Src/Domain/Domain.Interface/IAdminRepository.cs

=======
        Task<Class?> GetById(Guid id);
>>>>>>> 361f609b12868b07b061f1b340403c625dde514f:Src/Domain/Interface/IClassRepository.cs

        Task Add(Class gymClass);

        Task Update(Class gymClass);

        Task Delete(Class gymClass);

        Task Save();
    }
}