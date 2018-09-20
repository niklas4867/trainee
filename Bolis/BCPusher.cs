using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bolis
{
    class BCPusher
    {
        static P2P BCP2P = new P2P("255.255.255.255",54544);
        static BCPusher()
        {
            ThreadStart sender = new ThreadStart(Sender); //Erstelle neuen Thread
            Thread dif = new Thread(sender);
            dif.Start();
        }

        static public void Sender()
        {
            while(true)
            {
                BCP2P.Send(JsonConvert.SerializeObject(main.Bolis, Formatting.Indented));
                //JsonConvert.PopulateObject(JsonConvert.SerializeObject(main.Bolis, Formatting.Indented),main.Bolis);
                Thread.Sleep(10000);
            }
        }
    }
}
