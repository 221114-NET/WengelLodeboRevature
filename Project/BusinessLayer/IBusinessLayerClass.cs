using ModelsLayer;

namespace BusinessLayer
{
    public interface IBusinessLayerClass
    {
        
        Employee PostEmployee(Employee e);
        string  PostReimbursementRequest(string Email, string RequestType , decimal Amount);
        
        
    }
}