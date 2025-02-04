namespace JH_LAB1.Models
{
    public interface IUserRepository 
    {
        IEnumerable<User> Users { get; }
        User this[int id] { get; }
        User AddUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int id);
    }
}
