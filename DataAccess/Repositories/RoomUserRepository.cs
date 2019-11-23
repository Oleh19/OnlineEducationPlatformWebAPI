using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class RoomUserRepository : GenericAsyncRepository<RoomUser>
    {
        public RoomUserRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
