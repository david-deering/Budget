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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.textBoxDateDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPaid = new System.Windows.Forms.Label();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.textBoxConfirmationNumber = new System.Windows.Forms.TextBox();
            this.labelConfirmationNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(192, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(43, 192);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.BtnAdd);
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPayment.Location = new System.Drawing.Point(139, 11);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(145, 20);
            this.textBoxPayment.TabIndex = 1;
            // 
            // textBoxDateDue
            // 
            this.textBoxDateDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDateDue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDateDue.Location = new System.Drawing.Point(139, 54);
            this.textBoxDateDue.Name = "textBoxDateDue";
            this.textBoxDateDue.Size = new System.Drawing.Size(145, 20);
            this.textBoxDateDue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Due";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountDue.Location = new System.Drawing.Point(3, 10);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(130, 23);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "Amount Due";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.44352F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.55648F));
            this.tableLayoutPanel1.Controls.Add(this.labelPaid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountDue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDateDue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPaid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxConfirmationNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelConfirmationNumber, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 174);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelPaid
            // 
            this.labelPaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPaid.Location = new System.Drawing.Point(3, 96);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(130, 23);
            this.labelPaid.TabIndex = 13;
            this.labelPaid.Text = "Paid";
            this.labelPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(139, 100);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPaid.TabIndex = 14;
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmationNumber
            // 
            this.textBoxConfirmationNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConfirmationNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxConfirmationNumber.Location = new System.Drawing.Point(139, 141);
            this.textBoxConfirmationNumber.Name = "textBoxConfirmationNumber";
            this.textBoxConfirmationNumber.Size = new System.Drawing.Size(145, 20);
            this.textBoxConfirmationNumber.TabIndex = 16;
            // 
            // labelConfirmationNumber
            // 
            this.labelConfirmationNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConfirmationNumber.Location = new System.Drawing.Point(3, 140);
            this.labelConfirmationNumber.Name = "labelConfirmationNumber";
            this.labelConfirmationNumber.Size = new System.Drawing.Size(130, 23);
            this.labelConfirmationNumber.TabIndex = 15;
            this.labelConfirmationNumber.Text = "Confirmation Number";
            this.labelConfirmationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditBillWindow
            // 
            this.ClientSize = new System.Drawing.Size(318, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "EditBillWindow";
            this.Text = "Edit Bill";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.TextBox textBoxDateDue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.Label labelConfirmationNumber;
        private System.Windows.Forms.TextBox textBoxConfirmationNumber;
    }
}