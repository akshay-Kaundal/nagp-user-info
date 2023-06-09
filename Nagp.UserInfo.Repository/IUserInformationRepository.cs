using Nagp.UserInfo.Repository.Models;

namespace Nagp.UserInfo.Repository
{
    public interface IUserInformationRepository
    {
        IEnumerable<UserInformation> GetAllUserInformationRepository();
    }
}
