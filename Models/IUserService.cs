using System.ServiceModel;

namespace Models
{
  [ServiceContract]
  public interface IUserService
  {
    [OperationContract]
    string Test(string s);

    [OperationContract]
    void XmlMethod(System.Xml.Linq.XElement xml);

    [OperationContract]
    User TestUser(User inputModel);
  }
}