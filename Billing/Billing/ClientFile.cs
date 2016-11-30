using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class ClientFile
    {
        List<Client> ClientList = Install.ClientList();

        public List<Client> Clients
        {
            set { ClientList = value; }
            get { return ClientList; }
        }
    }
}
