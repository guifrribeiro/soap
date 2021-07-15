using System.ServiceModel;

namespace Models
{
  [ServiceContract]
  public interface IUserService
  {
    [OperationContract]
    User Test(string s);

    [OperationContract]
    void XmlMethod(System.Xml.Linq.XElement xml);

    [OperationContract]
    User TestUser(int id, string name, string email);
  }
}