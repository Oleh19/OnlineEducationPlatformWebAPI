using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class SuggestionRepository : EFAsyncRepository<Suggestion>
    {
        public SuggestionRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
