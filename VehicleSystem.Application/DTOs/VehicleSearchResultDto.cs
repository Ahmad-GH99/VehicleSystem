using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Application.DTOs
{
    public class VehicleSearchResultDto
    {
        public MakeDto Make { get; set; }
        public int Year { get; set; }
        public IEnumerable<ModelDto> Models { get; set; }
        public IEnumerable<VehicleTypeDto> VehicleTypes { get; set; }
        public int TotalModels { get; set; }
        public int TotalVehicleTypes { get; set; }
    }
}
