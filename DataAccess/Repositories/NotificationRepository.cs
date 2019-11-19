using DbLayer;
using DbLayer.Entities.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class NotificationRepository : EFAsyncRepository<Notification>
    {
        public NotificationRepository(EducationPlatformDbContext context) : base(context) { }
    }
}
