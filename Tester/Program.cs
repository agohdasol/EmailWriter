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
    private static void ExecuteQueryString(SQLiteConnection conn, string sql)
    {
      var cmd = new SQLiteCommand(sql, conn);
      cmd.ExecuteNonQuery();
    }
    static void Main(string[] args)
    {
      SQLiteConnection.CreateFile("emailwriterdb.sqlite");
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();

      string sql = "create table Company " +
        "(Id integer primary key autoincrement, Name varchar(25), Email varchar(50), Address varchar(100), Phone varchar(20))";
      ExecuteQueryString(conn, sql);

      sql = "create table Department " +
        "(Id integer primary key autoincrement, Name varchar(25))";
      ExecuteQueryString(conn, sql);

      sql = "create table TemplateGroup " +
        "(Id integer primary key autoincrement, Name varchar(25), Department_Id integer," +
        "foreign key(Department_Id) references Department(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table Manager " +
        "(Id integer primary key autoincrement, Name varchar(25), Email varchar(50), Phone varchar(20), Rank varchar(20))";
      ExecuteQueryString(conn, sql);

      sql = "create table Template (Id integer primary key autoincrement, Name varchar(25))";
      ExecuteQueryString(conn, sql);

      sql = "create table FileName (Id integer primary key autoincrement, Name varchar(25))";
      ExecuteQueryString(conn, sql);

      sql = "create table CompanyManager (Id integer primary key autoincrement, Company_Id integer, Manager_Id integer," +
        "foreign key(Company_Id) references Company(Id), foreign key(Manager_Id) references Manager(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table CompanyDepartment (Id integer primary key autoincrement, Company_Id integer, Department_Id integer," +
        "foreign key(Company_Id) references Company(Id), foreign key(Department_Id) references Department(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table DepartmentManager (Id integer primary key autoincrement, Department_Id integer, Manager_Id integer," +
        "foreign key(Department_Id) references Department(Id), foreign key(Manager_Id) references Manager(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table DepartmentTemplateGroup (Id integer primary key autoincrement, Department_Id integer, TemplateGroup_Id integer," +
        "foreign key(Department_Id) references Department(Id), foreign key(TemplateGroup_Id) references TemplateGroup(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table TemplateGroupTemplate (Id integer primary key autoincrement, TemplateGroup_Id integer, Template_Id integer," +
        "foreign key(TemplateGroup_Id) references TemplateGroup(Id), foreign key(Template_Id) references Template(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table TemplateFileName (Id integer primary key autoincrement, Template_Id integer, FileName_Id integer," +
        "foreign key(Template_Id) references Template(Id), foreign key(FileName_Id) references FileName(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table Replacer " +
        "(Id integer primary key autoincrement, Name varchar(50), Location varchar(20), Finder1 varchar(50), Finder2 varchar(50), Finder3 varchar(50))";
      ExecuteQueryString(conn, sql);

      sql = "insert into Company (Name, Email) values ('아너스특허법률사무소', 'info@honorspat.com'), ('아이피텍코리아', 'info@iptk.co.kr')";
      ExecuteQueryString(conn, sql);

      sql = "insert into Department (Name) values ('관리팀'), ('특허팀')";
      ExecuteQueryString(conn, sql);

      sql = "insert into TemplateGroup (Name) values ('관리팀'), ('특허팀')";
      ExecuteQueryString(conn, sql);

      sql = "insert into Template (Name) values ('OA접수보고'), ('신건수임'), ('해외출원기일')";
      ExecuteQueryString(conn, sql);

      sql = "insert into FileName (Name) values ('의견제출통지서'), ('거절결정서'), ('출원서')";
      ExecuteQueryString(conn, sql);

      sql = "INSERT INTO Manager (Name, Email, Phone, Rank)" +
        "VALUES ('황다솔', 'dasol.hwang@honorspat.com', '010-4563-0091', '선임 연구원'), " +
        "('정성원', 'asd@honorspat.com', '010-1226-0091', '선임 연구원'), " +
        "('이다솜', 'qwe@honorspat.com', '010-4564-0091', '선임 연구원'), " +
        "('김가영', 'zxc@honorspat.com', '010-7415-0091', '대리'), " +
        "('최한나', 'zer@honorspat.com', '010-7852-0091', '대리')";
      ExecuteQueryString(conn, sql);

      sql = "insert into CompanyManager (Company_Id, Manager_Id) values (1, 1), (1, 2), (1, 3), (1, 4), (2, 5), (2, 1), (2, 2), (2, 3)";
      ExecuteQueryString(conn, sql);
      sql = "insert into CompanyDepartment (Company_Id, Department_Id) values (1, 1), (1, 2), (2, 1)";
      ExecuteQueryString(conn, sql);
      sql = "insert into DepartmentManager (Department_Id, Manager_Id) values (1, 4), (1, null), (2, 1), (2, 2), (2, 3)";
      ExecuteQueryString(conn, sql);
      sql = "insert into DepartmentTemplateGroup (Department_Id, TemplateGroup_Id) values (1, 1), (2, 2)";
      ExecuteQueryString(conn, sql);
      sql = "insert into TemplateGroupTemplate (TemplateGroup_Id, Template_Id) values (1, 3), (2, 1), (2, 2)";
      ExecuteQueryString(conn, sql);
      sql = "insert into TemplateFileName (Template_Id, FileName_Id) values (1, 1), (1, 2)";
      ExecuteQueryString(conn, sql);
      sql = "insert into Replacer (Name, Location, Finder1, Finder2, Finder3) values " +
        "('##출원번호##', 'PDF', '의견제출통지서', '출 원 번 호', null), ('##출원인##', 'PDF', '의견제출통지서', '출 원 인 성 명', '(특')";
      ExecuteQueryString(conn, sql);

      //sql = "select * from Manager m " +
      //  "left join Company_Manager cm on cm.Manager_Id = m.Id " +
      //  "where cm.Company_Id = 2";

      //Select Id from sometable where Name like '%omm%'
      sql = "select Id from Company where Name = '아이피텍코리아'";

      var cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      while (rdr.Read())
      {
        Console.WriteLine(rdr["Id"]);
      }
      rdr.Close();

      conn.Close();
    }
  }
}
