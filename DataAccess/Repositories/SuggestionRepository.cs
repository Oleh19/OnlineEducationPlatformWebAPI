using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class SuggestionRepository : GenericAsyncRepository<Invitation>
    {
        public SuggestionRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
