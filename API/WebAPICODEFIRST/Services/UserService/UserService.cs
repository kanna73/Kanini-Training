using Microsoft.EntityFrameworkCore;
using WebAPICODEFIRST.Model;
using WebAPICODEFIRST.Model.Data;

namespace WebAPICODEFIRST.Services.UserService
{
    public class UserService: IUserService
    {
        public BikeDataContext _bikeDataContext;


        /* public StudentService(StudentService studentService)
         {

         }*/
        public UserService(BikeDataContext bikeDataContext)
        {
            _bikeDataContext = bikeDataContext;
        }
        public async Task<List<User>> GetAllUserDetails()
        {
            var users = await _bikeDataContext.Users.ToListAsync();
            return users;
        }
    }
}
