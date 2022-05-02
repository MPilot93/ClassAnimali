using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public class Train : IVehicle
    {
        public object GetName => throw new NotImplementedException();

        public string TransportType(IVehicle vehicle)
        {
            return $"sono un veicolo di tipo {vehicle.GetName}";
        }
    }
}
