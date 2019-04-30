using System.Collections.Generic;

namespace USVisual.API.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string region { get; set; }
        public string countryName { get; set; }
        public ICollection<Deaths> Deaths { get; set; }
    }
}