using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public interface PeopleTransport : IVehicle
    {
        string TransportType(Train vehicle);
    }
}
