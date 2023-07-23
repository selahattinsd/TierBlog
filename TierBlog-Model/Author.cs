namespace TierBlog_Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Author : Core.ModelBase
    {

        public string Fullname { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }

        [NotMapped]
        public string Password { get; set; }

        public bool Is_active{ get; set; }
        public bool Is_deleted{ get; set; }

    }
}