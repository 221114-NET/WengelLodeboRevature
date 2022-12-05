using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;
using Microsoft.Data.SqlClient;


namespace RepoLayer
{
    public interface IRepositoryClass
    {
        Employee PostEmployee(Employee e);
        ReimbursementRequest CreateRequest(ReimbursementRequest request);
        string PostReimbursementRequest(string Email, string RequestType, decimal Amount);
    }
    public class RepositoryClass : IRepositoryClass
    {

        string connectiontString = "Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Wentes93a!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";


        public Employee PostEmployee(Employee e)
        {
            // Employee e = new Employee();
            //e.EmailAddress = "jkskfjl@company.com";

            if (File.Exists("EmployeeList.json"))
            {
                string oldList = File.ReadAllText("EmployeeList.json");
                List<Employee> empList = JsonSerializer.Deserialize<List<Employee>>(oldList)!;

                empList.Add(e);

                string empObjectsToJString = JsonSerializer.Serialize(empList);
                File.WriteAllText("EmployeeList.json", empObjectsToJString);//write the json string to the file 
                return e;

            }
            else
            {
                List<Employee> empList = new List<Employee>();
                empList.Add(e);

                string EmpObjectsToJString = JsonSerializer.Serialize(empList);
                File.WriteAllText("EmployeeList.json", EmpObjectsToJString);//write the json string to the file 
                return e;

            }

        }

        public ReimbursementRequest CreateRequest(ReimbursementRequest request)
        {
            throw new NotImplementedException();
        }

        public string PostReimbursementRequest(string Email, string RequestType, decimal Amount)
        {
            string sql = $"insert into ReimbursementRequest(EmailAddress, RequestType,Amount,IsApproved, RequestStatus) values('{Email}', '{RequestType}' , {Amount}, 0 , 0)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectiontString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return "Reimbursement Requested";
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return "Reimbursement Request Failed";
        }

    }
}



