namespace FirstApp.Data.Models
{
    public class List
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Card>? Cards { get; set; }
    }
}
