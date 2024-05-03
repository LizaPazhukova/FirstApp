using FirstApp.Data.Enums;

namespace FirstApp.Data.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly DueDate { get; set; }
        public string? Description { get; set; }
        public PriorityEnum Priority { get; set; }
        public int ListId { get; set; }
        public List? List {  get; set; }
    }
}
