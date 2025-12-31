using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using VillaMagical.Application.SerializationS;

namespace VillaMagical.Domain.Entities
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 20)]
        public int Occupancy { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(200)]
        public string Avenue { get; set; }

        [Required]
        [MaxLength(200)]
        public string Detail { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedDate { get; set; }
    }
}
