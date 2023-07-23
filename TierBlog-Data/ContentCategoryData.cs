

namespace TierBlog_Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TierBlog_Data.Infrastructure;
    using TierBlog_Data.Infrastructure.Entities;
    using TierBlog_Model;


    public class ContentCategoryData : EntityBaseData<ContentCategory>
    {
        public ContentCategoryData(IOptions<DataBaseSettings> dbOptions) : base(new DataContext(dbOptions.Value.ConnectionString))
        {
        }
    }
}
