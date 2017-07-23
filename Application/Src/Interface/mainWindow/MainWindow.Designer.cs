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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPrevMonth = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.IncomePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPayDate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.columnHeaderMonthlyPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.IncomePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.btnDeleteAccount);
            this.panel1.Controls.Add(this.btnAddAccount);
            this.panel1.Controls.Add(this.IncomePanel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2506, 1096);
            this.panel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(768, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 69);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // buttonPrevMonth
            // 
            this.buttonPrevMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPrevMonth.Location = new System.Drawing.Point(74, 12);
            this.buttonPrevMonth.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrevMonth.Name = "buttonPrevMonth";
            this.buttonPrevMonth.Size = new System.Drawing.Size(46, 44);
            this.buttonPrevMonth.TabIndex = 6;
            this.buttonPrevMonth.Text = "<";
            this.buttonPrevMonth.UseVisualStyleBackColor = true;
            this.buttonPrevMonth.Click += new System.EventHandler(this.buttonPrevMonth_Click);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNextMonth.Location = new System.Drawing.Point(510, 12);
            this.buttonNextMonth.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(46, 44);
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
            this.labelMonth.Location = new System.Drawing.Point(132, 0);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMonth.MinimumSize = new System.Drawing.Size(208, 48);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(366, 69);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "December";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Location = new System.Drawing.Point(1978, 519);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 567);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.MinimumSize = new System.Drawing.Size(208, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weekly Budget";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(8, 73);
            this.listView2.Margin = new System.Windows.Forms.Padding(6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(504, 485);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(224, 19);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 44);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit Account";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(432, 19);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(196, 44);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(16, 19);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(196, 44);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // IncomePanel
            // 
            this.IncomePanel.Controls.Add(this.label5);
            this.IncomePanel.Controls.Add(this.label2);
            this.IncomePanel.Controls.Add(this.label1);
            this.IncomePanel.Controls.Add(this.AddPayDate);
            this.IncomePanel.Controls.Add(this.listView1);
            this.IncomePanel.Location = new System.Drawing.Point(1976, 0);
            this.IncomePanel.Margin = new System.Windows.Forms.Padding(6);
            this.IncomePanel.Name = "IncomePanel";
            this.IncomePanel.Size = new System.Drawing.Size(524, 508);
            this.IncomePanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.MinimumSize = new System.Drawing.Size(208, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 48);
            this.label5.TabIndex = 6;
            this.label5.Text = "Income";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "4139.17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 458);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Income";
            // 
            // AddPayDate
            // 
            this.AddPayDate.Location = new System.Drawing.Point(158, 538);
            this.AddPayDate.Margin = new System.Windows.Forms.Padding(6);
            this.AddPayDate.Name = "AddPayDate";
            this.AddPayDate.Size = new System.Drawing.Size(208, 44);
            this.AddPayDate.TabIndex = 1;
            this.AddPayDate.Text = "Add Pay Date";
            this.AddPayDate.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 87);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(506, 367);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvMain, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 81);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1954, 1006);
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
            this.columnHeaderPaid});
            this.lvMain.FullRowSelect = true;
            this.lvMain.Location = new System.Drawing.Point(11, 9);
            this.lvMain.Margin = new System.Windows.Forms.Padding(6);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(1932, 991);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderMonthlyPayment
            // 
            this.columnHeaderMonthlyPayment.Text = "Monthly Payment";
            this.columnHeaderMonthlyPayment.Width = 100;
            // 
            // columnBalance
            // 
            this.columnBalance.Text = "Account Balance";
            this.columnBalance.Width = 100;
            // 
            // columnHeaderDateDue
            // 
            this.columnHeaderDateDue.Text = "Date Due";
            this.columnHeaderDateDue.Width = 100;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "CompanyName";
            this.columnHeaderName.Width = 220;
            // 
            // columnHeaderPaid
            // 
            this.columnHeaderPaid.Text = "Status";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2588, 1131);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private Label label2;
        private Label label1;
        private Button AddPayDate;
        private ListView listView1;
        private Label labelMonth;
        private Button buttonNextMonth;
        private Button buttonPrevMonth;
        private Button btnAddAccount;
        private Button btnDeleteAccount;
        private Button buttonEdit;
        private Panel panel2;
        private Label label3;
        private ListView listView2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private ColumnHeader columnHeaderMonthlyPayment;
        private ColumnHeader columnBalance;
        private ColumnHeader columnHeaderDateDue;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderPaid;
    }
}

