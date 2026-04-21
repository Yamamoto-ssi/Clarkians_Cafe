using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_ccst
{
    public class DBConnect
    {
        private MySqlConnection connection = new MySqlConnection(
            "server=localhost;user=root;database=cafe_ccst;port=3306;password=;"
        );

        public MySqlConnection Connection => connection;

        public void Open()
        {
            try { if (connection.State != System.Data.ConnectionState.Open) connection.Open(); }
            catch (System.Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }

        public void Close()
        {
            try { if (connection.State != System.Data.ConnectionState.Closed) connection.Close(); }
            catch (System.Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }
    }
}

