using VillaMagical.Application.DTOs;

namespace VillaMagical.Application.StaticData
{
    public static class VillaStore
    {
        public static List<VillaDto> VillaList { get; set; } = new List<VillaDto>
        {
            new VillaDto { Id = 1, Name = "Luxury VillaDto 1", Occupancy = 4, Price = 3500, CreatedDate = DateTime.Now },
            new VillaDto { Id = 2, Name = "Luxury VillaDto 2", Occupancy = 5, Price = 3700, CreatedDate = DateTime.Now },
            new VillaDto { Id = 3, Name = "Luxury VillaDto 3", Occupancy = 6, Price = 3900, CreatedDate = DateTime.Now },
            new VillaDto { Id = 4, Name = "Luxury VillaDto 4", Occupancy = 4, Price = 3200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 5, Name = "Luxury VillaDto 5", Occupancy = 8, Price = 4500, CreatedDate = DateTime.Now },

            new VillaDto { Id = 6, Name = "Beach VillaDto 1", Occupancy = 6, Price = 4200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 7, Name = "Beach VillaDto 2", Occupancy = 5, Price = 4100, CreatedDate = DateTime.Now },
            new VillaDto { Id = 8, Name = "Beach VillaDto 3", Occupancy = 7, Price = 4800, CreatedDate = DateTime.Now },
            new VillaDto { Id = 9, Name = "Beach VillaDto 4", Occupancy = 4, Price = 3600, CreatedDate = DateTime.Now },
            new VillaDto { Id = 10, Name = "Beach VillaDto 5", Occupancy = 6, Price = 4300, CreatedDate = DateTime.Now },

            new VillaDto { Id = 11, Name = "Mountain VillaDto 1", Occupancy = 4, Price = 3000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 12, Name = "Mountain VillaDto 2", Occupancy = 5, Price = 3200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 13, Name = "Mountain VillaDto 3", Occupancy = 6, Price = 3400, CreatedDate = DateTime.Now },
            new VillaDto { Id = 14, Name = "Mountain VillaDto 4", Occupancy = 7, Price = 3600, CreatedDate = DateTime.Now },
            new VillaDto { Id = 15, Name = "Mountain VillaDto 5", Occupancy = 8, Price = 3800, CreatedDate = DateTime.Now },

            new VillaDto { Id = 16, Name = "Garden VillaDto 1", Occupancy = 3, Price = 2800, CreatedDate = DateTime.Now },
            new VillaDto { Id = 17, Name = "Garden VillaDto 2", Occupancy = 4, Price = 3000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 18, Name = "Garden VillaDto 3", Occupancy = 5, Price = 3200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 19, Name = "Garden VillaDto 4", Occupancy = 6, Price = 3400, CreatedDate = DateTime.Now },
            new VillaDto { Id = 20, Name = "Garden VillaDto 5", Occupancy = 7, Price = 3600, CreatedDate = DateTime.Now },

            new VillaDto { Id = 21, Name = "Private VillaDto 1", Occupancy = 2, Price = 2500, CreatedDate = DateTime.Now },
            new VillaDto { Id = 22, Name = "Private VillaDto 2", Occupancy = 3, Price = 2700, CreatedDate = DateTime.Now },
            new VillaDto { Id = 23, Name = "Private VillaDto 3", Occupancy = 4, Price = 2900, CreatedDate = DateTime.Now },
            new VillaDto { Id = 24, Name = "Private VillaDto 4", Occupancy = 5, Price = 3100, CreatedDate = DateTime.Now },
            new VillaDto { Id = 25, Name = "Private VillaDto 5", Occupancy = 6, Price = 3300, CreatedDate = DateTime.Now },

            new VillaDto { Id = 26, Name = "Family VillaDto 1", Occupancy = 8, Price = 4000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 27, Name = "Family VillaDto 2", Occupancy = 9, Price = 4200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 28, Name = "Family VillaDto 3", Occupancy = 10, Price = 4400, CreatedDate = DateTime.Now },
            new VillaDto { Id = 29, Name = "Family VillaDto 4", Occupancy = 6, Price = 3800, CreatedDate = DateTime.Now },
            new VillaDto { Id = 30, Name = "Family VillaDto 5", Occupancy = 7, Price = 3900, CreatedDate = DateTime.Now },

            new VillaDto { Id = 31, Name = "Premium VillaDto 1", Occupancy = 4, Price = 5000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 32, Name = "Premium VillaDto 2", Occupancy = 5, Price = 5200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 33, Name = "Premium VillaDto 3", Occupancy = 6, Price = 5400, CreatedDate = DateTime.Now },
            new VillaDto { Id = 34, Name = "Premium VillaDto 4", Occupancy = 7, Price = 5600, CreatedDate = DateTime.Now },
            new VillaDto { Id = 35, Name = "Premium VillaDto 5", Occupancy = 8, Price = 5800, CreatedDate = DateTime.Now },

            new VillaDto { Id = 36, Name = "Eco VillaDto 1", Occupancy = 3, Price = 2600, CreatedDate = DateTime.Now },
            new VillaDto { Id = 37, Name = "Eco VillaDto 2", Occupancy = 4, Price = 2800, CreatedDate = DateTime.Now },
            new VillaDto { Id = 38, Name = "Eco VillaDto 3", Occupancy = 5, Price = 3000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 39, Name = "Eco VillaDto 4", Occupancy = 6, Price = 3200, CreatedDate = DateTime.Now },
            new VillaDto { Id = 40, Name = "Eco VillaDto 5", Occupancy = 7, Price = 3400, CreatedDate = DateTime.Now },

            new VillaDto { Id = 41, Name = "Royal VillaDto 1", Occupancy = 10, Price = 7000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 42, Name = "Royal VillaDto 2", Occupancy = 12, Price = 7500, CreatedDate = DateTime.Now },
            new VillaDto { Id = 43, Name = "Royal VillaDto 3", Occupancy = 14, Price = 8000, CreatedDate = DateTime.Now },
            new VillaDto { Id = 44, Name = "Royal VillaDto 4", Occupancy = 16, Price = 8500, CreatedDate = DateTime.Now },
            new VillaDto { Id = 45, Name = "Royal VillaDto 5", Occupancy = 18, Price = 9000, CreatedDate = DateTime.Now },

            new VillaDto { Id = 46, Name = "City VillaDto 1", Occupancy = 2, Price = 2300, CreatedDate = DateTime.Now },
            new VillaDto { Id = 47, Name = "City VillaDto 2", Occupancy = 3, Price = 2500, CreatedDate = DateTime.Now },
            new VillaDto { Id = 48, Name = "City VillaDto 3", Occupancy = 4, Price = 2700, CreatedDate = DateTime.Now },
            new VillaDto { Id = 49, Name = "City VillaDto 4", Occupancy = 5, Price = 2900, CreatedDate = DateTime.Now },
            new VillaDto { Id = 50, Name = "City VillaDto 5", Occupancy = 6, Price = 3100, CreatedDate = DateTime.Now }
        };
    }
}
