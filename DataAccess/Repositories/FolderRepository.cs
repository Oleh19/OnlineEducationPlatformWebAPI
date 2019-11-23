using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class FolderRepository : GenericAsyncRepository<Folder>
    {
        public FolderRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
