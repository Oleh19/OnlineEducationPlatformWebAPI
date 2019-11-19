using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class MarkRepository : EFAsyncRepository<Mark>
    {
        public MarkRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
