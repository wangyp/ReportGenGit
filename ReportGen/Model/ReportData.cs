using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGen.Model
{
    public class ReportData
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Issuer { get; set; }
        public string IssueYear { get; set; }
        public string BondStage { get; set; }
        public string BondType { get; set; }
        public string BondAmount { get; set; }
        public string BondMaxRate { get; set; }
        public string BondMinRate { get; set; }

        public string BuyFloorAmount { get; set; }
        public string BuyStepAmount { get; set; }
        public DateTime BondDeclareDate { get; set; }
        public DateTime BondIssueDate { get; set; }
    }
}
