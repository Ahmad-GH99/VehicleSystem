using VehicleSystem.Domain.Entities;
using VehicleSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleApiClient _vehicleApiClient;
        public VehicleService(IVehicleApiClient vehicleApiClient)
        {
            _vehicleApiClient = vehicleApiClient;
        }

        public async Task<IEnumerable<Make>> GetAllMakesAsync()
        {

            var make = await _vehicleApiClient.GetAllMakesAsync();
            return make;
        }

        public async Task<IEnumerable<Model>> GetModelsAsync(int makeId, int year)
        {
            var task = await _vehicleApiClient.GetModelsAsync(makeId, year);
            return task;
        }

        public async Task<IEnumerable<VehicleType>> GetVehicleTypesByMakeIdAsync(int makeId)
        {
            
            var VehicleTypes = await _vehicleApiClient.GetVehicleTypesByMakeIdAsync(makeId);
            return VehicleTypes;
        }
    }
}
