using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Application.DTOs
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public int? VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }

    }
}
