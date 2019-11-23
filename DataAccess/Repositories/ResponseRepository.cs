using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class ResponseRepository : GenericAsyncRepository<Response>
    {
        public ResponseRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
