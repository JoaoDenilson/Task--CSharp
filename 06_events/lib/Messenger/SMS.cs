using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_events.lib.Messenger
{
    public class SMS
    {
        public void SendMensage(Object sender, VideoEventsArgs args)
        {
            Console.WriteLine("SMS enviado para o video " + args.Video.Name);
        }
    }
}
