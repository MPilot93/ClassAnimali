﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public interface GoodsTransport : IVehicle
    {
        string TransportType(GoodsTrain vehicle);
    }
}
