using SYSProject.Business.Abstract;
using SYSProject.Core.DataAccess;
using SYSProject.Core.Entities.Concrete; 
using SYSProject.Entities.Concrete;

namespace SYSProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IGenericRepository<User> _userDal;

        public UserManager(IGenericRepository<User> userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserName(string userName)
        {
            return _userDal.Get(u => u.UserName == userName);
        }
    }
}