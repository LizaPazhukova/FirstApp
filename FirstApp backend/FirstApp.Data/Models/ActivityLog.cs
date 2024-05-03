namespace FirstApp.Data.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Message { get; set; }
    }
}
