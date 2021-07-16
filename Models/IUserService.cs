using System.ServiceModel;

namespace Models
{
  [ServiceContract]
  public interface IUserService
  {
    [OperationContract]
    User CreateUser(string name, string email, string password, bool admin);
  }
}