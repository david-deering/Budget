using System.Windows.Forms;

namespace mainWindow.window
{
    partial class Budget
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonCalcBudget = new System.Windows.Forms.Button();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.listViewBudget = new System.Windows.Forms.ListView();
            this.columnHeaderBAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMain = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMonthlyPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConfirmationNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPrevMonth = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewIncome = new System.Windows.Forms.ListView();
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.listViewConfigIncome = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteIncome = new System.Windows.Forms.Button();
            this.buttonEditIncome = new System.Windows.Forms.Button();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.buttonSetActive = new System.Windows.Forms.Button();
            this.labelIncomes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.columnHeaderCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1Account = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAccountDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1Deactivate = new System.Windows.Forms.ToolStripMenuItem();
            this.activateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripIncome = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.contextMenuStrip1Account.SuspendLayout();
            this.contextMenuStripIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tabMain);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 627);
            this.panel1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageMain);
            this.tabMain.Controls.Add(this.tabPageConfig);
            this.tabMain.Location = new System.Drawing.Point(8, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1320, 621);
            this.tabMain.TabIndex = 11;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.Plum;
            this.tabPageMain.Controls.Add(this.buttonCalcBudget);
            this.tabPageMain.Controls.Add(this.labelTotalIncome);
            this.tabPageMain.Controls.Add(this.listViewBudget);
            this.tabPageMain.Controls.Add(this.label3);
            this.tabPageMain.Controls.Add(this.label1);
            this.tabPageMain.Controls.Add(this.lvMain);
            this.tabPageMain.Controls.Add(this.tableLayoutPanel2);
            this.tabPageMain.Controls.Add(this.label5);
            this.tabPageMain.Controls.Add(this.listViewIncome);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1312, 595);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Budget";
            // 
            // buttonCalcBudget
            // 
            this.buttonCalcBudget.Location = new System.Drawing.Point(1087, 566);
            this.buttonCalcBudget.Name = "buttonCalcBudget";
            this.buttonCalcBudget.Size = new System.Drawing.Size(107, 23);
            this.buttonCalcBudget.TabIndex = 7;
            this.buttonCalcBudget.Text = "Calculate Budget";
            this.buttonCalcBudget.UseVisualStyleBackColor = true;
            this.buttonCalcBudget.Click += new System.EventHandler(this.buttonCalcBudget_Click);
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.BackColor = System.Drawing.Color.LightYellow;
            this.labelTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.Location = new System.Drawing.Point(1158, 217);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(69, 22);
            this.labelTotalIncome.TabIndex = 3;
            this.labelTotalIncome.Text = "4139.17";
            // 
            // listViewBudget
            // 
            this.listViewBudget.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBAmount,
            this.columnHeaderBDate});
            this.listViewBudget.Location = new System.Drawing.Point(956, 307);
            this.listViewBudget.Name = "listViewBudget";
            this.listViewBudget.Size = new System.Drawing.Size(352, 254);
            this.listViewBudget.TabIndex = 0;
            this.listViewBudget.UseCompatibleStateImageBehavior = false;
            this.listViewBudget.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBAmount
            // 
            this.columnHeaderBAmount.Text = "Amount";
            this.columnHeaderBAmount.Width = 175;
            // 
            // columnHeaderBDate
            // 
            this.columnHeaderBDate.Text = "Date";
            this.columnHeaderBDate.Width = 175;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1049, 278);
            this.label3.MinimumSize = new System.Drawing.Size(105, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weekly Budget";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1049, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Income";
            // 
            // lvMain
            // 
            this.lvMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lvMain.BackColor = System.Drawing.Color.White;
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnBalance,
            this.columnHeaderMonthlyPayment,
            this.columnHeaderDateDue,
            this.columnHeaderPaid,
            this.columnConfirmationNumber});
            this.lvMain.FullRowSelect = true;
            this.lvMain.Location = new System.Drawing.Point(1, 45);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(943, 516);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Company";
            this.columnHeaderName.Width = 220;
            // 
            // columnBalance
            // 
            this.columnBalance.Text = "Account Balance";
            this.columnBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBalance.Width = 125;
            // 
            // columnHeaderMonthlyPayment
            // 
            this.columnHeaderMonthlyPayment.Text = "Monthly Payment";
            this.columnHeaderMonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMonthlyPayment.Width = 125;
            // 
            // columnHeaderDateDue
            // 
            this.columnHeaderDateDue.Text = "Date Due";
            this.columnHeaderDateDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDateDue.Width = 125;
            // 
            // columnHeaderPaid
            // 
            this.columnHeaderPaid.Text = "Status";
            this.columnHeaderPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPaid.Width = 125;
            // 
            // columnConfirmationNumber
            // 
            this.columnConfirmationNumber.Text = "Confirmation Number";
            this.columnConfirmationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnConfirmationNumber.Width = 255;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonPrevMonth, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonNextMonth, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelMonth, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(316, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 36);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // buttonPrevMonth
            // 
            this.buttonPrevMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPrevMonth.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevMonth.Location = new System.Drawing.Point(37, 6);
            this.buttonPrevMonth.Name = "buttonPrevMonth";
            this.buttonPrevMonth.Size = new System.Drawing.Size(23, 23);
            this.buttonPrevMonth.TabIndex = 6;
            this.buttonPrevMonth.Text = "<";
            this.buttonPrevMonth.UseVisualStyleBackColor = false;
            this.buttonPrevMonth.Click += new System.EventHandler(this.buttonPrevMonth_Click);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNextMonth.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonNextMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextMonth.ForeColor = System.Drawing.Color.Black;
            this.buttonNextMonth.Location = new System.Drawing.Point(255, 6);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(23, 23);
            this.buttonNextMonth.TabIndex = 7;
            this.buttonNextMonth.Text = ">";
            this.buttonNextMonth.UseVisualStyleBackColor = false;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.LemonChiffon;
            this.labelMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(66, 0);
            this.labelMonth.MinimumSize = new System.Drawing.Size(105, 26);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(183, 36);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "December";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1049, 16);
            this.label5.MinimumSize = new System.Drawing.Size(105, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monthly Income";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewIncome
            // 
            this.listViewIncome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAmount,
            this.columnHeaderDate});
            this.listViewIncome.FullRowSelect = true;
            this.listViewIncome.Location = new System.Drawing.Point(956, 45);
            this.listViewIncome.Name = "listViewIncome";
            this.listViewIncome.Size = new System.Drawing.Size(352, 169);
            this.listViewIncome.TabIndex = 0;
            this.listViewIncome.UseCompatibleStateImageBehavior = false;
            this.listViewIncome.View = System.Windows.Forms.View.Details;
            this.listViewIncome.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewIncome_MouseDoubleClick);
            this.listViewIncome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewIncome_MouseDown);
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Amount";
            this.columnHeaderAmount.Width = 175;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 175;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.BackColor = System.Drawing.Color.Plum;
            this.tabPageConfig.Controls.Add(this.listViewConfigIncome);
            this.tabPageConfig.Controls.Add(this.buttonDeleteIncome);
            this.tabPageConfig.Controls.Add(this.buttonEditIncome);
            this.tabPageConfig.Controls.Add(this.buttonAddIncome);
            this.tabPageConfig.Controls.Add(this.buttonSetActive);
            this.tabPageConfig.Controls.Add(this.labelIncomes);
            this.tabPageConfig.Controls.Add(this.label2);
            this.tabPageConfig.Controls.Add(this.buttonDeleteAccount);
            this.tabPageConfig.Controls.Add(this.buttonEditAccount);
            this.tabPageConfig.Controls.Add(this.buttonAddAccount);
            this.tabPageConfig.Controls.Add(this.listViewAccounts);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(1312, 595);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Configuration";
            // 
            // listViewConfigIncome
            // 
            this.listViewConfigIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewConfigIncome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewConfigIncome.FullRowSelect = true;
            this.listViewConfigIncome.Location = new System.Drawing.Point(752, 56);
            this.listViewConfigIncome.Name = "listViewConfigIncome";
            this.listViewConfigIncome.Size = new System.Drawing.Size(352, 527);
            this.listViewConfigIncome.TabIndex = 22;
            this.listViewConfigIncome.UseCompatibleStateImageBehavior = false;
            this.listViewConfigIncome.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 175;
            // 
            // buttonDeleteIncome
            // 
            this.buttonDeleteIncome.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDeleteIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteIncome.Location = new System.Drawing.Point(637, 140);
            this.buttonDeleteIncome.Name = "buttonDeleteIncome";
            this.buttonDeleteIncome.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteIncome.TabIndex = 21;
            this.buttonDeleteIncome.Text = "Delete";
            this.buttonDeleteIncome.UseVisualStyleBackColor = false;
            this.buttonDeleteIncome.Click += new System.EventHandler(this.buttonDeleteIncome_Click);
            // 
            // buttonEditIncome
            // 
            this.buttonEditIncome.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEditIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditIncome.Location = new System.Drawing.Point(637, 98);
            this.buttonEditIncome.Name = "buttonEditIncome";
            this.buttonEditIncome.Size = new System.Drawing.Size(109, 23);
            this.buttonEditIncome.TabIndex = 20;
            this.buttonEditIncome.Text = "Edit";
            this.buttonEditIncome.UseVisualStyleBackColor = false;
            this.buttonEditIncome.Click += new System.EventHandler(this.buttonEditIncome_Click);
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIncome.Location = new System.Drawing.Point(637, 56);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(109, 23);
            this.buttonAddIncome.TabIndex = 19;
            this.buttonAddIncome.Text = "Add";
            this.buttonAddIncome.UseVisualStyleBackColor = false;
            this.buttonAddIncome.Click += new System.EventHandler(this.buttonAddIncome_Click_1);
            // 
            // buttonSetActive
            // 
            this.buttonSetActive.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonSetActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetActive.Location = new System.Drawing.Point(6, 182);
            this.buttonSetActive.Name = "buttonSetActive";
            this.buttonSetActive.Size = new System.Drawing.Size(109, 23);
            this.buttonSetActive.TabIndex = 14;
            this.buttonSetActive.Text = "Set Status";
            this.buttonSetActive.UseVisualStyleBackColor = false;
            this.buttonSetActive.Click += new System.EventHandler(this.buttonSetActive_Click);
            // 
            // labelIncomes
            // 
            this.labelIncomes.AutoSize = true;
            this.labelIncomes.BackColor = System.Drawing.Color.LemonChiffon;
            this.labelIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomes.Location = new System.Drawing.Point(886, 28);
            this.labelIncomes.Name = "labelIncomes";
            this.labelIncomes.Size = new System.Drawing.Size(82, 24);
            this.labelIncomes.TabIndex = 13;
            this.labelIncomes.Text = "Incomes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Accounts";
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(6, 140);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteAccount.TabIndex = 8;
            this.buttonDeleteAccount.Text = "Delete";
            this.buttonDeleteAccount.UseVisualStyleBackColor = false;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditAccount.Location = new System.Drawing.Point(6, 98);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(109, 23);
            this.buttonEditAccount.TabIndex = 7;
            this.buttonEditAccount.Text = "Edit";
            this.buttonEditAccount.UseVisualStyleBackColor = false;
            this.buttonEditAccount.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAccount.Location = new System.Drawing.Point(6, 56);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(109, 23);
            this.buttonAddAccount.TabIndex = 6;
            this.buttonAddAccount.Text = "Add";
            this.buttonAddAccount.UseVisualStyleBackColor = false;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCompany,
            this.columnHeaderBalance,
            this.columnHeaderActive});
            this.listViewAccounts.FullRowSelect = true;
            this.listViewAccounts.Location = new System.Drawing.Point(121, 56);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(380, 527);
            this.listViewAccounts.TabIndex = 4;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            this.listViewAccounts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewAccount_ColumnClick);
            this.listViewAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAccounts_MouseDoubleClick);
            this.listViewAccounts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewAccounts_MouseDown);
            // 
            // columnHeaderCompany
            // 
            this.columnHeaderCompany.Text = "Company";
            this.columnHeaderCompany.Width = 175;
            // 
            // columnHeaderBalance
            // 
            this.columnHeaderBalance.Text = "Balance";
            this.columnHeaderBalance.Width = 100;
            // 
            // columnHeaderActive
            // 
            this.columnHeaderActive.Text = "Active";
            this.columnHeaderActive.Width = 100;
            // 
            // contextMenuStrip1Account
            // 
            this.contextMenuStrip1Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddAccount,
            this.toolStripMenuItemAccountDelete,
            this.toolStripMenuItem1Deactivate,
            this.activateAccountToolStripMenuItem});
            this.contextMenuStrip1Account.Name = "contextMenuStrip1";
            this.contextMenuStrip1Account.Size = new System.Drawing.Size(178, 92);
            // 
            // toolStripMenuItemAddAccount
            // 
            this.toolStripMenuItemAddAccount.Name = "toolStripMenuItemAddAccount";
            this.toolStripMenuItemAddAccount.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAddAccount.Text = "Add an account";
            this.toolStripMenuItemAddAccount.Click += new System.EventHandler(this.addAnAccountToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAccountDelete
            // 
            this.toolStripMenuItemAccountDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmDeleteToolStripMenuItem});
            this.toolStripMenuItemAccountDelete.Name = "toolStripMenuItemAccountDelete";
            this.toolStripMenuItemAccountDelete.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAccountDelete.Text = "Delete Account";
            // 
            // confirmDeleteToolStripMenuItem
            // 
            this.confirmDeleteToolStripMenuItem.Name = "confirmDeleteToolStripMenuItem";
            this.confirmDeleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.confirmDeleteToolStripMenuItem.Text = "Confirm Delete";
            this.confirmDeleteToolStripMenuItem.Click += new System.EventHandler(this.confirmDeleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1Deactivate
            // 
            this.toolStripMenuItem1Deactivate.Name = "toolStripMenuItem1Deactivate";
            this.toolStripMenuItem1Deactivate.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem1Deactivate.Text = "Deactivate Account";
            this.toolStripMenuItem1Deactivate.Click += new System.EventHandler(this.toolStripMenuItem1Deactivate_Click);
            // 
            // activateAccountToolStripMenuItem
            // 
            this.activateAccountToolStripMenuItem.Name = "activateAccountToolStripMenuItem";
            this.activateAccountToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.activateAccountToolStripMenuItem.Text = "Activate Account";
            this.activateAccountToolStripMenuItem.Click += new System.EventHandler(this.activateAccountToolStripMenuItem_Click);
            // 
            // contextMenuStripIncome
            // 
            this.contextMenuStripIncome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIncomeToolStripMenuItem,
            this.deleteIncomeToolStripMenuItem});
            this.contextMenuStripIncome.Name = "contextMenuStripIncome";
            this.contextMenuStripIncome.Size = new System.Drawing.Size(151, 48);
            // 
            // addIncomeToolStripMenuItem
            // 
            this.addIncomeToolStripMenuItem.Name = "addIncomeToolStripMenuItem";
            this.addIncomeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addIncomeToolStripMenuItem.Text = "Add Income";
            this.addIncomeToolStripMenuItem.Click += new System.EventHandler(this.addIncomeToolStripMenuItem_Click);
            // 
            // deleteIncomeToolStripMenuItem
            // 
            this.deleteIncomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmDeleteToolStripMenuItem1});
            this.deleteIncomeToolStripMenuItem.Name = "deleteIncomeToolStripMenuItem";
            this.deleteIncomeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteIncomeToolStripMenuItem.Text = "Delete Income";
            // 
            // confirmDeleteToolStripMenuItem1
            // 
            this.confirmDeleteToolStripMenuItem1.Name = "confirmDeleteToolStripMenuItem1";
            this.confirmDeleteToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.confirmDeleteToolStripMenuItem1.Text = "Confirm Delete";
            this.confirmDeleteToolStripMenuItem1.Click += new System.EventHandler(this.confirmDeleteToolStripMenuItem1_Click);
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 642);
            this.Controls.Add(this.panel1);
            this.Name = "Budget";
            this.Text = "Budget";
            this.panel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.contextMenuStrip1Account.ResumeLayout(false);
            this.contextMenuStripIncome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Label labelTotalIncome;
        private Label label1;
        private ListView listViewIncome;
        private Label labelMonth;
        private Button buttonNextMonth;
        private Button buttonPrevMonth;
        private Label label3;
        private ListView listViewBudget;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderBDate;
        private ColumnHeader columnHeaderBAmount;
        private Button buttonCalcBudget;
        private TabControl tabMain;
        private TabPage tabPageMain;
        private ListView lvMain;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnBalance;
        private ColumnHeader columnHeaderMonthlyPayment;
        private ColumnHeader columnHeaderDateDue;
        private ColumnHeader columnHeaderPaid;
        private ColumnHeader columnConfirmationNumber;
        private TabPage tabPageConfig;
        private ListView listViewAccounts;
        private ColumnHeader columnHeaderCompany;
        private ColumnHeader columnHeaderBalance;
        private ColumnHeader columnHeaderActive;
        private ContextMenuStrip contextMenuStrip1Account;
        private ToolStripMenuItem toolStripMenuItemAddAccount;
        private ToolStripMenuItem toolStripMenuItemAccountDelete;
        private ToolStripMenuItem confirmDeleteToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1Deactivate;
        private ToolStripMenuItem activateAccountToolStripMenuItem;
        private ContextMenuStrip contextMenuStripIncome;
        private ToolStripMenuItem addIncomeToolStripMenuItem;
        private ToolStripMenuItem deleteIncomeToolStripMenuItem;
        private ToolStripMenuItem confirmDeleteToolStripMenuItem1;
        private Button buttonDeleteAccount;
        private Button buttonEditAccount;
        private Button buttonAddAccount;
        private Label labelIncomes;
        private Label label2;
        private Button buttonDeleteIncome;
        private Button buttonEditIncome;
        private Button buttonAddIncome;
        private Button buttonSetActive;
        private ListView listViewConfigIncome;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}

