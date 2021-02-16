using System.Threading.Tasks;

namespace CourseAdmin.Respository.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task<bool> RollBack();
    }
}
