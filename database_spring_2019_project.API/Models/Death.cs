using System;

namespace USVisual.API.Models
{
    public class Death
    {
        public int Id { get; set; }
        public string iyear { get; set; }
        public string imonth { get; set; }
        public string country_txt { get; set; }
        public string region_txt { get; set; }
        public string attacktype1_txt { get; set; }
        public string weaptype1_txt { get; set; }
        public string nkill { get; set; }
        public string nwound { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}