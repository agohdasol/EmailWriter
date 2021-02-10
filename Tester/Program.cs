using DataProcessor;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;

namespace Tester
{
  class Program
  {
    private static void ExecuteQueryString(SQLiteConnection conn, string sql)
    {
      var cmd = new SQLiteCommand(sql, conn);
      cmd.ExecuteNonQuery();
    }
    private static void MakeSampleDB()
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

      sql = "create table Template (Id integer primary key autoincrement, Name varchar(25), FileName varchar(255))";
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

      sql = "insert into Template (Name, FileName) values ('OA접수보고', '.\\templates\\OA접수보고.htm'), ('신건수임', '.\\templates\\OA접수보고.htm'), ('해외출원기일', '.\\templates\\OA접수보고.htm')";
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
        "('##출원번호##', 'PDF', '의견제출통지서', '출 원 번 호', null), ('##출원인##', 'PDF', '의견제출통지서', '출 원 인 성 명', '(특'), " +
        "('##명칭##', 'PDF', '의견제출통지서', '발 명 의 명 칭', null), ('##발명자##', 'PDF', '의견제출통지서', '발 명 자 성 명', null), " +
        "('##마감일##', 'PDF', '의견제출통지서', '제출기일: ', null), ('##담당자##', 'DB', 'Manager', null, null), " +
        "('##회사명##', 'DB', 'Company', null, null)";
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
    private static void OutlookFoward()
    {
      Application app = new Application();
      Selection mySelections = app.ActiveExplorer().Selection;
      foreach (var mySelection in mySelections)
      {
        MailItem mailItem = (MailItem)mySelection;
        var forwardItem = mailItem.Forward();
        //forwardItem.Subject = "This is the subject";
        forwardItem.To = "someone@example.com";
        forwardItem.Body = "This is the message.";
        try
        {
          forwardItem.Attachments.Add(@"C:\Users\user\Downloads\Git-2.30.0.2-64-bit.exe");//logPath is a string holding path to the log.txt file
        }
        catch (System.Runtime.InteropServices.COMException)
        {
          //안내문 표시하기
        }
        Console.WriteLine("되냐");
        forwardItem.Display(true);
      }
      //MailItem mailItem = app.CreateItem(OlItemType.olMailItem);
      //mailItem.Importance = OlImportance.olImportanceHigh;
      //Selection mySelection = Globals.ThisAddIn.Application.ActiveExplorer().Selection;
      //MailItem mailItem = null;
      //foreach (Object obj in mySelection)
      //{
      //  if (obj is Microsoft.Office.Interop.Outlook.MailItem)
      //  {
      //    mailItem = (Microsoft.Office.Interop.Outlook.MailItem)obj;
      //    mailItem.Forward();
      //    mailItem.Recipients.Add("test@web.com");
      //    mailItem.Send();
      //  }
      //}
    }
    private static void AttachedFileTest()
    {
      List<string> filePathes = new List<string>()
      {
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\20-0489930 등록공보.pdf",
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\20-0489930 의견서.pdf",
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\20-0489930 의견제출통지서.pdf",
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\KU_KU20150002705UP-마스크.pdf",
      };
      List<string> replacer = new List<string>()
      {
        "의견제출통지서",
        "마스크",
      };
      FileAttacher fileAttacher = new FileAttacher(filePathes);
      var files = fileAttacher.GetReplacingFileList(replacer);

      foreach(var file in files)
      {
        Console.WriteLine(file);
      }
    }
    private static void DataTableTest()
    {
      DataTable dt = new DataTable();
      dt.Columns.Add("Name", typeof(string));
      dt.Columns.Add("Num", typeof(Int32));
      dt.Rows.Add("김밥", 123);
      dt.Rows.Add("김치", 11231223);
      dt.Rows.Add("와오앙", 12123);

      var asd=dt.Rows;
      foreach(DataRow r in asd)
      {
        Console.WriteLine(r["Num"]);
      }
    }
    static void Main(string[] args)
    {
      MakeSampleDB();
    }
  }
}
