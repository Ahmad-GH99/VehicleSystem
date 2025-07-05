using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem.Domain.Entities
{
    public class VehicleType
    {

        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }

        public Make Make { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }


        #region Constructors 

        public VehicleType()
        {
            Vehicles = new List<Vehicle>();
        }

        public VehicleType(int vehicleTypeId, string vehicleTypeName, int makeId)
        {
            VehicleTypeId = vehicleTypeId;
            VehicleTypeName = vehicleTypeName;
            MakeId = makeId;
            Vehicles = new List<Vehicle>();
        }
        #endregion

    }
}
