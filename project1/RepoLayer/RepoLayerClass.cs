using System.Text.Json;
using Microsoft.Data.SqlClient;
using ModelsLayer;

namespace RepoLayer
{
    public interface IRepoLayerClass
    {
        Register PostRegister(Register r);
    }
    //Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=RevatureDB;Persist Security Info=False;User ID=weng;Password={Password1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
    public class RepoLayerClass : IRepoLayerClass
    {

        private readonly IMyLogger _logger;

        public RepoLayerClass(IMyLogger logger)
        {
            _logger = logger;
        }
        public Register PostRegister(Register r)
        {
            //    SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=RevatureDB;Persist Security Info=False;User ID=weng;Password={Password1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //    SqlCommand command = new SqlCommand("insert into Registration(Name, Role, EmailAddress, Password, ConfirmPassword)VALUES({@Name},{@Role}, {@EmailAddress},{@Password}, {@ConfirmPassword});");
            //    int rowsCreated = command.ExecuteNonQuery();

            //    if(rowsCreated == 1)
            //    {

            //     return r;

            //    }else
            //    {
            //     return null;
            //    }

            if (File.Exists("Register.json"))
            {
                string oldrlist = File.ReadAllText("Register.json");

                List<Register> rlist = JsonSerializer.Deserialize<List<Register>>(oldrlist)!;
                rlist.Add(r);
                string rliststr = JsonSerializer.Serialize(rlist);
                File.WriteAllText("RegisterList.json", rliststr);
                return r;
            }
            else
            {
                List<Register> rlist = new List<Register>();
                rlist.Add(r);
                string rliststr = JsonSerializer.Serialize(rlist);
                File.WriteAllText("RegisterList.json", rliststr);
                return r;
            }

        }
    }
}