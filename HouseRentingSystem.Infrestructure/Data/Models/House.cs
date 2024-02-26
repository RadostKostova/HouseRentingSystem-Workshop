using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House name")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        //[Range(typeof(decimal), HousePricePerMonthMinLength, HousePricePerMonthMaxLength, ConvertValueInInvariantCulture = true)]
        [Comment("House price per month")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Agent identifier")]
        public int AgentId { get; set; }

        [Comment("User Id of the renterer")]
        public string? RenterId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;
    }
}
