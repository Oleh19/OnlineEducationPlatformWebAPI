using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class FolderRepository : EFAsyncRepository<Folder>
    {
        public FolderRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
