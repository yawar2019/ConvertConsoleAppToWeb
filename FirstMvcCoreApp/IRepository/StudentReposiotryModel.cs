using FirstMvcCoreApp.Models;

namespace FirstMvcCoreApp.IRepository
{
    public interface IStudentReposiotryModel
    {
        IEnumerable<StudentModel> GetStudentDetails();
    }
}
