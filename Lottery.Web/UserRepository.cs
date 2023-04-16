namespace Lottery.Web;

public class UserRepository
{
    private static readonly Dictionary<int, User> Users;

    static UserRepository()
    {
        Users = Enumerable
            .Range(1, 100)
            .Select(index => new User(index))
            .ToDictionary(u => u.Id, u => u);
    }

    public User Get(int id)
    {
        return Users[id];
    }
}
