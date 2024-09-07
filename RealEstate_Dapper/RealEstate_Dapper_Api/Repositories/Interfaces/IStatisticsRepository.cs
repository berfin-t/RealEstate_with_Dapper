namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AverageProductPriceByRent();
        decimal AverageProductPriceBySale();
        string CityNameByMaxProductCount();
        int DifferentCityCount();
        decimal LastProductPrice();
        int ActiveEmployeeCount();
        int AverageRoomCount();
        string NewestBuildingYear();
        string OldestBuildingYear();
    }
}
