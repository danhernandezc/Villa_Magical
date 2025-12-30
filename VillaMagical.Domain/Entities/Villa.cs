using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using VillaMagical.Application.SerializationS;

namespace VillaMagical.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 20)]
        public int Occupancy { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
