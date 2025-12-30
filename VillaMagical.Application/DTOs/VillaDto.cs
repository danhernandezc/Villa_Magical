using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using VillaMagical.Application.SerializationS;

namespace VillaMagical.Application.DTOs
{
    public class VillaDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Occupancy { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime CreatedDate { get; set; }
    }
}
