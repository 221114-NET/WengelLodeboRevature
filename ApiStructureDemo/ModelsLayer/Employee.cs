
using System.Text.Json;

namespace ModelsLayer;
public class Employee
{
    public  int ID { get; set;}
    public string Name {get; set;}
    public string EmailAddress { get; set;}
    public string Password { get; set;}
    public string Role { get; set; }
   

   public Employee()
   {

   }
    public Employee(string email, string password)
   {
        EmailAddress = email;
        Password = password;
   }


    public Employee (string name, string email, string password, string role){
        Name = name;
        EmailAddress = email;
        Password = password;
        Role = role;
    }
    // public override string ToString() {
    //     return $"Email Address: {EmailAddress}\nPassword: {Password}";
    // }

    
}