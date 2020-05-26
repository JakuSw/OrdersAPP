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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                if (nameBox.Text != "" && nipBox.Text != "" && phoneBox.Text != "" && locationBox.Text != "" && ClientsList.Exists(x => x.Nip == nipBox.Text) == false)
                {
                    ClientsList.Add(new BusinessClient(ClientsList.Count + 1, nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text));
                    string csv = string.Format("{0},{1},{2},{3},{4}\n", (ClientsList.Count).ToString(), nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text);
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
                    ClientsList.Add(new BusinessClient((ClientsList.Count + 1), nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text));
                    string csv = string.Format("{0},{1},{2},{3},{4}\n", (ClientsList.Count).ToString(), nameBox.Text, nipBox.Text, phoneBox.Text, locationBox.Text);
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
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\data.csv"))
            {
                if (ClientsList.Exists(x => x.Nip == nipBox.Text))
                {
                    foreach (var item in ClientsList)
                    {
                        if (item.Nip == nipBox.Text)
                        {
                            nameBox.Text = item.Name;
                            phoneBox.Text = item.Phone;
                            locationBox.Text = item.Location;
                            saveBtn.Enabled = true;
                            saveBtn.Visible = true;
                            addBtn.Enabled = false;
                            addBtn.Visible = false;
                            nipBox.Enabled = false;
                            idLabel.Text = item.Id.ToString();
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
            nameBox.Text = "";
            nipBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
            idLabel.Text = "";
            saveBtn.Enabled = false;
            saveBtn.Visible = false;
            addBtn.Enabled = true;
            addBtn.Visible = true;
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
        }
    }
}
