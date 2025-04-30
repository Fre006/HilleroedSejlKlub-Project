using HilleroedSejlKlub_Project.Models;

namespace HilleroedSejlKlub_Project.Repository
{
    public interface IUserRepository
    {
        public List<User> GetAll();

        public void Add(User user);

        public User Get(string memberNumber);
    }
}
