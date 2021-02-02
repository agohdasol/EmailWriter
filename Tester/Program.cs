using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Tester
{
  class Program
  {
    static void Main(string[] args)
    {
      SQLiteConnection.CreateFile("test.sqlite");

      var conn = new SQLiteConnection("Data Source=test.sqlite;");
      conn.Open();

      string sql = "create table members (name varchar(20), age int)";

      var cmd = new SQLiteCommand(sql, conn);
      int result = cmd.ExecuteNonQuery();

      sql = "create index idx01 on members(name)";
      cmd = new SQLiteCommand(sql, conn);
      result = cmd.ExecuteNonQuery();

      sql = "insert into members (name, age) values ('황다솔', 30)";
      cmd = new SQLiteCommand(sql, conn);
      result = cmd.ExecuteNonQuery();

      sql = "select * from members";
      cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      while (rdr.Read())
      {
        Console.WriteLine(rdr["name"] + " " + rdr["age"]);
      }
      rdr.Close();

      conn.Close();
    }
  }
}
