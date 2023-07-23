namespace TierBlog_Model
{
    using System;
    public class Setting : Core.ModelBase
    {

        public string LogoPath { get; set; }
        public string HomeMetaTitle { get; set; }
        public string HomeMetaDescription { get; set; }
        public string FtpUsername { get; set; }
        public string FtpPassword { get; set; }
        public string FtpSiteUrl { get; set; }
        public string MediaBasePath { get; set; }
     
    }
}
