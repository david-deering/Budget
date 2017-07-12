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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTotalOwed = new System.Windows.Forms.TextBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.textBoxDateDueMonth = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDateDueDay = new System.Windows.Forms.TextBox();
            this.textBoxDateDueYear = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxDateDueYear);
            this.panel2.Controls.Add(this.textBoxDateDueDay);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxTotalOwed);
            this.panel2.Controls.Add(this.textBoxPayment);
            this.panel2.Controls.Add(this.textBoxDateDueMonth);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 264);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAdd);
            // 
            // textBoxTotalOwed
            // 
            this.textBoxTotalOwed.Location = new System.Drawing.Point(86, 47);
            this.textBoxTotalOwed.Name = "textBoxTotalOwed";
            this.textBoxTotalOwed.Size = new System.Drawing.Size(174, 20);
            this.textBoxTotalOwed.TabIndex = 7;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(85, 86);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(174, 20);
            this.textBoxPayment.TabIndex = 6;
            // 
            // textBoxDateDueMonth
            // 
            this.textBoxDateDueMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDateDueMonth.Location = new System.Drawing.Point(85, 124);
            this.textBoxDateDueMonth.Name = "textBoxDateDueMonth";
            this.textBoxDateDueMonth.Size = new System.Drawing.Size(44, 20);
            this.textBoxDateDueMonth.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Payment Due";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Due";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Owed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDateDueDay
            // 
            this.textBoxDateDueDay.Location = new System.Drawing.Point(135, 124);
            this.textBoxDateDueDay.Name = "textBoxDateDueDay";
            this.textBoxDateDueDay.Size = new System.Drawing.Size(44, 20);
            this.textBoxDateDueDay.TabIndex = 10;
            // 
            // textBoxDateDueYear
            // 
            this.textBoxDateDueYear.Location = new System.Drawing.Point(185, 124);
            this.textBoxDateDueYear.Name = "textBoxDateDueYear";
            this.textBoxDateDueYear.Size = new System.Drawing.Size(44, 20);
            this.textBoxDateDueYear.TabIndex = 11;
            // 
            // EditBillWindow
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel2);
            this.Name = "EditBillWindow";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTotalOwed;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.TextBox textBoxDateDueMonth;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDateDueYear;
        private System.Windows.Forms.TextBox textBoxDateDueDay;

    }
}