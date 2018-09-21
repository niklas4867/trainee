using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Bolis
{
    class BC
    {
        P2P BCP2P = new P2P("255.255.255.255", 54544);
        
        public BC()
        {
           
            Debug.WriteLine(JsonConvert.SerializeObject(main.Bolis, Formatting.Indented));
            BCP2P.Send(JsonConvert.SerializeObject(main.Bolis, Formatting.Indented));
            BCP2P.Send(JsonConvert.DeserializeObject());

        }

        public void StartThreat()
        {

        }
    }
}
