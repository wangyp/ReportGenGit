using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using ReportGen.Model;
using ReportGen.Service;

namespace ReportGenForm.View
{
    public partial class Main : Form
    {
        private ReportDataService _reportDataService;
        private WordGenerateService _generateService;
        private SaveAsDataDialog _saveAsDialog;
        private Dictionary<string, Control> _controlsMap = new Dictionary<string, Control>();

        public Main()
        {
            InitializeComponent();
            _reportDataService = new ReportDataService();
            _generateService = WordGenerateService.GetInstance();
            _saveAsDialog = new SaveAsDataDialog();
            initControlMap();
        }


        /// <summary>
        /// Add controller map into this method
        /// </summary>
        private void initControlMap()
        {
            _controlsMap.Add("BondType", BondTypeCombo);
            _controlsMap.Add("BuyStepAmount", BuyStepAmountText);
            _controlsMap.Add("BuyFloorAmount", BuyFloorAmount);
            _controlsMap.Add("BondMinRate", BondMinRate);
            _controlsMap.Add("BondMaxRate", BondMaxRate);
            _controlsMap.Add("BondAmount", BondAmount);
            _controlsMap.Add("BondStage", BondStage);
            _controlsMap.Add("IssueYear", IssueYear);
            _controlsMap.Add("Issuer", IssuerTextBox);
            _controlsMap.Add("BondDeclareDate", BondDeclareDate);
            _controlsMap.Add("BondIssueDate", BondIssueDate);
        }

        public void BindData(ReportData reportData)
        {
            foreach (PropertyInfo propertyInfo in reportData.GetType().GetProperties())
            {
                if (_controlsMap.ContainsKey(propertyInfo.Name))
                {
                    Control control = _controlsMap[propertyInfo.Name];
                    control.DataBindings.Clear();;
                    control.DataBindings.Add(GetControlType(control), reportData, propertyInfo.Name);
                }
            }
        }

        private string GetControlType(Control control)
        {
            if (control is TextBox)
            {
                return "Text";
            }
            if (control is ComboBox)
            {
                return "Text";
            }
            if (control is DateTimePicker)
            {
                return "Value";
            }
            return "Text";
        }

        public void LoadData(string name)
        {
            _reportDataService.Open(name);
            BindData(_reportDataService.CurrentEdit);
        }

        public void RefreshTemplate()
        {
            templateListBox.Items.Clear();
            var files = _generateService.GetAllTempate().ToList();
            files.ForEach(o => templateListBox.Items.Add(o));
        }

        public void RefreshDataList()
        {
            dataList.Items.Clear();
            var allData = _reportDataService.GetAllNames();
            foreach (var data in allData)
            {
                dataList.Items.Add(data);
            }
        }

        
#region Event
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void newBtn_Click(object sender, EventArgs e)
        {
            _saveAsDialog.ShowDialog(this);
            if (_saveAsDialog.DialogResult == DialogResult.OK)
            {
                if (_reportDataService.IsExist(_saveAsDialog.DataName))
                {
                    MessageBox.Show(this, @"数据重名： " + _saveAsDialog.DataName);
                }
                var reportData = _reportDataService.New(_saveAsDialog.DataName, _saveAsDialog.Description);
                BindData(reportData);
                RefreshDataList();
            }
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _reportDataService.Save();
            MessageBox.Show(this, @"数据已保存！");
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            _saveAsDialog.ShowDialog(this);
            if (_saveAsDialog.DialogResult == DialogResult.OK)
            {
                if (_reportDataService.IsExist(_saveAsDialog.DataName))
                {
                    MessageBox.Show(this, @"数据重名： " + _saveAsDialog.DataName);
                }
                _reportDataService.CurrentEdit.Name = _saveAsDialog.DataName;
                _reportDataService.CurrentEdit.Description = _saveAsDialog.Description;
                _reportDataService.SaveAs(_reportDataService.CurrentEdit);
                RefreshDataList();
            }
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            //for test
            var name = dataList.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                LoadData(name);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataList();
            MessageBox.Show(this, @"数据已刷新！");
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认删除数据？", "Warning", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                var name = dataList.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    _reportDataService.Delete(name);
                    RefreshDataList();
                }
            }
        }

        private void dataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var name = dataList.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                LoadData(name);
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            RefreshDataList();
            RefreshTemplate();
        }

#endregion

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            if (_reportDataService.CurrentEdit == null)
            {
                MessageBox.Show("读取数据先！");
            }
            foreach (var item in templateListBox.SelectedItems)
            {
                var name = item.ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    _generateService.Generate(name, _reportDataService.CurrentEdit , name + ".docx");
                }
            }
            MessageBox.Show("导出完成!");
        }
    }
}
