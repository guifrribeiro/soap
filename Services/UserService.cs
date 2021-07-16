using System;
using Models;

public class UserService : IUserService
{
  UserContext userContext = new UserContext();

  public User CreateUser(string name, string email, string password, bool admin)
  {
    User user = new User
    {
      Id = Guid.NewGuid().ToString(),
      Name = name,
      Email = email,
      Password = password,
      Admin = admin,
      Created = DateTime.Now,
      Updated = DateTime.Now
    };

    userContext.Users.Add(user);

    if (userContext.SaveChanges() > 0)
    {
      return user;
    }
    else
    {
      return null;
    }
  }
}