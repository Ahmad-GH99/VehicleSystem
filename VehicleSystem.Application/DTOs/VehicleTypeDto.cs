using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Application.DTOs
{
    public class VehicleTypeDto
    {
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
    }
}
