namespace TierBlog_Model
{
    using System;
    public class Category : Core.ModelBase
    {

        public string Slug { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
