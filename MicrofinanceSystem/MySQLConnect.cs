using System.Data;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

[StandardModule]
internal sealed class MySQLConnect
{
	public static MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=microfinance_db");

	public static void OpenConnection()
	{
		if (conn.State == ConnectionState.Closed)
		{
			conn.Open();
		}
	}

	public static void CloseConnection()
	{
		if (conn.State == ConnectionState.Open)
		{
			conn.Close();
		}
	}
}
