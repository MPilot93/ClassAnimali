using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public class Train : IVehicle, PeopleTransport
    {
       public string GetName (){ return "treno"; }

        

        public string TransportType(PeopleTransport train)
        {
            return $"sono un veicolo di tipo {vehicle.GetName}";
        }
    }
}
