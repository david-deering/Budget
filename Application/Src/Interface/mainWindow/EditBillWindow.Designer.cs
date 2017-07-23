﻿namespace mainWindow
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.textBoxDateDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPaid = new System.Windows.Forms.Label();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 136);
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
            this.textBoxPayment.Location = new System.Drawing.Point(81, 4);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(145, 31);
            this.textBoxPayment.TabIndex = 1;
            // 
            // textBoxDateDue
            // 
            this.textBoxDateDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateDue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDateDue.Location = new System.Drawing.Point(81, 43);
            this.textBoxDateDue.Name = "textBoxDateDue";
            this.textBoxDateDue.Size = new System.Drawing.Size(145, 31);
            this.textBoxDateDue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Due";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountDue.Location = new System.Drawing.Point(3, 8);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(67, 23);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "Amount Due";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.19913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.80087F));
            this.tableLayoutPanel1.Controls.Add(this.labelPaid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountDue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDateDue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPaid, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 118);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelPaid
            // 
            this.labelPaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPaid.Location = new System.Drawing.Point(3, 86);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(67, 23);
            this.labelPaid.TabIndex = 13;
            this.labelPaid.Text = "Paid";
            this.labelPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(140, 84);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(28, 27);
            this.checkBoxPaid.TabIndex = 14;
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // EditBillWindow
            // 
            this.ClientSize = new System.Drawing.Size(256, 194);
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
        private System.Windows.Forms.TextBox textBoxDateDue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.CheckBox checkBoxPaid;

    }
}