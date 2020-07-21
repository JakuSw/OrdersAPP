using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CRM
{
    public partial class OrderForm : Form
    {
        List<IndividualClient> IndividualClientList = new List<IndividualClient>();
        List<BusinessClient> BusinessClientList = new List<BusinessClient>();
        List<Product> ProductList = new List<Product>();
        List<Order> Orders = new List<Order>();
        public OrderForm()
        {
            InitializeComponent();
            //Individual
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\clientdata.csv"))
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\clientdata.csv";
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0] != "")
                {
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(',');
                        IndividualClientList.Add(new IndividualClient(int.Parse(columns[0]), columns[1], columns[2], columns[3], columns[4]));
                    }
                    
                }
                else
                {
                    MessageBox.Show("No individual clients in file");

                }
            }
            else
            {
                MessageBox.Show("Missing file with individual clients");
            }
            //Business
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\data.csv";
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0] != "")
                {
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(',');
                        BusinessClientList.Add(new BusinessClient(int.Parse(columns[0]), columns[1], columns[2], columns[3], columns[4]));
                    }
                
                }
                else
                {
                    MessageBox.Show("No business clients in file");

                }
            }
            else
            {
                MessageBox.Show("Missing file with business clients");
            }
            //Product
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv"))
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv";
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0] != "")
                {
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(',');
                        ProductList.Add(new Product(int.Parse(columns[0]), columns[1], Int32.Parse(columns[2])));
                    }

                }
                else
                {
                    MessageBox.Show("No products in file");

                }
            }
            else
            {
                MessageBox.Show("Missing file with products");
            }
            var source = new BindingSource(ProductList, null);
            ProductGridView.DataSource = source;
        }

        private void IndividualRadioButton_Click(object sender, EventArgs e)
        {
            IndividualRadioButton.Checked = true;
            BusinessRadioButton.Checked = false;
            var source = new BindingSource(IndividualClientList, null);
            ClientGridView.DataSource = source;
        }

        private void BusinessRadioButton_Click(object sender, EventArgs e)
        {
            IndividualRadioButton.Checked = false;
            BusinessRadioButton.Checked = true;
            var source = new BindingSource(BusinessClientList, null);
            ClientGridView.DataSource = source;
        }

        private void ClientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if(IndividualRadioButton.Checked == true)
                {
                    var client = IndividualClientList[index];
                    ClientID.Text = client.Id.ToString();
                }
                else if(BusinessRadioButton.Checked == true)
                {
                    var client = BusinessClientList[index];
                    ClientID.Text = client.Id.ToString();
                }


            }
        }

        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                var product = ProductList[index];
                ProductID.Text = product.Id.ToString();
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (IndividualRadioButton.Checked == true)
            {
                var product = ProductList[Int32.Parse(ProductID.Text)-1];
                var client = IndividualClientList[Int32.Parse(ClientID.Text)-1];
                Orders.Add(new Order(client.Name, product.Name, Convert.ToInt32(AmountNumeric.Value), Convert.ToInt32(PriceLabel.Text)));
                var source = new BindingSource(Orders, null);
                OrderGridView.DataSource = source;
                ProductList[Int32.Parse(ProductID.Text) - 1].UpdateAmount(ProductList[Int32.Parse(ProductID.Text) - 1].Amount - Convert.ToInt32(AmountNumeric.Value));
                source = new BindingSource(ProductList, null);
                ProductGridView.DataSource = source;
                PriceLabel.Text = "";
                AmountNumeric.Value = 0;


            }
            else if (BusinessRadioButton.Checked == true)
            {
                var product = ProductList[Int32.Parse(ProductID.Text)-1];
                var client = BusinessClientList[Int32.Parse(ClientID.Text)-1];
                Orders.Add(new Order(client.Name, product.Name, Convert.ToInt32(AmountNumeric.Value), Convert.ToInt32(PriceLabel.Text)));
                var source = new BindingSource(Orders, null);
                OrderGridView.DataSource = source;
                ProductList[Int32.Parse(ProductID.Text) - 1].UpdateAmount(ProductList[Int32.Parse(ProductID.Text) - 1].Amount - Convert.ToInt32(AmountNumeric.Value));
                source = new BindingSource(ProductList, null);
                ProductGridView.DataSource = source;
                PriceLabel.Text = "";
                AmountNumeric.Value = 0;
            }
        }

        private void AmountNumeric_ValueChanged(object sender, EventArgs e)
        {
            if(AmountNumeric.Value > 0)
            {
                PriceLabel.Text = (Convert.ToInt32(AmountNumeric.Value) * Static.price).ToString();
            }
            else
            {
                PriceLabel.Text = "";
            }
        }
    }
}
