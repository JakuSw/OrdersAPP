using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BClientBtn_Click(object sender, EventArgs e)
        {
            BusinessClientForm ClientWindow = new BusinessClientForm();
            ClientWindow.Show();
        }

        private void PClientBtn_Click(object sender, EventArgs e)
        {
            IndividualClientForm ClientWindow = new IndividualClientForm();
            ClientWindow.Show();
        }
    }
}
