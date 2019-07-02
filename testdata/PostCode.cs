using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using OfficeOpenXml;
//using Excel = Microsoft.Office.Interop.Excel;


namespace Test.testdata
{
    public class PostCode
    {
        public List<string> loadCsvFile()
        {
            string projectDirectory = Directory.GetParent("test").Parent.FullName;
            var reader = new StreamReader(File.OpenRead(projectDirectory.Replace("/bin", "/testdata/PostCodesDataCSV.csv")));
          
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }

      
    }
}
