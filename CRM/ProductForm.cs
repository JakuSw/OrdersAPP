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
    public partial class ProductForm : Form
    {
        List<Product> ProductList = new List<Product>();
        public ProductForm()
        {
            InitializeComponent();
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
            ProductDataGridView1.DataSource = source;

        }
        private int idCreator()
        {
            if (ProductList.Count > 0)
            {
                return ProductList.Last().Id + 1;

            }
            else
            {
                return 1;
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv"))
            {
                if (nameBox.Text != "" && Convert.ToInt32(amountNumeric.Value) >= 0  && ProductList.Exists(x => x.Name == nameBox.Text) == false)
                {
                    ProductList.Add(new Product(idCreator(), nameBox.Text, Convert.ToInt32(amountNumeric.Value)));
                    string csv = string.Format("{0},{1},{2}\n", ProductList.Last().Id, ProductList.Last().Name, ProductList.Last().Amount);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv", csv);
                    MessageBox.Show("Product added to database");
                    ProductList[ProductList.Count - 1].ShowData();
                    nameBox.Text = "";
                    amountNumeric.Value = 0;
                }
                else if (ProductList.Exists(x => x.Name == nameBox.Text) == true)
                {
                    MessageBox.Show("This Product is already in database");
                }
                else
                {
                    if (Convert.ToInt32(amountNumeric.Value) < 0)
                    {
                        MessageBox.Show("Amount cant be less than 0");

                    }
                    else
                    {
                        MessageBox.Show("All data are required");

                    }

                }
            }
            else
            {
                if (nameBox.Text != "" && Convert.ToInt32(amountNumeric.Value) >= 0)
                {
                    ProductList.Add(new Product(idCreator(), nameBox.Text, Convert.ToInt32(amountNumeric.Value)));
                    string csv = string.Format("{0},{1},{2}\n", ProductList.Last().Id, ProductList.Last().Name, ProductList.Last().Amount);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv", csv);
                    MessageBox.Show("Product added to database");
                    ProductList[ProductList.Count - 1].ShowData();
                    nameBox.Text = "";
                    amountNumeric.Value = 0;

                }
                else
                {
                    MessageBox.Show("All data are required");
                }
            }
            var source = new BindingSource(ProductList, null);
            ProductDataGridView1.DataSource = source;


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            string csv;
            foreach (var item in ProductList)
            {
                if (item.Id == Int32.Parse(idLbl.Text))
                {
                    item.UpdateAmount(Convert.ToInt32(amountNumeric.Value));
                    csv = string.Format("{0},{1},{2}\n", item.Id, item.Name, item.Amount);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);
                }
                else
                {
                    csv = string.Format("{0},{1},{2}\n", item.Id, item.Name, item.Amount);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\tmp.csv", csv);
                }
            }
            File.Replace(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv", AppDomain.CurrentDomain.BaseDirectory + @"\productdatabackup.csv");
            MessageBox.Show("Database updated");
            var source = new BindingSource(ProductList, null);
            ProductDataGridView1.DataSource = source;
            nameBox.Text = "";
            amountNumeric.Value = 0;

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv"))
            {
                if (ProductList.Exists(x => x.Id == Convert.ToInt32(idLbl.Text)))
                {
                    var productToRemove = ProductList.Single(x => x.Id == Convert.ToInt32(idLbl.Text));
                    ProductList.Remove(productToRemove);

                    string csv;
                    if (ProductList.Count >0 )
                    {
                        foreach (var item in ProductList)
                        {
                            csv = string.Format("{0},{1},{2}\n", item.Id, item.Name, item.Amount);
                            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);
                        } 
                    
                    File.Replace(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv", AppDomain.CurrentDomain.BaseDirectory + @"\productdatabackup.csv");
                    }
                    else if (ProductList.Count == 0)
                    {
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\productdata.csv");
                    }
                    MessageBox.Show("Product removed");
                    nameBox.Text = "";
                    amountNumeric.Value = 0;
                }
                else
                {
                    MessageBox.Show("Product do not exist in database");
                }

            }
            var source = new BindingSource(ProductList, null);
            ProductDataGridView1.DataSource = source;
            nameBox.Text = "";
            amountNumeric.Value = 0;
            idLabel.Text = "";
            
        }

        private void ProductDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                var product = ProductList[index];
                nameBox.Text = product.Name;
                idLbl.Text = product.Id.ToString();
                amountNumeric.Value = Convert.ToDecimal(product.Amount);
                

            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            idLbl.Text = "-";
            amountNumeric.Value = 0;
        }
    }
}
