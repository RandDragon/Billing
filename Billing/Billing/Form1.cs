using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing
{
    public partial class Form1 : Form
    {
        private static List<Client> clientsSort;
        BindingSource bindSrc = new BindingSource();
        private ClientFile Clients;

        public Form1()
        {
            InitializeComponent();
            clientsSort = new List<Client>();
            Clients = new ClientFile();
            bindSrc.DataSource = Clients;
            bindSrc.DataMember = "ClientsSort";
            bindSrc.CurrentItemChanged += BindSrc_CurrentItemChanged;
            dgvClients.DataSource = bindSrc;
            dgvClients.DataSource = Clients;
            dgvClients.DataMember = "ClientsSort";


        }

        private void BindSrc_CurrentItemChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null)
            {
                foreach (var a in Clients.Clients)
                {
                   if(a.Fullname1.Contains(tbName.Text))
                    {
                        Clients.ClientsSort.Add(a);
                        dgvClients.DataSource = bindSrc;
                    }
                }
            }
        }
    }
}
