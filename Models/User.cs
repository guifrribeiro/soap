using System;
using System.Runtime.Serialization;

namespace Models
{
  [DataContract]
  public class User
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Email { get; set ; }

    [DataMember]
    public string Password { get; set; }

    [DataMember]
    public bool Admin { get; set; }

    [DataMember]
    public DateTime Created { get; set; }

    [DataMember]
    public DateTime Updated { get; set; }
  }
}