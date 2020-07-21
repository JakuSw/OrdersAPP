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

    public partial class BusinessClientForm : Form
    {
        List<BusinessClient> ClientsList = new List<BusinessClient>();
        public BusinessClientForm()
        {
            InitializeComponent();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\data.csv";
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0] != "")
                {
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(',');
                        ClientsList.Add(new BusinessClient(int.Parse(columns[0]), columns[1], columns[2], columns[3], columns[4]));                        
                    }
                    businessClientBindingSource.DataSource = ClientsList;
                }
                else
                {
                    MessageBox.Show("No clients in file");

                }
            }
            else
            {
                MessageBox.Show("Missing file with clients");
            }

        }
        private int idCreator()
        {
            if (ClientsList.Count > 0)
            {
                return ClientsList.Last().Id + 1;

            }
            else
            {
                return 1;
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                if (nameBox.Text != "" && nipBox.Text != "" && phoneBox.Text != "" && locationBox.Text != "" && ClientsList.Exists(x => x.Nip == nipBox.Text) == false)
                {
                    ClientsList.Add(new BusinessClient(idCreator(), nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text));
                    string csv = string.Format("{0},{1},{2},{3},{4}\n", ClientsList.Last().Id, ClientsList.Last().Name, ClientsList.Last().Nip, ClientsList.Last().Phone, ClientsList.Last().Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", csv);
                    MessageBox.Show("Client added to database");
                    ClientsList[ClientsList.Count-1].ShowData();
                    nameBox.Text = "";
                    nipBox.Text = "";
                    phoneBox.Text = "";
                    locationBox.Text = "";
                }
                else if (ClientsList.Exists(x => x.Nip == nipBox.Text) == true)
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
                    ClientsList.Add(new BusinessClient(idCreator(), nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text));
                    string csv = string.Format("{0},{1},{2},{3},{4}\n", ClientsList.Last().Id, ClientsList.Last().Name, ClientsList.Last().Nip, ClientsList.Last().Phone, ClientsList.Last().Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", csv);
                    MessageBox.Show("Client added to database");                    
                    nameBox.Text = "";
                    nipBox.Text = "";
                    phoneBox.Text = "";
                    locationBox.Text = "";

                }
                else
                {
                    MessageBox.Show("All data are required");
                }
            }     
            var source = new BindingSource(ClientsList, null);
            ClientDataGridView1.DataSource = source;


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            string csv;
            foreach (var item in ClientsList)
            {
                if (item.Nip == nipBox.Text)
                {
                    item.Edit(nameBox.Text, phoneBox.Text, locationBox.Text);
                    csv = string.Format("{0},{1},{2},{3},{4}\n", item.Id, item.Name, item.Nip, item.Phone, item.Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);  
                }
                else
                {
                    csv = string.Format("{0},{1},{2},{3},{4}\n", item.Id, item.Name, item.Nip, item.Phone, item.Location);
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);
                }
            }
            File.Replace(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", AppDomain.CurrentDomain.BaseDirectory + @"\databackup.csv");
            MessageBox.Show("Database updated");      
            var source = new BindingSource(ClientsList, null);
            ClientDataGridView1.DataSource = source;

            nameBox.Text = "";
            nipBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
            idLabel.Text = "";
            nipBox.Enabled = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                if (ClientsList.Exists(x => x.Nip == nipBox.Text))
                {
                    var clientToRemove = ClientsList.Single(x => x.Nip == nipBox.Text);
                    ClientsList.Remove(clientToRemove);
                    string csv;
                    foreach (var item in ClientsList)
                    {
                        csv = string.Format("{0},{1},{2},{3},{4}\n", item.Id, item.Name, item.Nip, item.Phone, item.Location);
                        File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", csv);
                    }
                    File.Replace(AppDomain.CurrentDomain.BaseDirectory + @"\temp.csv", AppDomain.CurrentDomain.BaseDirectory + @"\data.csv", AppDomain.CurrentDomain.BaseDirectory + @"\databackup.csv");
                    MessageBox.Show("Client ");
                    nipBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Cleint do not exist in database");
                }

            }
            var source = new BindingSource(ClientsList, null);
            ClientDataGridView1.DataSource = source;
            nameBox.Text = "";
            nipBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
            idLabel.Text = "";
            nipBox.Enabled = true;
        }

        private void ClientDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;
            if(index >= 0)
            {
                var client = ClientsList[index];
                nameBox.Text = client.Name;
                nipBox.Text = client.Nip;
                phoneBox.Text = client.Phone;
                locationBox.Text = client.Location;
                idLabel.Text = client.Id.ToString();
                nipBox.Enabled = false;

            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            nipBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
            idLabel.Text = "";
            nipBox.Enabled = true;

        }
    }
}
