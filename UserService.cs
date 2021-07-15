using System;
using System.Xml.Linq;
using Models;

public class UserService : IUserService
{

  public User Test(string s)
  {
    Console.WriteLine("Test Method Executed!");
    User user = new User
    {
      Id = 1,
      Name = "Guilherme Ferreira",
      Email = "guifrribeiro@gmail.com"
    };
    return user;
  }

  public void XmlMethod(XElement xml)
  {
    Console.WriteLine(xml.ToString());
  }

  public User TestUser(int id, string name, string email)
  {
    Console.WriteLine("TestUser Method Executed");
    // Console.WriteLine(user.ToString());

    User user = new User
    {
      Id = 1,
      Name = "Guilherme Ferreira",
      Email = "guifrribeiro@gmail.com"
    };
    return user;
  }
}