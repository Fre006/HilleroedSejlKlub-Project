using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Repository;

namespace HilleroedSejlKlub_Project.Service
{ 
    public class UserService
{
    // Instance variable - Interface
    private IUserRepository _userRepository;

    // Constructor
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Add(User user)
    {
        _userRepository.Add(user);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public User Get(string memberNumber)
    {
        return _userRepository.Get(memberNumber);
    }
}
}