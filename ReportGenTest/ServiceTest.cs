using NUnit.Framework;
using ReportGen.Model;
using ReportGen.Service;
using ReportGen.Service.Generator;
using WordDocumentGenerator.Library;

namespace ReportGenTest
{
    [TestFixture]
    public class ServiceTest : TestBase
    {
        private WordGenerateService service;

        [TestFixtureSetUp]
        public void SetUp()
        {
            service = WordGenerateService.GetInstance();
        }

        [Test]
        public void DocGenerateTest()
        {
            ReportData data = GetSampleData();
            service.Generate(WordReportGenerator.SubscribeSummary, data, "test.docx");
        }
    }
}
