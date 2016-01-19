using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;

namespace IntegrationApp
{
    public class ExcelRepo
    {
        public ExcelRepo()
        {
            var spreadsheetDocument = SpreadsheetDocument.Open("", false);
            spreadsheetDocument.Dispose();
        }
        public object GetDataFromExcel()
        {
            throw new NotImplementedException();
        }
    }
}
