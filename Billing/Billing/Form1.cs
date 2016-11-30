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
        BindingSource bindSrc = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            ClientFile Clients = new ClientFile();
            bindSrc.DataSource = Clients;
            bindSrc.DataMember = "Clients";
            dgvClients.DataSource = bindSrc;
        }

    }
}
