using Faker;

namespace Lottery.Web;

public class User
{
    public User(int id)
    {
        Id = id;
        Username = Internet.UserName();
    }

    public int Id { get; set; }

    public string Username { get; set; }
}
