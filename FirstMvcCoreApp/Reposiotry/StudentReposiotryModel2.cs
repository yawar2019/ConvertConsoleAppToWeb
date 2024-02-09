using FirstMvcCoreApp.Models;
using Dapper;
using System.Data.SqlClient;
using FirstMvcCoreApp.IRepository;

namespace FirstMvcCoreApp.Reposiotry
{
    public class StudentReposiotryModel2: IStudentReposiotryModel
    {
        string ConStr = "Data Source=DESKTOP-L1958T5\\SQLSERVER;Initial Catalog=StudentDb;Integrated Security=true";

        public  IEnumerable<StudentModel> GetStudentDetails()
        {
            SqlConnection con = new SqlConnection(ConStr);
           var result =   con.Query<StudentModel>("sp_getStudentDetails", commandType: System.Data.CommandType.StoredProcedure);
            return  result;


        }
    }
}
