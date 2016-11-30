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
        List<Client> ClientSort = new List<Client>();

        public List<Client> Clients
        {
            set { ClientList = value; }
            get { return ClientList; }
        }

        public List<Client> ClientsSort
        {
            set { ClientSort = value; }
            get { return ClientSort; }
        }

        public String[] GetName
        {
            get
            {
                var res = from el in ClientList select el.Fullname1;
                return res.ToArray();
            }
        }
    }
}
