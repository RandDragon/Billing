using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Install
    {
        static public List<Client> ClientList()
        {
            List<Client> ClientList = new List<Client>();
            StreamReader sr = new StreamReader("LoadBD.csv", Encoding.GetEncoding(1251));
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                try
                {

                    string[] str = sr.ReadLine().Split(';');

                    String[] port = str[1].Split('@');
                    int numport;

                    int.TryParse(port[0], out numport);
                    Client client = new Client(str[0], numport, str[2], port[1]);
                    ClientList.Add(client);


                }
                catch (Exception)
                { }
                finally
                {
                    
                }

            }
            return ClientList;
            sr.Close();
        }
    }
}
