using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class UserDataAccess : BaseDataAccess<User>, IUserRepository
    {
        protected override string GetFile()
        {
            return @"F:\Wantsome\POORecap\UserPosts\UserPosts.Data\Files\users.json";
        }
    }
}
