using System;
using System.Collections.Generic;
using IntegrationApp;

namespace Tests
{
    public class IntegrationTests
    {

        //        [WpfFact]
        //        public void Tamtamtamtaaaam()
        //        {
        //            var app = new App();
        //            app.InitializeComponent();
        //            app.Run();
        //
        //
        //            Assert.Equal(1,1);
        //        }

        [Theory]
        [InlineData("")]
        [InlineData("a")]
        public void ExcelRepoCollectsCorrectDataFromExcel(string filePath)
        {
            //setup
            var excelRepo = new ExcelRepo();
            //excerise
            var aa = excelRepo.GetDataFromExcel();
            //assert

            var expected = new List<object>
            {
                new {Id = "Id1", Comment = "FirstEntry", Amount = 100, Date = new DateTime(2016, 1, 18)},
                new {Id = "Id2", Comment = "SecondEntry", Amount = 200, Date = new DateTime(2016, 1, 20)},
                new {Id = "Id3", Comment = "ThirdEntry", Amount = 300.25 , Date = new DateTime(2007, 3, 12)}
            };

            Assert.Equal(expected, aa);
        }

        //        [Fact]
        //        public void BrainTransfersCorrectDataFromExcelToSql() { }

        //        [Fact]
        //        public void BrainWritesCorrectDataToSql() { }

    }

}
