namespace TierBlog_Data.Infrastructure.Entities
{
    public class DataResult
    {
        public DataResult(bool isSucced,string message) 
        {
            IsSucceed = isSucced;
            Message = message;
        }

        public bool IsSucceed{ get; set; }
        public string Message{ get; set; }
    }
}
