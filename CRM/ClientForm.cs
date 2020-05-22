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
    public partial class ClientForm : Form
    {
        Client workClient = new Client();
        public ClientForm()
        {
            InitializeComponent();
            nameBox.Text = workClient.Name;
            nipBox.Text = workClient.Nip;
            phoneBox.Text = workClient.Phone;
            locationBox.Text = workClient.Location;

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
                        return true;
                    }
                }
                
            }
            return false;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                if (nameBox.Text != "" && nipBox.Text != "" && phoneBox.Text != "" && locationBox.Text != "" && isInFile(nipBox.Text) == false)
                {
                    workClient.Name = nameBox.Text;
                    workClient.Nip = nipBox.Text;
                    workClient.Phone = phoneBox.Text;
                    workClient.Location = locationBox.Text;
                    string csv = string.Format("{0},{1},{2},{3}\n", workClient.Name, workClient.Nip, workClient.Phone, workClient.Location);
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
                    workClient.Name = nameBox.Text;
                    workClient.Nip = nipBox.Text;
                    workClient.Phone = phoneBox.Text;
                    workClient.Location = locationBox.Text;
                    string csv = string.Format("{0},{1},{2},{3}\n", workClient.Name, workClient.Nip, workClient.Phone, workClient.Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", csv);
                    MessageBox.Show("Client added to database");

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

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                if (isInFile(nipBox.Text))
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + @"\data.csv";
                    string[] lines = System.IO.File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(',');
                        if (columns[1] == nipBox.Text)
                        {
                            nameBox.Text = columns[0];
                            nipBox.Text = columns[1];
                            phoneBox.Text = columns[2];
                            locationBox.Text = columns[3];
                            saveBtn.Enabled = true;
                            saveBtn.Visible = true;
                            addBtn.Enabled = false;
                            addBtn.Visible = false;
                            nipBox.Enabled = false;                     
                            break;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("There is no client in database with this NIP");
                }
            }
            else
            {
                MessageBox.Show("Database is empty");
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string csv;
            workClient.EditClient(nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text);
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\data.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (columns[1] != nipBox.Text)
                {
                    csv = string.Format("{0},{1},{2},{3}\n", columns[0], columns[1], columns[2], columns[3]);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);
                 }
                

            }
            csv = string.Format("{0},{1},{2},{3}\n", workClient.Name, workClient.Nip, workClient.Phone, workClient.Location);
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);
            File.Replace(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", AppDomain.CurrentDomain.BaseDirectory + @"\databackup.csv");

            MessageBox.Show("Database updated");

        }
    }
}
