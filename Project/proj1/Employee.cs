
using System.Text.Json;

namespace proj1;
public class Employee
{
    public string? Name {get; set;}
    public string? emailAddress { get; set;}
    public string? Password { get; set;}
    public string? Type { get; set; }
   // public  int ID { get; set;}


    public Employee (string name, string email, string password, string type){
        emailAddress = email;
        Password = password;
        Type = type;
    }
    public override string ToString() {
        return $"Email Address: {emailAddress}\nPassword: {Password}";
    }

    
}