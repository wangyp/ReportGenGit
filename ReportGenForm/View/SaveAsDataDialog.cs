using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportGenForm.View
{
    public partial class SaveAsDataDialog : Form
    {

        public string DataName { get; set; }

        public string Description { get; set; }

        public SaveAsDataDialog()
        {
            InitializeComponent();
            okBtn.DialogResult = DialogResult.OK;
            cancelBtn.DialogResult = DialogResult.Cancel;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DataName = dataNameTextBox.Text;
            Description = descTextBox.Text;
        }

    }
}
