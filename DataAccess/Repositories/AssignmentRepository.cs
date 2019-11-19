using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class AssignmentRepository : EFAsyncRepository<Assignment>
    {
        public AssignmentRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
