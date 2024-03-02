using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Core.Models.Houses
{
    public class HouseFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseTitleMaxLength, 
            MinimumLength = HouseTitleMinLength, 
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseAddressMaxLength,
            MinimumLength = HouseAddressMinLength,
             ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseDescriptionMaxLength,
            MinimumLength = HouseDescriptionMinLength,
             ErrorMessage = LengthMessage)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal), 
            HousePricePerMonthMinLength, 
            HousePricePerMonthMaxLength,
            ErrorMessage = "Price Per Month must be a positive number and less than {2} leva.")]
        [Display(Name = "Price Per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = new List<HouseCategoryServiceModel>();
    }
}
