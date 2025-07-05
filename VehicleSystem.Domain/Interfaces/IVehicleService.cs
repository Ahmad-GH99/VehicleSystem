using VehicleSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Domain.Interfaces
{
    public interface IVehicleService
    {
        Task<IEnumerable<Make>> GetAllMakesAsync();
        Task<IEnumerable<VehicleType>> GetVehicleTypesByMakeIdAsync(int makeId);
        Task<IEnumerable<Model>> GetModelsAsync(int makeId, int year);
    }
}
