using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRM
{
    class IndividualClient : ClientBase
    {
		private string pesel;

		public string Pesel
		{
			get { return pesel; }
			set { pesel = value; }
		}
        public IndividualClient() : base()
        {
            this.pesel = null;

        }
        public IndividualClient(int id_, string name_, string pesel_, string phone_, string location_) : base(id_, name_, phone_, location_)
        {
            this.Id = id_;
            this.Name = name_;
            this.pesel = pesel_;
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
            MessageBox.Show(string.Format("ID: {0} \nName: {1} \nPESEL: {2} \nPhone: {3} \nLocation: {4} ", Id.ToString(), Name, pesel, Phone, Location));
        }
    }
}
