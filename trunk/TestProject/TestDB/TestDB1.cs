using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.IO;

namespace TestDB
{
    public class TestDB1
    {
        public List<string> excelToSql(string file)
        {
           
            FileInfo newFile = new FileInfo(file);
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int aantal = 1;
                List<string> list = new List<string>();            
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int i = 1;
                int j = 1;
                bool leeg = false;
                while (!leeg){

                    if(worksheet.Cells[i,1].Value==null){
                       leeg = true;
                    }else if(worksheet.Cells[i, j].Value==null){
                        i++;
                        j=1;
                    }else{
                        list.Add(worksheet.Cells[i, j].Value.ToString()+ " " + aantal);
                        aantal++;
                        j++;
                    }
                }
                


                return list;
            }
        }
    }
}
