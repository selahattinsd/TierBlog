namespace TierBlog_Model
{
    using System;

    public class ContentTag :Core.ModelBase
    {
        public ContentTag(int contetnId, int tagId) 
        {
            TagId = tagId;
            ContentId = contetnId;
        }

        public int TagId { get; set; }
        public int ContentId { get; set; }
    }
}
