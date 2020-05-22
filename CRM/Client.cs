using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Client
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

        private string nip;

        public string Nip
        {
            get { return nip; }
            set { nip = value; }
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
        public Client()
        {
            id = 0;
            name = null;
            nip = null;
            phone = null;
            location = null;
        }
        public Client(int id_, string name_, string nip_, string phone_, string location_)
        {
            id = id_;
            name = name_;
            nip = nip_;
            phone = phone_;
            location = location_;
        }

        public void EditClient(string name_, string phone_, string location_)
        {
            name = name_;
            phone = phone_;
            location = location_;
        }

    }
}
