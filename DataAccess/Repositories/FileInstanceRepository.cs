using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class FileInstanceRepository : EFAsyncRepository<FileInstance>
    {
        public FileInstanceRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
