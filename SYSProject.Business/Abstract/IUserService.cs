using SYSProject.Core.Entities.Concrete;
using SYSProject.Core.Utilities.Results;
using SYSProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserName(string userName);
    }
}
