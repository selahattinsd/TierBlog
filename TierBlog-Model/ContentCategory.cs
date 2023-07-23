namespace TierBlog_Model
{
    using System;

    public class ContentCategory :Core.ModelBase
    {
        public ContentCategory(int contetnId, int categoryId) 
        {
            CategoryId = categoryId;
            ContentId = contetnId;
        }

        public int CategoryId { get; set; }
        public int ContentId { get; set; }
    }
}
