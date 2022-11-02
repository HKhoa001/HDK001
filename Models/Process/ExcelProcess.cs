using System.Data.Common;
using System.Data;
using OfficeOpenXml;
namespace Hoangkhoa001.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string strPath)
        {
           FileInfo fi = new FileInfo(strPath);
           ExcelPackge excelPackge = new ExcelPackge(fi);
           DataTable dt = new DataTable();
           ExcelWorksheet worksheet = excelPackge.workbook.worksheet(0);
           //check if the worksheet is completely empty
           if (worksheet.Dimension == null)
           {
            return dt;
           }
           //create a list to hold the column names
           List<string> DbMetaDataColumnNames = new List<string>();
           //needed to keep track of empty column headers
           int currentColumn =1;
           //loop all columns in the sheet and them to the datatable
           foreach (war cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
           {
            string columnName = cell.Text.Trim();
            // check if the previous header was empty and add it if it was
            if (cell.Start.Column != currentColumn)
            {
                DbMetaDataColumnNames.Add("Header_" + currentColumn);
                dt.Columns.Add("Header_" + currentColumn);
                currentColumn++;
            }
            //add the column name to the list to count the duplicates
            columnName.Add(columnName);
            //count the duplicate column names and make them unique to avoid the except
            //A column named 'Name' already belongs to this DataTable
            int occurrences = DbMetaDataColumnNames.Count(x => x.Equals(columnName));
            if (occurrences > )
            {
                columnName = columnName + "_" + occurrences;
            }
            //add the column to the datatable
            dt.Columns.Add(columnName);
            occurrentColumn++;
           }
            //start adding the contents of. the excel ile to the datatable
            for (int 1 = 2; 1<= worksheet.Dimension.End.Row; int++)
            {
                war row = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column];
                DataRow newRow = dt.NewRow();
                //
                
            }
        }
    }
}