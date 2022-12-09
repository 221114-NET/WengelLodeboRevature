using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    public interface IRepositoryClass
    {
        Employee PostEmployee(Employee e);
    }

    public class RepositoryClass : IRepositoryClass
    {


        private readonly IMyLogger _logger;

        public RepositoryClass(IMyLogger logger)
        {
            _logger = logger;
        }
        public Employee PostEmployee(Employee e)
        {
            //Employee e = new Employee();
            // e.EmailAddress = "jkskfjl@company.com";

            if (File.Exists("EmployeeList.json"))
            {
                string oldList = File.ReadAllText("EmployeeList.json");
                List<Employee> empList = JsonSerializer.Deserialize<List<Employee>>(oldList)!;

                empList.Add(e);

                string empObjectsToJString = JsonSerializer.Serialize(empList);
                File.WriteAllText("EmployeeList.json", empObjectsToJString);//write the json string to the file 
                _logger.LogStuff(e);
                return e;



            }
            else
            {
                List<Employee> empList = new List<Employee>();
                empList.Add(e);

                string EmpObjectsToJString = JsonSerializer.Serialize(empList);
                File.WriteAllText("EmployeeList.json", EmpObjectsToJString);//write the json string to the file 
                _logger.LogStuff(e);
                return e;

            }
        }
    }
    // string connectionString = "Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=RevatureDB;Persist Security Info=False;User ID=weng;Password={Wentes93a!};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    // SqlConnection con = new SqlConnection(connectionString); //give the connectionstring
    // string query = $"insert into ReimbursementRequest(EmailAddress, RequestType,Amount,IsApproved, RequestStatus) values({emailAddress}, {requestType} , 5766.78, 0 , 0)";

    //open the connection
    // con.Open();
    //         //make command
    //         SqlCommand cmd = new SqlCommand(query, con);
    // //Execute the command
    // cmd.
}