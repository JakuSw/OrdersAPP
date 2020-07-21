using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    class Product : IData
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

		private int amount;

		public int Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		public Product(int id_, string name_, int amount_)
		{
			Id = id_;
			Name = name_;
			Amount = amount_;
		}

		public void ShowData()
		{
			MessageBox.Show(string.Format("ID: {0} \nName: {1} \nAvailible amount: {2} ", Id.ToString(), Name, Amount.ToString()));
		}
		public void UpdateAmount(int updateAmount)
		{
			if(updateAmount < 0)
			{
				MessageBox.Show("Updated amount cant be less than 0!");
			}
			else
			{
				Amount = updateAmount;
				MessageBox.Show("Amount of product updated in database");
			}
		}
	
	}
}
