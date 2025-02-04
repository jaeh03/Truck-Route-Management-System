namespace JH_LAB1.Models
{
    public class RepositoryUser : IUserRepository
    {
        private Dictionary<int, User> users;

        public RepositoryUser()
        {
            users = new Dictionary<int, User>();

            new List<User>
            {
                new User { UserId = 1, FirstName = "John", LastName = "Ho", Email = "john@ho.com", Phone = "123-123-1234", Password = "1", ConfirmPassword = "1" },
                new User { UserId = 2, FirstName = "Mahboob", LastName = "Ali", Email = "mahboob@ali.com", Phone = "123-123-1234", Password = "1", ConfirmPassword = "1" }
            }.ForEach(u=>AddUser(u));
        }

        public User this[int id] => users.ContainsKey(id) ? users[id] : null;

        public IEnumerable<User> Users => users.Values;

        public User AddUser(User user)
        {
            if (user.UserId == 1)
            {
                int key = users.Count;
                while (users.ContainsKey(key))
                {
                    key++;
                }
            }
            users[user.UserId] = user;
            return user; 
        }

        public void DeleteUser(int id)
        {
            users.Remove(id);
        }

        public User UpdateUser(User user)
        {
            return AddUser(user);
        }
    }
}
