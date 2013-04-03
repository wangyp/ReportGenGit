using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReportGen.Model;

namespace ReportGenTest
{
    public class TestBase
    {
        protected ReportData GetSampleData(string name = null)
        {
            ReportData data = new ReportData
                                  {
                                      Name = name??"Sample1",
                                      Description = "For test",
                                      Issuer = "王云鹏",
                                      IssueYear = "2013",
                                      BondAmount = "1000",
                                      BondDeclareDate = DateTime.Now,
                                      BondIssueDate = DateTime.Now.AddDays(3),
                                      BondMaxRate = "1.5",
                                      BondMinRate = "2.5",
                                      BondStage = "3",
                                      BondType = "国债",
                                      BuyFloorAmount = "1100",
                                      BuyStepAmount = "200"
                                  };
            return data;
        }
    }
}
