namespace mainWindow
{
    partial class SaveAccountWindow
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
            this.labelAccountBalance = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tableLayoutPanelAccount = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelFirstPaymentDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxFirstDueDate = new System.Windows.Forms.TextBox();
            this.textBoxAmountDue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAddAccount = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelAccount.SuspendLayout();
            this.tableLayoutPanelAddAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAccountBalance
            // 
            this.labelAccountBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAccountBalance.Location = new System.Drawing.Point(3, 152);
            this.labelAccountBalance.Name = "labelAccountBalance";
            this.labelAccountBalance.Size = new System.Drawing.Size(91, 23);
            this.labelAccountBalance.TabIndex = 4;
            this.labelAccountBalance.Text = "AccountBalance";
            this.labelAccountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInterestRate.Location = new System.Drawing.Point(3, 86);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(89, 23);
            this.labelInterestRate.TabIndex = 3;
            this.labelInterestRate.Text = "Interest Rate";
            this.labelInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.Location = new System.Drawing.Point(4, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelAccount
            // 
            this.tableLayoutPanelAccount.ColumnCount = 2;
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4471F));
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.5529F));
            this.tableLayoutPanelAccount.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanelAccount.Controls.Add(this.labelInterestRate, 0, 1);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxInterestRate, 1, 1);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxBalance, 1, 2);
            this.tableLayoutPanelAccount.Controls.Add(this.labelAccountBalance, 0, 2);
            this.tableLayoutPanelAccount.Location = new System.Drawing.Point(2, 13);
            this.tableLayoutPanelAccount.Name = "tableLayoutPanelAccount";
            this.tableLayoutPanelAccount.RowCount = 3;
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAccount.Size = new System.Drawing.Size(293, 197);
            this.tableLayoutPanelAccount.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Location = new System.Drawing.Point(101, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxInterestRate.Location = new System.Drawing.Point(101, 87);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.Size = new System.Drawing.Size(174, 20);
            this.textBoxInterestRate.TabIndex = 2;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBalance.Location = new System.Drawing.Point(101, 153);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(174, 20);
            this.textBoxBalance.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 329);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(216, 329);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(115, 329);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelFirstPaymentDate
            // 
            this.labelFirstPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFirstPaymentDate.Location = new System.Drawing.Point(3, 13);
            this.labelFirstPaymentDate.Name = "labelFirstPaymentDate";
            this.labelFirstPaymentDate.Size = new System.Drawing.Size(91, 23);
            this.labelFirstPaymentDate.TabIndex = 9;
            this.labelFirstPaymentDate.Text = "First Due Date";
            this.labelFirstPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAmount.Location = new System.Drawing.Point(3, 63);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(91, 23);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount Due";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstDueDate
            // 
            this.textBoxFirstDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFirstDueDate.Location = new System.Drawing.Point(101, 15);
            this.textBoxFirstDueDate.Name = "textBoxFirstDueDate";
            this.textBoxFirstDueDate.Size = new System.Drawing.Size(174, 20);
            this.textBoxFirstDueDate.TabIndex = 4;
            // 
            // textBoxAmountDue
            // 
            this.textBoxAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAmountDue.Location = new System.Drawing.Point(101, 65);
            this.textBoxAmountDue.Name = "textBoxAmountDue";
            this.textBoxAmountDue.Size = new System.Drawing.Size(174, 20);
            this.textBoxAmountDue.TabIndex = 5;
            // 
            // tableLayoutPanelAddAccount
            // 
            this.tableLayoutPanelAddAccount.ColumnCount = 2;
            this.tableLayoutPanelAddAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78839F));
            this.tableLayoutPanelAddAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.2116F));
            this.tableLayoutPanelAddAccount.Controls.Add(this.labelFirstPaymentDate, 0, 0);
            this.tableLayoutPanelAddAccount.Controls.Add(this.labelAmount, 0, 1);
            this.tableLayoutPanelAddAccount.Controls.Add(this.textBoxFirstDueDate, 1, 0);
            this.tableLayoutPanelAddAccount.Controls.Add(this.textBoxAmountDue, 1, 1);
            this.tableLayoutPanelAddAccount.Location = new System.Drawing.Point(2, 217);
            this.tableLayoutPanelAddAccount.Name = "tableLayoutPanelAddAccount";
            this.tableLayoutPanelAddAccount.RowCount = 2;
            this.tableLayoutPanelAddAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddAccount.Size = new System.Drawing.Size(293, 100);
            this.tableLayoutPanelAddAccount.TabIndex = 2;
            this.tableLayoutPanelAddAccount.Visible = false;
            // 
            // AccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 368);
            this.Controls.Add(this.tableLayoutPanelAddAccount);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanelAccount);
            this.Name = "SaveAccountWindow";
            this.Text = "Account";
            this.tableLayoutPanelAccount.ResumeLayout(false);
            this.tableLayoutPanelAccount.PerformLayout();
            this.tableLayoutPanelAddAccount.ResumeLayout(false);
            this.tableLayoutPanelAddAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAccountBalance;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAccount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInterestRate;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelFirstPaymentDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmountDue;
        private System.Windows.Forms.TextBox textBoxFirstDueDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddAccount;
    }
}