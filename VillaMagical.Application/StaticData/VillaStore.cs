using VillaMagical.Application.DTOs;

namespace VillaMagical.Application.StaticData
{
    public static class VillaStore
    {
        public static List<VillaDto> VillaList { get; set; } = new()
        {
        new VillaDto
        {
            Id = 1,
            Name = "Luxury Villa 1",
            Occupancy = 4,
            Price = 3500.00m,
            Avenue = "Ocean Avenue 101",
            Detail = "Luxury villa with ocean view",
            ImageUrl = "https://example.com/images/villa1.jpg",
            CreatedDate = DateTime.UtcNow
        },
        new VillaDto
        {
            Id = 2,
            Name = "Luxury Villa 2",
            Occupancy = 5,
            Price = 3700.00m,
            Avenue = "Ocean Avenue 102",
            Detail = "Spacious luxury villa near the beach",
            ImageUrl = "https://example.com/images/villa2.jpg",
            CreatedDate = DateTime.UtcNow
        },
        new VillaDto
        {
            Id = 3,
            Name = "Beach Villa 1",
            Occupancy = 6,
            Price = 4200.00m,
            Avenue = "Beach Road 201",
            Detail = "Beachfront villa with private access",
            ImageUrl = "https://example.com/images/villa3.jpg",
            CreatedDate = DateTime.UtcNow
        },
        new VillaDto
        {
            Id = 4,
            Name = "Mountain Villa 1",
            Occupancy = 4,
            Price = 3000.00m,
            Avenue = "Mountain Way 301",
            Detail = "Cozy mountain villa with fireplace",
            ImageUrl = "https://example.com/images/villa4.jpg",
            CreatedDate = DateTime.UtcNow
        },
        new VillaDto
        {
            Id = 5,
            Name = "Garden Villa 1",
            Occupancy = 3,
            Price = 2800.00m,
            Avenue = "Garden Street 401",
            Detail = "Villa surrounded by gardens",
            ImageUrl = "https://example.com/images/villa5.jpg",
            CreatedDate = DateTime.UtcNow
        }

        // 👉 Continúas el mismo patrón hasta llegar a 50
        };
    }

}
