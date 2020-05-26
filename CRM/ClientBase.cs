using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    abstract class ClientBase : IData
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public ClientBase()
        {
            this.id = 0;
            this.name = null;
            this.phone = null;
            this.location = null;
        }
        public ClientBase(int id_, string name_, string phone_, string location_)
        {
            this.id = 0;
            this.name = null;
            this.phone = null;
            this.location = null;
        }
        public virtual void ShowData() {

        }
        
        


    }
}
