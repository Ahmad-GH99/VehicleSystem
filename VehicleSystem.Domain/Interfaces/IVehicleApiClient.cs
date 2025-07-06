using VehicleSystem.Domain.Entities;

namespace VehicleSystem.Domain.Interfaces
{
    public interface IVehicleApiClient
    {
        Task<IEnumerable<Make>> GetAllMakesAsync();
        Task<IEnumerable<VehicleType>> GetVehicleTypesByMakeIdAsync(int makeId);
        Task<IEnumerable<Model>> GetModelsAsync(int makeId, int year);

    }
}
