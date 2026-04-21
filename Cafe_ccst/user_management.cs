using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class user_management : Form
    {
        public user_management()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT id, lastname, firstname, middlename, email, username, password 
                 FROM accounts 
                 WHERE firstname LIKE @search 
                 OR lastname LIKE @search 
                 OR username LIKE @search 
                 OR email LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // 2. Bind the data to your DataGridView (Note: I changed the name to dgvAccounts to make it relevant, change it back if you kept dgvStudents!)
                dgvAccounts.DataSource = table;

                // 3. Rename the headers so they look clean on your dashboard
                dgvAccounts.Columns["id"].HeaderText = "ID";
                dgvAccounts.Columns["lastname"].HeaderText = "Last Name";
                dgvAccounts.Columns["firstname"].HeaderText = "First Name";
                dgvAccounts.Columns["middlename"].HeaderText = "Middle Name";
                dgvAccounts.Columns["email"].HeaderText = "Email Address";
                dgvAccounts.Columns["username"].HeaderText = "Username";
                dgvAccounts.Columns["password"].HeaderText = "Password";

                adapter.Dispose();
                cmd.Dispose();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { db.Close(); }



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_user addUserForm = new add_user();
            addUserForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null || dgvAccounts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an account from the table first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Grab the ID directly from the selected row's "id" column
            int ID = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["id"].Value);

            // 3. Updated confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            // ... The rest of your database connection and DELETE code stays exactly the same!
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "DELETE FROM accounts WHERE id=@id";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", ID);

                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // You can clear whatever text boxes you DO have here (like txtFirstname.Clear();)

                    // Refresh the grid
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Delete failed. Account could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }
        
    }
}
