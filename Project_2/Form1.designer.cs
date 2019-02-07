namespace Project_2
{
    partial class Form1
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
            this.lblGpaCalulator = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCreditHrs = new System.Windows.Forms.TextBox();
            this.lblCreditHrs = new System.Windows.Forms.Label();
            this.lblGpaOutput = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGpaCalulator
            // 
            this.lblGpaCalulator.AutoSize = true;
            this.lblGpaCalulator.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpaCalulator.Location = new System.Drawing.Point(454, 105);
            this.lblGpaCalulator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGpaCalulator.Name = "lblGpaCalulator";
            this.lblGpaCalulator.Size = new System.Drawing.Size(277, 43);
            this.lblGpaCalulator.TabIndex = 0;
            this.lblGpaCalulator.Text = "GPA Calculator";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel1.Controls.Add(this.lblGrade, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGrade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCreditHrs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditHrs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGpaOutput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGPA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEnter, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveLast, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnShowAll, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(154, 294);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(4, 0);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(191, 24);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade of Course 1:";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGrade
            // 
            this.txtGrade.CausesValidation = false;
            this.txtGrade.Location = new System.Drawing.Point(296, 5);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(148, 26);
            this.txtGrade.TabIndex = 1;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(617, 93);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCreditHrs
            // 
            this.txtCreditHrs.Location = new System.Drawing.Point(296, 93);
            this.txtCreditHrs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreditHrs.Name = "txtCreditHrs";
            this.txtCreditHrs.Size = new System.Drawing.Size(148, 26);
            this.txtCreditHrs.TabIndex = 2;
            this.txtCreditHrs.TextChanged += new System.EventHandler(this.txtCreditHrs_TextChanged);
            // 
            // lblCreditHrs
            // 
            this.lblCreditHrs.AutoSize = true;
            this.lblCreditHrs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditHrs.Location = new System.Drawing.Point(4, 88);
            this.lblCreditHrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditHrs.Name = "lblCreditHrs";
            this.lblCreditHrs.Size = new System.Drawing.Size(253, 24);
            this.lblCreditHrs.TabIndex = 0;
            this.lblCreditHrs.Text = "Credit Hours of Course 1:";
            // 
            // lblGpaOutput
            // 
            this.lblGpaOutput.AutoSize = true;
            this.lblGpaOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGpaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpaOutput.ForeColor = System.Drawing.Color.Blue;
            this.lblGpaOutput.Location = new System.Drawing.Point(296, 170);
            this.lblGpaOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGpaOutput.Name = "lblGpaOutput";
            this.lblGpaOutput.Size = new System.Drawing.Size(76, 29);
            this.lblGpaOutput.TabIndex = 0;
            this.lblGpaOutput.Text = "0.000";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(4, 170);
            this.lblGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(68, 24);
            this.lblGPA.TabIndex = 7;
            this.lblGPA.Text = "GPA =";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(617, 328);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLast.Location = new System.Drawing.Point(617, 253);
            this.btnRemoveLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(164, 35);
            this.btnRemoveLast.TabIndex = 6;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(617, 5);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 35);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(616, 173);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(120, 37);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
           // this.btnShowAll.ClientSizeChanged += new System.EventHandler(this.btnShowAll_ClientSizeChanged);
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 891);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblGpaCalulator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "DataEntry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGpaCalulator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCreditHrs;
        private System.Windows.Forms.Label lblCreditHrs;
        private System.Windows.Forms.Label lblGpaOutput;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnShowAll;
    }
}

