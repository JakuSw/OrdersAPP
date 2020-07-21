using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Order 
    {
		private string client;

		public string Client
		{
			get { return client; }
			set { client = value; }
		}
		private string products;

		public string Products
		{
			get { return products; }
			set { products = value; }
		}

		private int amount;

		public int Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		private int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}


		public Order(string client_, string products_, int amount_, int price_)
		{
			client = client_;
			products = products_;
			amount = amount_;
			price = price_;
		}
	}
}
