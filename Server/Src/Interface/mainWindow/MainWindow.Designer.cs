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
            this.IncomePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPayDate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.IncomePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IncomePanel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(20, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 687);
            this.panel1.TabIndex = 0;
            // 
            // IncomePanel
            // 
            this.IncomePanel.Controls.Add(this.button2);
            this.IncomePanel.Controls.Add(this.button1);
            this.IncomePanel.Controls.Add(this.label4);
            this.IncomePanel.Controls.Add(this.label2);
            this.IncomePanel.Controls.Add(this.label1);
            this.IncomePanel.Controls.Add(this.AddPayDate);
            this.IncomePanel.Controls.Add(this.listView1);
            this.IncomePanel.Location = new System.Drawing.Point(988, 7);
            this.IncomePanel.Name = "IncomePanel";
            this.IncomePanel.Size = new System.Drawing.Size(262, 306);
            this.IncomePanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 7);
            this.label4.MinimumSize = new System.Drawing.Size(105, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "December";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "4139.17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 238);
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 199);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvMain, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lvMain
            // 
            this.lvMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvMain.FullRowSelect = true;
            this.lvMain.Location = new System.Drawing.Point(4, 3);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(968, 481);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 722);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
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
        private Label label4;
        private Button button2;
        private Button button1;
    }
}

