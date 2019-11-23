using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class RoleInRoomRepository : GenericAsyncRepository<RoleInRoom>
    {
        public RoleInRoomRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
