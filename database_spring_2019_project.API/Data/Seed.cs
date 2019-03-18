using System.Collections.Generic;
using Newtonsoft.Json;
using USVisual.API.Models;

namespace USVisual.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedDeaths() {
            var deathData = System.IO.File.ReadAllText("Data/DeathSeedData.json");
            var deaths = JsonConvert.DeserializeObject<List<Death>>(deathData);

            foreach( var death in deaths) {
                _context.Deaths.Add(death);
            }

            _context.SaveChanges();
        }
    }
}