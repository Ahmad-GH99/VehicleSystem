using VehicleSystem.Domain.Entities;
using VehicleSystem.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;


namespace VehicleSystem.Infrastructure.Services
{
    public class VehicleApiClient : IVehicleApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<VehicleApiClient> _logger;
        public VehicleApiClient(HttpClient httpClient, ILogger<VehicleApiClient> logger)
        {

            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<Make>> GetAllMakesAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<NhtsaResponse<Make>>("getallmakes?format=json");
                return response?.Results ?? Enumerable.Empty<Make>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to fetch makes");
                throw;
            }
        }

        public async Task<IEnumerable<Model>> GetModelsAsync(int makeId, int year)
        {
            try
            {
                var url = $"GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json";
                var response = await _httpClient.GetFromJsonAsync<NhtsaResponse<Model>>(url);
                return response?.Results ?? Enumerable.Empty<Model>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to fetch Model");
                throw;
            }
        }

        public async Task<IEnumerable<VehicleType>> GetVehicleTypesByMakeIdAsync(int makeId)
        {
            try
            {
                var url = $"GetVehicleTypesForMakeId/{makeId}?format=json";
                var response = await _httpClient.GetFromJsonAsync<NhtsaResponse<VehicleType>>(url);
                return response?.Results ?? Enumerable.Empty<VehicleType>();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to fetch Vehicle Type");
                throw;
            }
        }
    }
}
