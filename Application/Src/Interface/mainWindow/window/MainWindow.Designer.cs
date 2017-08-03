using System.Windows.Forms;
namespace MainWindow
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonViewAccounts = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPrevMonth = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCalcBudget = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewBudget = new System.Windows.Forms.ListView();
            this.columnHeaderBAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.IncomePanel = new System.Windows.Forms.Panel();
            this.buttonDeleteIncome = new System.Windows.Forms.Button();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPayDate = new System.Windows.Forms.Button();
            this.listViewIncome = new System.Windows.Forms.ListView();
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMonthlyPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConfirmationNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.IncomePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonViewAccounts);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.btnDeleteAccount);
            this.panel1.Controls.Add(this.btnAddAccount);
            this.panel1.Controls.Add(this.IncomePanel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 618);
            this.panel1.TabIndex = 0;
            // 
            // buttonViewAccounts
            // 
            this.buttonViewAccounts.Location = new System.Drawing.Point(112, 11);
            this.buttonViewAccounts.Name = "buttonViewAccounts";
            this.buttonViewAccounts.Size = new System.Drawing.Size(98, 23);
            this.buttonViewAccounts.TabIndex = 10;
            this.buttonViewAccounts.Text = "View Accounts";
            this.buttonViewAccounts.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(384, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 36);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // buttonPrevMonth
            // 
            this.buttonPrevMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPrevMonth.Location = new System.Drawing.Point(37, 6);
            this.buttonPrevMonth.Name = "buttonPrevMonth";
            this.buttonPrevMonth.Size = new System.Drawing.Size(23, 23);
            this.buttonPrevMonth.TabIndex = 6;
            this.buttonPrevMonth.Text = "<";
            this.buttonPrevMonth.UseVisualStyleBackColor = true;
            this.buttonPrevMonth.Click += new System.EventHandler(this.buttonPrevMonth_Click);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNextMonth.Location = new System.Drawing.Point(255, 6);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(23, 23);
            this.buttonNextMonth.TabIndex = 7;
            this.buttonNextMonth.Text = ">";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonth.AutoSize = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCalcBudget);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listViewBudget);
            this.panel2.Location = new System.Drawing.Point(989, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 345);
            this.panel2.TabIndex = 8;
            // 
            // buttonCalcBudget
            // 
            this.buttonCalcBudget.Location = new System.Drawing.Point(130, 298);
            this.buttonCalcBudget.Name = "buttonCalcBudget";
            this.buttonCalcBudget.Size = new System.Drawing.Size(107, 23);
            this.buttonCalcBudget.TabIndex = 7;
            this.buttonCalcBudget.Text = "Calculate Budget";
            this.buttonCalcBudget.UseVisualStyleBackColor = true;
            this.buttonCalcBudget.Click += new System.EventHandler(this.buttonCalcBudget_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.MinimumSize = new System.Drawing.Size(105, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weekly Budget";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewBudget
            // 
            this.listViewBudget.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBAmount,
            this.columnHeaderBDate});
            this.listViewBudget.Location = new System.Drawing.Point(3, 38);
            this.listViewBudget.Name = "listViewBudget";
            this.listViewBudget.Size = new System.Drawing.Size(340, 254);
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
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(774, 9);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit Account";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(878, 9);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(8, 11);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(98, 23);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // IncomePanel
            // 
            this.IncomePanel.Controls.Add(this.buttonDeleteIncome);
            this.IncomePanel.Controls.Add(this.buttonAddIncome);
            this.IncomePanel.Controls.Add(this.label5);
            this.IncomePanel.Controls.Add(this.labelTotalIncome);
            this.IncomePanel.Controls.Add(this.label1);
            this.IncomePanel.Controls.Add(this.AddPayDate);
            this.IncomePanel.Controls.Add(this.listViewIncome);
            this.IncomePanel.Location = new System.Drawing.Point(988, 0);
            this.IncomePanel.Name = "IncomePanel";
            this.IncomePanel.Size = new System.Drawing.Size(353, 264);
            this.IncomePanel.TabIndex = 1;
            // 
            // buttonDeleteIncome
            // 
            this.buttonDeleteIncome.Location = new System.Drawing.Point(85, 237);
            this.buttonDeleteIncome.Name = "buttonDeleteIncome";
            this.buttonDeleteIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteIncome.TabIndex = 8;
            this.buttonDeleteIncome.Text = "Delete Income";
            this.buttonDeleteIncome.UseVisualStyleBackColor = true;
            this.buttonDeleteIncome.Click += new System.EventHandler(this.buttonDeleteIncome_Click);
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Location = new System.Drawing.Point(4, 237);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonAddIncome.TabIndex = 7;
            this.buttonAddIncome.Text = "Add Income";
            this.buttonAddIncome.UseVisualStyleBackColor = true;
            this.buttonAddIncome.Click += new System.EventHandler(this.buttonAddIncome_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 13);
            this.label5.MinimumSize = new System.Drawing.Size(105, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monthly Income";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.Location = new System.Drawing.Point(275, 238);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(69, 22);
            this.labelTotalIncome.TabIndex = 3;
            this.labelTotalIncome.Text = "4139.17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Income";
            // 
            // AddPayDate
            // 
            this.AddPayDate.Location = new System.Drawing.Point(79, 280);
            this.AddPayDate.Name = "AddPayDate";
            this.AddPayDate.Size = new System.Drawing.Size(104, 23);
            this.AddPayDate.TabIndex = 1;
            this.AddPayDate.Text = "Add Pay Date";
            this.AddPayDate.UseVisualStyleBackColor = true;
            // 
            // listViewIncome
            // 
            this.listViewIncome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAmount,
            this.columnHeaderDate});
            this.listViewIncome.FullRowSelect = true;
            this.listViewIncome.Location = new System.Drawing.Point(3, 45);
            this.listViewIncome.Name = "listViewIncome";
            this.listViewIncome.Size = new System.Drawing.Size(341, 186);
            this.listViewIncome.TabIndex = 0;
            this.listViewIncome.UseCompatibleStateImageBehavior = false;
            this.listViewIncome.View = System.Windows.Forms.View.Details;
            this.listViewIncome.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewIncome_MouseDoubleClick);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvMain, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lvMain
            // 
            this.lvMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnBalance,
            this.columnHeaderMonthlyPayment,
            this.columnHeaderDateDue,
            this.columnHeaderPaid,
            this.columnConfirmationNumber});
            this.lvMain.FullRowSelect = true;
            this.lvMain.Location = new System.Drawing.Point(4, 3);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(968, 517);
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
            this.columnConfirmationNumber.Width = 250;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 642);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Budget";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.IncomePanel.ResumeLayout(false);
            this.IncomePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvMain;
        private Panel IncomePanel;
        private Label labelTotalIncome;
        private Label label1;
        private Button AddPayDate;
        private ListView listViewIncome;
        private Label labelMonth;
        private Button buttonNextMonth;
        private Button buttonPrevMonth;
        private Button btnAddAccount;
        private Button btnDeleteAccount;
        private Button buttonEdit;
        private Panel panel2;
        private Label label3;
        private ListView listViewBudget;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private ColumnHeader columnHeaderMonthlyPayment;
        private ColumnHeader columnBalance;
        private ColumnHeader columnHeaderDateDue;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderPaid;
        private ColumnHeader columnConfirmationNumber;
        private Button buttonAddIncome;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderBDate;
        private ColumnHeader columnHeaderBAmount;
        private Button buttonCalcBudget;
        private Button buttonDeleteIncome;
        private Button buttonViewAccounts;
    }
}

