using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : EFAsyncRepository<User>
    {
        public UserRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
