using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReportGen.Dal;
using ReportGen.Model;

namespace ReportGen.Service
{
    public class ReportDataService
    {

        private IDataFieldRepository _dataFieldRepository;

        private ReportData _current = null;

        public ReportDataService()
        {
            _dataFieldRepository = new DataFieldRepository();
        }

        public ReportData CurrentEdit
        {
            get { return _current; }
        }

        public void Save()
        {
            if (_current != null)
            {
                _dataFieldRepository.Update(_current);
            }
        }
        
        public void SaveAs(ReportData reportData)
        {
            if (IsExist(reportData.Name))
            {
                throw new DalException("Data Name exist: " + reportData.Name);
            }
            _dataFieldRepository.Save(reportData);
            _current = reportData;
        }

        public ReportData New(string name, string description)
        {
            _current = new ReportData
                       {
                           Id = 0,
                           Name = name,
                           Description = description,
                           BondDeclareDate = DateTime.Now,
                           BondIssueDate = DateTime.Now
                       };
            _dataFieldRepository.Save(_current);
            return _current;
        }

        public ReportData Open(string name)
        {
            _current = _dataFieldRepository.GetByName(name);
            return _current;
        }

        public void Delete(string name)
        {
            _dataFieldRepository.Delete(name);
        }

        public List<string> GetAllNames()
        {
            return _dataFieldRepository.GetAll().Select(o => o.Name).ToList();
        }

        public IList<ReportData> GetAll()
        {
            return _dataFieldRepository.GetAll();
        }

        public ReportData GetByName(string name)
        {
            return _dataFieldRepository.GetByName(name);
        }

        public bool IsExist(string name)
        {
            var report = _dataFieldRepository.GetByName(name);
            return report != null;
        }
    }
}
