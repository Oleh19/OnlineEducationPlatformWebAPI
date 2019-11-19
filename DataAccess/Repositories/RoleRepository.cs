using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class RoleRepository : EFAsyncRepository<Role>
    {
        public RoleRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
