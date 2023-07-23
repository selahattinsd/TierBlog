namespace TierBlog_Model
{
    using System;
    public class Content : Core.ModelBase
    {
        public Content()
        {
            Is_active = false;
            Is_deleted = false;
            Created_on = DateTime.Now;
            Updated_on = DateTime.Now;
            Published_on = DateTime.Now;
        }

        public int MediaId { get; set; }
        public virtual Media Media { get; set; }

        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public DateTime Created_on { get; set; }
        public DateTime Updated_on { get; set; }
        public DateTime Published_on { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }

        public virtual List<ContentCategory> ContentCategory { get; set; }
        public virtual List<ContentTag> ContentTags { get; set; }
    }
}