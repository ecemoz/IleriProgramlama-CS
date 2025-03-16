using System;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public partial class Form1 : Form
    {
        private string[] phoneBook = new string[50]; 
        private int count = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelDelete.Visible = false;
            panelSearch.Visible = false;
            panelList.Visible = false;
        }

        private void btnShowAddPanel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
        }

        private void btnShowDeletePanel_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
        }

        private void btnShowSearchPanel_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
        }

        private void btnShowListPanel_Click(object sender, EventArgs e)
        {
            panelList.Visible = true;

            listBox1.Items.Clear();
            if (count == 0)
            {
                MessageBox.Show("No contacts to display.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(phoneBook[i]);
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (count < 50)
            {
                string no = txtNo.Text.Trim();
                string name = txtName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                string phone = textPhonenumber.Text.Trim();

                if (string.IsNullOrWhiteSpace(no) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("No, Name, and Phone Number fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                phoneBook[count] = $"{no},{name},{surname},{phone}";
                count++;

                MessageBox.Show("Contact Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Phonebook is Full! Cannot add more contacts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            txtNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            textPhonenumber.Clear();
        }

        private void btnCloseList_Click(object sender, EventArgs e)
        {
            panelList.Visible = false;
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            string searchNo = txtSearchNo.Text.Trim();
            listBox2.Items.Clear();
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (phoneBook[i].StartsWith(searchNo + ","))
                {
                    listBox2.Items.Add(phoneBook[i]);
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching contact found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            string deleteNo = txtDeleteNo.Text.Trim();
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (phoneBook[i].StartsWith(deleteNo + ","))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    phoneBook[i] = phoneBook[i + 1]; // Shift left
                }

                count--;
                MessageBox.Show("Contact Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contact Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDeleteNo_TextChanged(object sender, EventArgs e) { }
        private void txtSearchNo_TextChanged(object sender, EventArgs e) { }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
