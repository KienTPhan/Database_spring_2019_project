namespace USVisual.API.Models
{
    public class Deaths
    {
        public int Id { get; set; }
        public string countryName { get; set; }
        public string year { get; set; }
        public string month { get; set; }
        public string nKill { get; set; }
        public string nwound { get; set; }
        public string attack_type { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}