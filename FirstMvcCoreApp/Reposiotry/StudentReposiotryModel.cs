using FirstMvcCoreApp.Models;
using Dapper;
using System.Data.SqlClient;
using FirstMvcCoreApp.IRepository;

namespace FirstMvcCoreApp.Reposiotry
{
    public class StudentReposiotryModel: IStudentReposiotryModel
    {
        private readonly IConfiguration _configuration;

        public StudentReposiotryModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public  IEnumerable<StudentModel> GetStudentDetails()
        {
            //string ConStr = _configuration.GetConnectionString("SqlCon");
            string ConStr = _configuration.GetSection("ConnectionStrings")["SqlCon"];

            
            
             SqlConnection con = new SqlConnection(ConStr);
           var result =   con.Query<StudentModel>("sp_getStudentDetails", commandType: System.Data.CommandType.StoredProcedure);
            return  result;


        }
    }
}
