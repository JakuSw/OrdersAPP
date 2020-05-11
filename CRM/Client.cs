using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Client
    {
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


    }
}
