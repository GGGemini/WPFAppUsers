using SimplePosts.Server.Repository.Base;
using WPFAppUsersTestCore.Models.Entities;
using WPFAppUsersTestCore.Repositories.Context;
using WPFAppUsersTestCore.Repositories.Interfaces;

namespace WPFAppUsersTestCore.Repositories
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        //public UsersRepository(AppDbContext context) : base(context)
        //{
        //}
    }
}
