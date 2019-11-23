using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class FileInstanceRepository : GenericAsyncRepository<FileInstance>
    {
        public FileInstanceRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
