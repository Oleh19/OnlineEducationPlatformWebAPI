using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class PhotoRepository : EFAsyncRepository<Photo>
    {
        public PhotoRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
