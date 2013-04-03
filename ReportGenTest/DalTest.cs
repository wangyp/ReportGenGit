using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using ReportGen.Dal;
using ReportGen.Model;

namespace ReportGenTest 
{
    [TestFixture]
    public class DalTest :  TestBase
    {
        public IDataFieldRepository DataFieldRepository { get; set; }


        [TestFixtureSetUp]
        public void init()
        {
            DataFieldRepository = new DataFieldRepository();
        }

        [Test]
        public void Test(){
        	
        }
        
        
        [TestCase("Test002")]
        public void TestSave(string name)
        {
            ReportData data = GetSampleData(name);
            DataFieldRepository.Save(data);

            IList<ReportData> datas = DataFieldRepository.GetAll();
            Assert.IsTrue(datas.Count > 0);
            foreach (var dbData in datas)
            {
                Debug.WriteLine(dbData.Name);
            }

            var model = DataFieldRepository.GetByName(name);
            Assert.IsNotNull(model);
        }

        [TestCase("Test002")]
        public void TestUpdate(string name)
        {
            var model = DataFieldRepository.GetByName(name);
            model.BondIssueDate = model.BondIssueDate.AddYears(4);
            DataFieldRepository.Update(model);
        }


        [Test]
        public void TestDelete()
        {
            DataFieldRepository.Delete("Data");
            IList<ReportData> datas = DataFieldRepository.GetAll();
            Assert.IsTrue(datas.Count > 0);
            foreach (var dbData in datas)
            {
                Debug.WriteLine(dbData.Name);
            }
        }
        /*
         CREATE TABLE [main] (
        [Id] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,
        [Name] VARCHAR(100)  NOT NULL,
        [Issuer] VARCHAR(200)  NULL,
        [IssueYear] VARCHAR(50)  NULL,
        [BondStage] INTEGER  NULL,
        [BondType] vARCHAR(200)  NULL,
        [BondAmount] FLOAT  NULL,
        [BondMaxRate] FLOAT  NULL,
        [BondMinRate] FLOAT  NULL,
        [BuyFloorAmount] INTEGER  NULL,
        [BuyStepAmount] INTEGER  NULL,
        [BondDeclareDate] DATE  NULL,
        [BondIssueDate] DATE  NULL
        )
         
         */
        [Test]
        public void CreateDb()
        {
            var map = new Dictionary<string, string>();
            map.Add("String", "VARCHAR(200)");
            map.Add("Int64", "INTEGER");
            map.Add("Double", "FLOAT");
            map.Add("DateTime", "DATE");


            Func<string, string> mapedType = o=> map[o];

            var list = typeof (ReportData).GetProperties().Where(o => o.Name != "Id");
            foreach (PropertyInfo c in list)
            {
                Console.WriteLine(string.Format("[{0}] {1}  NULL, ", c.Name, mapedType(c.PropertyType.Name)));
            }
        }


    }
}
