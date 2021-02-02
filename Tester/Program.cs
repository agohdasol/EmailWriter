using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tester
{
  class Program
  {
    static void Main(string[] args)
    {
      string lines = File.ReadAllText(@"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\검토의견.htm", Encoding.Default);
      Console.WriteLine(lines);
    }
  }
}
