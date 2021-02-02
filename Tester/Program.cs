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
    public static void ExecuteQueryString(SQLiteConnection conn, string sql)
    {
      var cmd = new SQLiteCommand(sql, conn);
      cmd.ExecuteNonQuery();
    }
    static void Main(string[] args)
    {
      SQLiteConnection.CreateFile("emailwriterdb.sqlite");
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();

      string sql = "create table company (id integer primary key autoincrement, name varchar(25), email varchar(50), address varchar(100), phone varchar(20))";
      ExecuteQueryString(conn, sql);
      sql = "create table department (id integer primary key autoincrement, name varchar(25))";
      ExecuteQueryString(conn, sql);
      sql = "create table manager (id integer primary key autoincrement, name varchar(25), email varchar(50), phone varchar(20), rank varchar(20), company_id integer, department_id integer)";
      ExecuteQueryString(conn, sql);

      sql = "insert into company (name, email) values ('아너스특허법률사무소', 'info@honorspat.com'), ('아아피텍코리아', 'info@iptk.co.kr')";
      ExecuteQueryString(conn, sql);

      sql = "INSERT INTO manager (name, email, phone, rank) VALUES ('황다솔', 'dasol.hwang@honorspat.com', '010-4046-0091', '선임 연구원'), " +
        "('정성원', 'asd@honorspat.com', '010-1226-0091', '선임 연구원'), " +
        "('이다솜', 'qwe@honorspat.com', '010-4564-0091', '선임 연구원')";
      ExecuteQueryString(conn, sql);

      sql = "select * from company";
      var cmd = new SQLiteCommand(sql, conn);
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
