using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Core.Models.Houses;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();

        Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> CategoryExistsAsync(int categoryId);

        Task<int> CreateAsync(HouseFormModel model, int agentId);
    }
}
