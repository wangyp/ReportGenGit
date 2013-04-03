namespace ReportGenForm.View
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.templateListBox = new System.Windows.Forms.CheckedListBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BondTypeCombo = new System.Windows.Forms.ComboBox();
            this.BuyStepAmountText = new System.Windows.Forms.TextBox();
            this.BuyFloorAmount = new System.Windows.Forms.TextBox();
            this.BondMinRate = new System.Windows.Forms.TextBox();
            this.BondMaxRate = new System.Windows.Forms.TextBox();
            this.BondAmount = new System.Windows.Forms.TextBox();
            this.BondStage = new System.Windows.Forms.TextBox();
            this.IssueYear = new System.Windows.Forms.TextBox();
            this.IssuerTextBox = new System.Windows.Forms.TextBox();
            this.BondDeclareDate = new System.Windows.Forms.DateTimePicker();
            this.BondIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BuyStepAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classificationTab = new System.Windows.Forms.TabPage();
            this.dataList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshDataBtn = new System.Windows.Forms.Button();
            this.deleteDataBtn = new System.Windows.Forms.Button();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openToolStripMenuItem.Text = "Open ...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem1});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // generateToolStripMenuItem1
            // 
            this.generateToolStripMenuItem1.Name = "generateToolStripMenuItem1";
            this.generateToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.generateToolStripMenuItem1.Text = "Generate";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.GenerateBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(908, 554);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.templateListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 531);
            this.panel1.TabIndex = 3;
            // 
            // templateListBox
            // 
            this.templateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateListBox.FormattingEnabled = true;
            this.templateListBox.Location = new System.Drawing.Point(0, 0);
            this.templateListBox.Name = "templateListBox";
            this.templateListBox.Size = new System.Drawing.Size(113, 531);
            this.templateListBox.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateBtn.Location = new System.Drawing.Point(0, 531);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(113, 23);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "开始生成";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1MinSize = 50;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataList);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(791, 554);
            this.splitContainer2.SplitterDistance = 608;
            this.splitContainer2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.basicTab);
            this.tabControl1.Controls.Add(this.classificationTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.panel3);
            this.basicTab.Controls.Add(this.groupBox1);
            this.basicTab.Location = new System.Drawing.Point(4, 21);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(600, 529);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = "基本数据";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newBtn);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Controls.Add(this.saveAsBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 29);
            this.panel3.TabIndex = 1;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(303, 3);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(91, 23);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "新建";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(400, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Location = new System.Drawing.Point(497, 3);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(91, 23);
            this.saveAsBtn.TabIndex = 0;
            this.saveAsBtn.Text = "另存为...";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BondTypeCombo);
            this.groupBox1.Controls.Add(this.BuyStepAmountText);
            this.groupBox1.Controls.Add(this.BuyFloorAmount);
            this.groupBox1.Controls.Add(this.BondMinRate);
            this.groupBox1.Controls.Add(this.BondMaxRate);
            this.groupBox1.Controls.Add(this.BondAmount);
            this.groupBox1.Controls.Add(this.BondStage);
            this.groupBox1.Controls.Add(this.IssueYear);
            this.groupBox1.Controls.Add(this.IssuerTextBox);
            this.groupBox1.Controls.Add(this.BondDeclareDate);
            this.groupBox1.Controls.Add(this.BondIssueDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BuyStepAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field";
            // 
            // BondTypeCombo
            // 
            this.BondTypeCombo.FormattingEnabled = true;
            this.BondTypeCombo.Items.AddRange(new object[] {
            "类型1",
            "类型2"});
            this.BondTypeCombo.Location = new System.Drawing.Point(134, 127);
            this.BondTypeCombo.Name = "BondTypeCombo";
            this.BondTypeCombo.Size = new System.Drawing.Size(161, 20);
            this.BondTypeCombo.TabIndex = 7;
            // 
            // BuyStepAmountText
            // 
            this.BuyStepAmountText.Location = new System.Drawing.Point(134, 273);
            this.BuyStepAmountText.Name = "BuyStepAmountText";
            this.BuyStepAmountText.Size = new System.Drawing.Size(161, 21);
            this.BuyStepAmountText.TabIndex = 6;
            // 
            // BuyFloorAmount
            // 
            this.BuyFloorAmount.Location = new System.Drawing.Point(134, 243);
            this.BuyFloorAmount.Name = "BuyFloorAmount";
            this.BuyFloorAmount.Size = new System.Drawing.Size(161, 21);
            this.BuyFloorAmount.TabIndex = 6;
            // 
            // BondMinRate
            // 
            this.BondMinRate.Location = new System.Drawing.Point(134, 216);
            this.BondMinRate.Name = "BondMinRate";
            this.BondMinRate.Size = new System.Drawing.Size(161, 21);
            this.BondMinRate.TabIndex = 6;
            // 
            // BondMaxRate
            // 
            this.BondMaxRate.Location = new System.Drawing.Point(134, 189);
            this.BondMaxRate.Name = "BondMaxRate";
            this.BondMaxRate.Size = new System.Drawing.Size(161, 21);
            this.BondMaxRate.TabIndex = 6;
            // 
            // BondAmount
            // 
            this.BondAmount.Location = new System.Drawing.Point(134, 155);
            this.BondAmount.Name = "BondAmount";
            this.BondAmount.Size = new System.Drawing.Size(161, 21);
            this.BondAmount.TabIndex = 6;
            // 
            // BondStage
            // 
            this.BondStage.Location = new System.Drawing.Point(134, 104);
            this.BondStage.Name = "BondStage";
            this.BondStage.Size = new System.Drawing.Size(161, 21);
            this.BondStage.TabIndex = 6;
            // 
            // IssueYear
            // 
            this.IssueYear.Location = new System.Drawing.Point(134, 77);
            this.IssueYear.Name = "IssueYear";
            this.IssueYear.Size = new System.Drawing.Size(161, 21);
            this.IssueYear.TabIndex = 6;
            // 
            // IssuerTextBox
            // 
            this.IssuerTextBox.Location = new System.Drawing.Point(134, 49);
            this.IssuerTextBox.Name = "IssuerTextBox";
            this.IssuerTextBox.Size = new System.Drawing.Size(161, 21);
            this.IssuerTextBox.TabIndex = 6;
            // 
            // BondDeclareDate
            // 
            this.BondDeclareDate.Location = new System.Drawing.Point(134, 304);
            this.BondDeclareDate.Name = "BondDeclareDate";
            this.BondDeclareDate.Size = new System.Drawing.Size(161, 21);
            this.BondDeclareDate.TabIndex = 5;
            // 
            // BondIssueDate
            // 
            this.BondIssueDate.Location = new System.Drawing.Point(134, 344);
            this.BondIssueDate.Name = "BondIssueDate";
            this.BondIssueDate.Size = new System.Drawing.Size(161, 21);
            this.BondIssueDate.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "BondIssueDate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "BondDeclareDate";
            // 
            // BuyStepAmount
            // 
            this.BuyStepAmount.AutoSize = true;
            this.BuyStepAmount.Location = new System.Drawing.Point(18, 276);
            this.BuyStepAmount.Name = "BuyStepAmount";
            this.BuyStepAmount.Size = new System.Drawing.Size(83, 12);
            this.BuyStepAmount.TabIndex = 4;
            this.BuyStepAmount.Text = "BuyStepAmount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "BuyFloorAmount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "BondMinRate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "BondMaxRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "BondAmount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "BondType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "BondStage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IssuerYear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issuer";
            // 
            // classificationTab
            // 
            this.classificationTab.Location = new System.Drawing.Point(4, 21);
            this.classificationTab.Name = "classificationTab";
            this.classificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.classificationTab.Size = new System.Drawing.Size(600, 529);
            this.classificationTab.TabIndex = 1;
            this.classificationTab.Text = "码表数据";
            this.classificationTab.UseVisualStyleBackColor = true;
            // 
            // dataList
            // 
            this.dataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataList.FormattingEnabled = true;
            this.dataList.ItemHeight = 12;
            this.dataList.Location = new System.Drawing.Point(0, 0);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(179, 518);
            this.dataList.TabIndex = 2;
            this.dataList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataList_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshDataBtn);
            this.panel2.Controls.Add(this.deleteDataBtn);
            this.panel2.Controls.Add(this.loadDataBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 36);
            this.panel2.TabIndex = 1;
            // 
            // refreshDataBtn
            // 
            this.refreshDataBtn.Location = new System.Drawing.Point(113, 6);
            this.refreshDataBtn.Name = "refreshDataBtn";
            this.refreshDataBtn.Size = new System.Drawing.Size(63, 23);
            this.refreshDataBtn.TabIndex = 1;
            this.refreshDataBtn.Text = "刷新";
            this.refreshDataBtn.UseVisualStyleBackColor = true;
            this.refreshDataBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteDataBtn
            // 
            this.deleteDataBtn.Location = new System.Drawing.Point(56, 6);
            this.deleteDataBtn.Name = "deleteDataBtn";
            this.deleteDataBtn.Size = new System.Drawing.Size(51, 23);
            this.deleteDataBtn.TabIndex = 1;
            this.deleteDataBtn.Text = "删除";
            this.deleteDataBtn.UseVisualStyleBackColor = true;
            this.deleteDataBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(3, 6);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(51, 23);
            this.loadDataBtn.TabIndex = 1;
            this.loadDataBtn.Text = "读取";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.CheckedListBox templateListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage basicTab;
        private System.Windows.Forms.TabPage classificationTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BuyStepAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker BondDeclareDate;
        private System.Windows.Forms.DateTimePicker BondIssueDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IssuerTextBox;
        private System.Windows.Forms.TextBox IssueYear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.Button saveAsBtn;
        private System.Windows.Forms.Button refreshDataBtn;
        private System.Windows.Forms.Button deleteDataBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox BondTypeCombo;
        private System.Windows.Forms.TextBox BuyStepAmountText;
        private System.Windows.Forms.TextBox BuyFloorAmount;
        private System.Windows.Forms.TextBox BondMinRate;
        private System.Windows.Forms.TextBox BondMaxRate;
        private System.Windows.Forms.TextBox BondAmount;
        private System.Windows.Forms.TextBox BondStage;
        private System.Windows.Forms.Button newBtn;
    }
}

