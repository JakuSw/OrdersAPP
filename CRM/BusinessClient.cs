using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRM
{
    class BusinessClient : ClientBase
    {
        private string nip;

        public string Nip
        {
            get { return nip; }
            set { nip = value; }
        }

        public BusinessClient() : base()
        {
            this.nip = null;

        }
        public BusinessClient(int id_, string name_, string nip_, string phone_, string location_) : base(id_, name_, phone_, location_)
        {
            this.Id = id_;
            this.Name = name_;
            this.nip = nip_;
            this.Phone = phone_;
            this.Location = location_;

        }

        public void Edit(string name_, string phone_, string location_)
        {
            this.Name = name_;
            this.Phone = phone_;
            this.Location = location_;
        }
        public override void ShowData()
        {
            MessageBox.Show(string.Format("ID: {0} \nName: {1} \nNIP: {2} \nPhone: {3} \nLocation: {4} ", Id.ToString(), Name, nip, Phone, Location));
        }

    }
}
