using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace DataProcessor
{
  class SQLite
  {
    public static void SQLiteInitializer()
    {
      SQLiteConnection.CreateFile("emailwriterdb.sqlite");
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();

      string sql = "create table company (name varchar(25), email varchar(50), address varchar(100), phone varchar(20))" +
        "create table department (name varchar(25))" +
        "create table manager (name varchar(25), email varchar(50), phone varchar(20), rank varchar(20))";

      var cmd = new SQLiteCommand(sql, conn);
      int result = cmd.ExecuteNonQuery();

      sql = "insert into company (name, email) values ('아너스특허법률사무소', 'info@honorspat.com'), ('아아피텍코리아', 'info@iptk.co.kr')";
      cmd = new SQLiteCommand(sql, conn);
      result = cmd.ExecuteNonQuery();

      sql = "select * from company";
      cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      while (rdr.Read())
      {
        Console.WriteLine(rdr["name"] + " " + rdr["email"]);
      }
      rdr.Close();

      conn.Close();
    }
  }
}
