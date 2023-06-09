using Microsoft.EntityFrameworkCore;
using Nagp.UserInfo.Repository.Models;

namespace Nagp.UserInfo.Repository
{
    public class UserInfoRepository : IUserInformationRepository
    {
        private readonly DbContextOptions<UserInfoDbContext> _dbContextOptions;
        public UserInfoRepository(DbContextOptions<UserInfoDbContext> options)
        {
            _dbContextOptions = options;
        }

        public IEnumerable<UserInformation> GetAllUserInformationRepository()
        { 
            using var context = new UserInfoDbContext(_dbContextOptions);

            return context.UserInformation;
        }

    }
}