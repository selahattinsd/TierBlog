namespace TierBlog_Model
{
    using System;
    public class Comment : Core.ModelBase
    {

        public string ContentId { get; set; }
        public string Fullname { get; set; }
        public string Mail { get; set; }
        public string Text { get; set; }
        public bool Is_approvied{ get; set; }

    }
}