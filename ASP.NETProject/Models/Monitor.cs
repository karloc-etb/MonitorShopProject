namespace ASP.NETProject.Models
{
    public class Monitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int DisplaySize { get; set; }
        public string Color { get; set; }
        public string SoldBy { get; set; }
        public int ModelYear { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}