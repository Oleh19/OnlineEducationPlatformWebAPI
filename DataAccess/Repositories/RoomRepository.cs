using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class RoomRepository : GenericAsyncRepository<Room>
    {
        public RoomRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
