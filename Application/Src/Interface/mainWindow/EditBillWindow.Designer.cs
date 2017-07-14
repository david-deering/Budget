namespace mainWindow
{
    partial class EditBillWindow
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
            this.textBoxDateDueYear = new System.Windows.Forms.TextBox();
            this.textBoxDateDueDay = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.textBoxDateDueMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDateDueYear
            // 
            this.textBoxDateDueYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateDueYear.Location = new System.Drawing.Point(199, 54);
            this.textBoxDateDueYear.Name = "textBoxDateDueYear";
            this.textBoxDateDueYear.Size = new System.Drawing.Size(43, 20);
            this.textBoxDateDueYear.TabIndex = 11;
            // 
            // textBoxDateDueDay
            // 
            this.textBoxDateDueDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateDueDay.Location = new System.Drawing.Point(153, 54);
            this.textBoxDateDueDay.Name = "textBoxDateDueDay";
            this.textBoxDateDueDay.Size = new System.Drawing.Size(40, 20);
            this.textBoxDateDueDay.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAdd);
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPayment.Location = new System.Drawing.Point(103, 10);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(44, 20);
            this.textBoxPayment.TabIndex = 6;
            // 
            // textBoxDateDueMonth
            // 
            this.textBoxDateDueMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateDueMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDateDueMonth.Location = new System.Drawing.Point(103, 54);
            this.textBoxDateDueMonth.Name = "textBoxDateDueMonth";
            this.textBoxDateDueMonth.Size = new System.Drawing.Size(44, 20);
            this.textBoxDateDueMonth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Due";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountDue.Location = new System.Drawing.Point(3, 9);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(67, 23);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "Amount Due";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.37168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.62832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDateDueMonth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountDue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDateDueYear, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDateDueDay, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 88);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // EditBillWindow
            // 
            this.ClientSize = new System.Drawing.Size(304, 152);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditBillWindow";
            this.Text = "Edit Bill";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.TextBox textBoxDateDueMonth;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDateDueYear;
        private System.Windows.Forms.TextBox textBoxDateDueDay;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}