using WebAPICODEFIRST.Model;

namespace WebAPICODEFIRST.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUserDetails();

    }
}
