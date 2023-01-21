using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_events.lib.Messenger
{
    public class Email
    {
        public void SendMensage(Object sender, VideoEventsArgs args)
        {
            Console.WriteLine("Email enviado para o video " + args.Video.Name);
        }
    }
}
