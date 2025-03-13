namespace ProjectUpdate.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ImageURL { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }
        public string Actor { get; set; }

        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public float Price { get; set; }

    }
}
