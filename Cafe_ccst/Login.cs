using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM accounts WHERE username = @username AND password = @password";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (username == "admin" && password == "password123")
                {
                    admin_dashboard adminDashboard = new admin_dashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (username == "manager" && password == "password123")
                {
                    manager_dashboard managerDashboard = new manager_dashboard();
                    managerDashboard.Show();
                    this.Hide();
                }
                else if (count > 0)
                {
                    MessageBox.Show("Login successful!", "Login");
                    employee_dashboard employeeDashboard = new employee_dashboard();
                    employeeDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { db.Close(); }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            l registerForm = new l();
            registerForm.Show();
            this.Hide();
        }
    }
}
