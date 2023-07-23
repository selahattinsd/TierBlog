namespace TierBlog_Model
{
    using System;
    public class Tags : Core.ModelBase
    {
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
