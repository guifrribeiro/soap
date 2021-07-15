using System;
using System.Xml.Linq;
using Models;

public class UserService : IUserService
{
  public string Test(string s)
  {
    Console.WriteLine("Test Method Executed!");
    return s;
  }

  public void XmlMethod(XElement xml)
  {
    Console.WriteLine(xml.ToString());
  }

  public User TestUser(User user)
  {
    return user;
  }
}