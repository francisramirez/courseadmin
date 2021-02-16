using CourseAdmin.Respository.Interfaces;
using CourseAdmin.Respository.BaseRepository;
using CourseAdmin.Domain.Entities;

namespace CourseAdmin.Respository.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {

    }
}
