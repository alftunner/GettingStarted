using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GettingStarted;

public class UserTable
{
    public MySqlConnection Connection;
    public Dictionary<string, string> loginPassword;

    public UserTable()
    {
        this.Connection = DataBaseConnection.getConnection();
        this.loginPassword = new Dictionary<string, string>();
    }

    private void getAllUsers()
    {
        MySqlCommand mysql_query = Connection.CreateCommand();
        mysql_query.CommandText = "SELECT login, password FROM users;";
        Connection.Open();
        MySqlDataReader mysql_result = mysql_query.ExecuteReader();

        while (mysql_result.Read())
        {
            this.loginPassword.Add(mysql_result.GetString(0), mysql_result.GetString(1));
        }
    }

    public bool compareLoginPassword(string login, string password)
    {
        bool result = false;
        this.getAllUsers();
        foreach (var item in this.loginPassword)
        {
            if (item.Key == login && item.Value == password)
            {
                result = true;
                break;
            }
        }
        return result;
    }
}