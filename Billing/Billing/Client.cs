using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Client
    {
        
            public string Fullname
        {
            set { Fullname = value; }
            get { return Fullname; }
        }
            public int port
        {
            set { port = value; }
            get { return port; }
        }
            public String ip
        {
            set { ip = value; }
            get { return ip; }
        }
            private String Switch
        {
            set { Switch = value; }
            get { return Switch; }
        }

            public Client(String _Fullname, int _port, String _ip, String _Switch)
            {
                Fullname = _Fullname;
                port = _port;
                ip = _ip;
                Switch = _Switch + ".vs.bcitelecom.ru";
            }

    }
}
