using HilleroedSejlKlub_Project.Models;
namespace HilleroedSejlKlub_Project.Repository
{
    public class UserCollectionRepository : IUserRepository
    {
    //Create a list of users that can be used to store the currently created Users
        protected List<User> _users = new List<User>();

    //method for adding more users to the _user list containing all of the current members
    public virtual void add(User user)
        {
            _users.Add(user);
        }
    
    //Method for getting all of the user from the _user list
    public List<User> GetAll()
        {
            return _users;
        }

    //Method for finding a specific entry in the _user list using the users member number 
    public User Get(string memberNumber)
        {
            foreach(User user in _users)
            {
                if(memberNumber == user.MemberNumber)
                {
                    return user;
                }
            }
            return null;
        }

        //For some reason this is different from the other add function and i cannot see why.
        //but now it works... somehow? i'm gonna need to ask someone about this.
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public UserCollectionRepository()
        {
            _users.Add(new User("admin", "123456", "1", 20, true));
            _users.Add(new User("Jon Jon", "abc", "2", 12, false));
            _users.Add(new User("Hellen Keller", "123", "3", 69, false));

        }
    }
}
