using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModelsLayer;

namespace RepoLayer
{
    public interface IRepoLayerClass
    {
        public Register GetEmployee(string email, string password);
        public List<Register> GetEmployeeList();
        public List<ReimbursementRequests> GetExpenseList(int registerId); 
        public List<ReimbursementRequests> GetExpensesList();
        public Register PostAccount(Register e);
        public ReimbursementRequests PostExpenses(ReimbursementRequests r);
        
    }

    public class RepoLayerClass : IRepoLayerClass
    {

        private readonly IMyLogger _logger;

        public RepoLayerClass(IMyLogger logger)
        {
            _logger = logger;
        }

        public List<Register> GetEmployeeList()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand command = new SqlCommand($"Select * from Registration", conn);
            conn.Open();
            var ret = command.ExecuteReader();

            List<Register> list = new List<Register>();
            while (ret.Read())
            {
                Register r = new Register(ret.GetInt32(0), ret.GetString(1), ret.GetString(2), ret.GetString(3), ret.GetString(4), ret.GetString(5), ret.GetString(6));
                list.Add(r);
            }
            return list;
        }

        public Register PostAccount(Register r)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand command = new SqlCommand("insert into Registration(FirstName,LastName, Role, EmailAddress, Password, ConfirmPassword) VALUES (@FirstName,@LastName,@Role, @EmailAddress,@Password, @ConfirmPassword);", conn);
            conn.Open();
            command.Parameters.AddWithValue("@FirstName", r.FirstName);
            command.Parameters.AddWithValue("@LastName", r.LastName);
            command.Parameters.AddWithValue("@Role", r.Role);
            command.Parameters.AddWithValue("@EmailAddress", r.EmailAddress);
            command.Parameters.AddWithValue("@Password", r.Password);
            command.Parameters.AddWithValue("@ConfirmPassword", r.ConfirmPassword);

            int rowsCreated = command.ExecuteNonQuery();

            if (rowsCreated == 1)
            {
                conn.Close();
                return r;

            }
            else
            {
                return null;
            }
        }
        public Register GetEmployee(string email, string password)
        {
            DataTable dt=new DataTable();
            SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //taken from Tyler's code
            string query = "select EmailAddress, FirstName, LastName, Role from Registration where EmailAddress=@EmailAddress and Password = @Password ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.Parameters.AddWithValue("@EmailAddress", email);
            command.Parameters.AddWithValue("@Password", password);
            
            var reader = command.ExecuteReader();
            Register register=new Register();

            while(reader.Read())
            {
                register.EmailAddress=reader["EmailAddress"].ToString();
                register.FirstName=reader["FirstName"].ToString();
                register.Role=reader["Role"].ToString();
                register.LastName=reader["LastName"].ToString();
            }
            conn.Close();
            return register;
        }
        

        public List<ReimbursementRequests> GetExpensesList()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand command = new SqlCommand($"select * from ReimbursementRequests join Registration on ReimbursementRequests.RegisterID = Registration.RegisterId ", conn);
            conn.Open();
            var ret = command.ExecuteReader();

            List<ReimbursementRequests> list = new List<ReimbursementRequests>();
            while (ret.Read())
            {
                ReimbursementRequests r = new ReimbursementRequests(ret.GetInt32(0), ret.GetString(1), ret.GetDecimal(2), ret.GetBoolean(3), ret.GetString(4), ret.GetInt32(5));
                list.Add(r);
            }
            return list;

        }



        public ReimbursementRequests PostExpenses(ReimbursementRequests r)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand command = new SqlCommand("insert into ReimbursementRequests(ExpenseType, Amount, IsApproved, RequestStatus,RegisterId) VALUES (@ExpenseType,@Amount,@IsApproved, @RequestStatus, @RegisterId);", conn);
            conn.Open();
            command.Parameters.AddWithValue("@ExpenseType", r.ExpenseType);
            command.Parameters.AddWithValue("@Amount", r.Amount);
            command.Parameters.AddWithValue("@IsApproved", r.IsApproved);
            command.Parameters.AddWithValue("@RequestStatus", r.RequestStatus);
            command.Parameters.AddWithValue("@RegisterId", r.RegisterId);
            int rowsCreated = command.ExecuteNonQuery();
            if (rowsCreated == 1)
            {
                conn.Close();
                return r;

            }
            else
            {
                return null;
            }
        }

        public List<ReimbursementRequests> GetExpenseList(int registerId)
        {
            
            DataTable dt=new DataTable();
            SqlConnection conn = new SqlConnection("Server=tcp:revature-wengel-project1.database.windows.net,1433;Initial Catalog=revature_pro1Database;Persist Security Info=False;User ID=weng;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
           string query = "select * from ReimbursementRequests where RegisterId = @RegisterId ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.Parameters.AddWithValue("@RegisterId", registerId);
            var reader = command.ExecuteReader();

            var request = new List<ReimbursementRequests>();
            while (reader.Read())
            {
                

                request.Add(new ReimbursementRequests()
                {
                    RegisterId=Convert.ToInt32(reader["RegisterId"]),
                    ExpenseType=reader["ExpenseType"].ToString(),
                    Amount=Convert.ToInt32(reader["Amount"]),
                    IsApproved = Convert.ToBoolean(reader["IsApproved"]),
                    RequestStatus=reader["RequestStatus"].ToString(),

                });
            }
            conn.Close();
            return request;
        }

    }
}