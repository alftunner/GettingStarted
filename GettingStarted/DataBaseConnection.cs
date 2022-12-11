﻿using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GettingStarted;

public static class DataBaseConnection
{
    private static string host = "localhost"; // Имя хоста
    private static string database = "test"; // Имя базы данных
    private static string user = "root"; // Имя пользователя
    private static string password = "root"; // Пароль пользователя
    private static string Connect;
    private static MySqlConnection mySqlConnection;

    public static MySqlConnection getConnection()
    {
        Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
        mySqlConnection = new MySqlConnection(Connect);
        return mySqlConnection;
    }
}