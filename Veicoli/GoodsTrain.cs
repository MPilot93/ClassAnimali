using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public class GoodsTrain : GoodsTransport
    {
        public object GetName => throw new NotImplementedException();

        public string TransportType(ITransportType type)
        {

            return $"sono un veicolo di tipo {type.GetName}";
        }

        public string TransportType(GoodsTrain vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
