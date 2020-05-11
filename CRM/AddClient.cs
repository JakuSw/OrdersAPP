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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        private bool fileExist()
        {
            return File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv");
        }

        private bool isInFile(string niptocheck)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\data.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    if(column.Equals(niptocheck))
                    {
                        MessageBox.Show(column);
                        return true;
                    }
                }
                
            }
            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fileExist())
            {
                if (nameBox.Text != "" && nipBox.Text != "" && phoneBox.Text != "" && locationBox.Text != "" && isInFile(nipBox.Text) == false)
                {
                    Client newClient = new Client() { Name = nameBox.Text, Nip = nipBox.Text, Phone = phoneBox.Text, Location = locationBox.Text };
                    string csv = string.Format("{0},{1},{2},{3}\n", newClient.Name, newClient.Nip, newClient.Phone, newClient.Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", csv);
                    MessageBox.Show("Client added to database");

                }
                else if (isInFile(nipBox.Text) == true)
                {
                    MessageBox.Show("This NIP is already in database");
                }
                else
                {
                    MessageBox.Show("All data are required");
                }
            }
            else
            {
                if (nameBox.Text != "" && nipBox.Text != "" && phoneBox.Text != "" && locationBox.Text != "")
                {
                    Client newClient = new Client() { Name = nameBox.Text, Nip = nipBox.Text, Phone = phoneBox.Text, Location = locationBox.Text };
                    string csv = string.Format("{0},{1},{2},{3}\n", newClient.Name, newClient.Nip, newClient.Phone, newClient.Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", csv);
                }
                else
                {
                    MessageBox.Show("All data are required");
                }
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
