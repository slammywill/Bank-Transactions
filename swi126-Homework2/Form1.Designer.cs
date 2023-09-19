namespace swi126_Homework2
{
    partial class BankTransactionsForm
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
            this.BankTransactionsLabel = new System.Windows.Forms.Label();
            this.SelectBranchLabel = new System.Windows.Forms.Label();
            this.BranchCombo = new System.Windows.Forms.ComboBox();
            this.SelectMonthLabel = new System.Windows.Forms.Label();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.TransactionDataText = new System.Windows.Forms.TextBox();
            this.DisplayTransactionDataBtn = new System.Windows.Forms.Button();
            this.AddTransactionLabel = new System.Windows.Forms.Label();
            this.TransactionCodeLabel = new System.Windows.Forms.Label();
            this.TransactionCodeText = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.TransactionTypeLabel = new System.Windows.Forms.Label();
            this.BranchNumberLabel = new System.Windows.Forms.Label();
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.TransactionValueLabel = new System.Windows.Forms.Label();
            this.AddTransactionBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CustomerIDText = new System.Windows.Forms.TextBox();
            this.TransactionTypeCombo = new System.Windows.Forms.ComboBox();
            this.BranchNumberCombo = new System.Windows.Forms.ComboBox();
            this.TransactionDateText = new System.Windows.Forms.TextBox();
            this.TransactionValueText = new System.Windows.Forms.TextBox();
            this.FileSelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankTransactionsLabel
            // 
            this.BankTransactionsLabel.AutoSize = true;
            this.BankTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankTransactionsLabel.Location = new System.Drawing.Point(42, 15);
            this.BankTransactionsLabel.Name = "BankTransactionsLabel";
            this.BankTransactionsLabel.Size = new System.Drawing.Size(164, 24);
            this.BankTransactionsLabel.TabIndex = 0;
            this.BankTransactionsLabel.Text = "Bank Transactions";
            // 
            // SelectBranchLabel
            // 
            this.SelectBranchLabel.AutoSize = true;
            this.SelectBranchLabel.Location = new System.Drawing.Point(17, 97);
            this.SelectBranchLabel.Name = "SelectBranchLabel";
            this.SelectBranchLabel.Size = new System.Drawing.Size(77, 13);
            this.SelectBranchLabel.TabIndex = 1;
            this.SelectBranchLabel.Text = "Select Branch:";
            // 
            // BranchCombo
            // 
            this.BranchCombo.FormattingEnabled = true;
            this.BranchCombo.Items.AddRange(new object[] {
            "Riccarton",
            "Airport",
            "Hornby",
            "New Brighton",
            "The Palms",
            "Central"});
            this.BranchCombo.Location = new System.Drawing.Point(100, 94);
            this.BranchCombo.Name = "BranchCombo";
            this.BranchCombo.Size = new System.Drawing.Size(121, 21);
            this.BranchCombo.TabIndex = 2;
            // 
            // SelectMonthLabel
            // 
            this.SelectMonthLabel.AutoSize = true;
            this.SelectMonthLabel.Location = new System.Drawing.Point(17, 129);
            this.SelectMonthLabel.Name = "SelectMonthLabel";
            this.SelectMonthLabel.Size = new System.Drawing.Size(73, 13);
            this.SelectMonthLabel.TabIndex = 3;
            this.SelectMonthLabel.Text = "Select Month:";
            // 
            // MonthCombo
            // 
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR"});
            this.MonthCombo.Location = new System.Drawing.Point(100, 126);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(121, 21);
            this.MonthCombo.TabIndex = 4;
            // 
            // TransactionDataText
            // 
            this.TransactionDataText.Location = new System.Drawing.Point(17, 197);
            this.TransactionDataText.Multiline = true;
            this.TransactionDataText.Name = "TransactionDataText";
            this.TransactionDataText.ReadOnly = true;
            this.TransactionDataText.Size = new System.Drawing.Size(204, 81);
            this.TransactionDataText.TabIndex = 5;
            // 
            // DisplayTransactionDataBtn
            // 
            this.DisplayTransactionDataBtn.Location = new System.Drawing.Point(17, 156);
            this.DisplayTransactionDataBtn.Name = "DisplayTransactionDataBtn";
            this.DisplayTransactionDataBtn.Size = new System.Drawing.Size(204, 35);
            this.DisplayTransactionDataBtn.TabIndex = 6;
            this.DisplayTransactionDataBtn.Text = "Display Transaction Data";
            this.DisplayTransactionDataBtn.UseVisualStyleBackColor = true;
            this.DisplayTransactionDataBtn.Click += new System.EventHandler(this.DisplayTransactionDataBtn_Click);
            // 
            // AddTransactionLabel
            // 
            this.AddTransactionLabel.AutoSize = true;
            this.AddTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionLabel.Location = new System.Drawing.Point(17, 288);
            this.AddTransactionLabel.Name = "AddTransactionLabel";
            this.AddTransactionLabel.Size = new System.Drawing.Size(112, 17);
            this.AddTransactionLabel.TabIndex = 7;
            this.AddTransactionLabel.Text = "Add Transaction";
            // 
            // TransactionCodeLabel
            // 
            this.TransactionCodeLabel.AutoSize = true;
            this.TransactionCodeLabel.Location = new System.Drawing.Point(14, 317);
            this.TransactionCodeLabel.Name = "TransactionCodeLabel";
            this.TransactionCodeLabel.Size = new System.Drawing.Size(94, 13);
            this.TransactionCodeLabel.TabIndex = 8;
            this.TransactionCodeLabel.Text = "Transaction Code:";
            // 
            // TransactionCodeText
            // 
            this.TransactionCodeText.Location = new System.Drawing.Point(114, 314);
            this.TransactionCodeText.Name = "TransactionCodeText";
            this.TransactionCodeText.Size = new System.Drawing.Size(106, 20);
            this.TransactionCodeText.TabIndex = 9;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(14, 340);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.CustomerIDLabel.TabIndex = 10;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // TransactionTypeLabel
            // 
            this.TransactionTypeLabel.AutoSize = true;
            this.TransactionTypeLabel.Location = new System.Drawing.Point(14, 364);
            this.TransactionTypeLabel.Name = "TransactionTypeLabel";
            this.TransactionTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.TransactionTypeLabel.TabIndex = 11;
            this.TransactionTypeLabel.Text = "Transaction Type:";
            // 
            // BranchNumberLabel
            // 
            this.BranchNumberLabel.AutoSize = true;
            this.BranchNumberLabel.Location = new System.Drawing.Point(14, 389);
            this.BranchNumberLabel.Name = "BranchNumberLabel";
            this.BranchNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.BranchNumberLabel.TabIndex = 12;
            this.BranchNumberLabel.Text = "Branch Number:";
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Location = new System.Drawing.Point(14, 413);
            this.TransactionDateLabel.Name = "TransactionDateLabel";
            this.TransactionDateLabel.Size = new System.Drawing.Size(92, 13);
            this.TransactionDateLabel.TabIndex = 13;
            this.TransactionDateLabel.Text = "Transaction Date:";
            // 
            // TransactionValueLabel
            // 
            this.TransactionValueLabel.AutoSize = true;
            this.TransactionValueLabel.Location = new System.Drawing.Point(13, 436);
            this.TransactionValueLabel.Name = "TransactionValueLabel";
            this.TransactionValueLabel.Size = new System.Drawing.Size(96, 13);
            this.TransactionValueLabel.TabIndex = 14;
            this.TransactionValueLabel.Text = "Transaction Value:";
            // 
            // AddTransactionBtn
            // 
            this.AddTransactionBtn.Location = new System.Drawing.Point(15, 461);
            this.AddTransactionBtn.Name = "AddTransactionBtn";
            this.AddTransactionBtn.Size = new System.Drawing.Size(206, 38);
            this.AddTransactionBtn.TabIndex = 15;
            this.AddTransactionBtn.Text = "Add Transaction";
            this.AddTransactionBtn.UseVisualStyleBackColor = true;
            this.AddTransactionBtn.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(15, 505);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(99, 29);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(120, 505);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(101, 29);
            this.ExitBtn.TabIndex = 17;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CustomerIDText
            // 
            this.CustomerIDText.Location = new System.Drawing.Point(114, 337);
            this.CustomerIDText.Name = "CustomerIDText";
            this.CustomerIDText.Size = new System.Drawing.Size(106, 20);
            this.CustomerIDText.TabIndex = 18;
            // 
            // TransactionTypeCombo
            // 
            this.TransactionTypeCombo.FormattingEnabled = true;
            this.TransactionTypeCombo.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal"});
            this.TransactionTypeCombo.Location = new System.Drawing.Point(114, 361);
            this.TransactionTypeCombo.Name = "TransactionTypeCombo";
            this.TransactionTypeCombo.Size = new System.Drawing.Size(106, 21);
            this.TransactionTypeCombo.TabIndex = 19;
            // 
            // BranchNumberCombo
            // 
            this.BranchNumberCombo.FormattingEnabled = true;
            this.BranchNumberCombo.Items.AddRange(new object[] {
            "1 (Riccarton)",
            "2 (Airport)",
            "3 (Hornby)",
            "4 (New Brighton)",
            "5 (The Palms)",
            "6 (Central)"});
            this.BranchNumberCombo.Location = new System.Drawing.Point(114, 386);
            this.BranchNumberCombo.Name = "BranchNumberCombo";
            this.BranchNumberCombo.Size = new System.Drawing.Size(106, 21);
            this.BranchNumberCombo.TabIndex = 20;
            // 
            // TransactionDateText
            // 
            this.TransactionDateText.Location = new System.Drawing.Point(114, 410);
            this.TransactionDateText.Name = "TransactionDateText";
            this.TransactionDateText.ReadOnly = true;
            this.TransactionDateText.Size = new System.Drawing.Size(106, 20);
            this.TransactionDateText.TabIndex = 21;
            // 
            // TransactionValueText
            // 
            this.TransactionValueText.Location = new System.Drawing.Point(114, 433);
            this.TransactionValueText.Name = "TransactionValueText";
            this.TransactionValueText.Size = new System.Drawing.Size(106, 20);
            this.TransactionValueText.TabIndex = 22;
            // 
            // FileSelectBtn
            // 
            this.FileSelectBtn.Location = new System.Drawing.Point(17, 52);
            this.FileSelectBtn.Name = "FileSelectBtn";
            this.FileSelectBtn.Size = new System.Drawing.Size(204, 35);
            this.FileSelectBtn.TabIndex = 23;
            this.FileSelectBtn.Text = "Select Transaction Data File";
            this.FileSelectBtn.UseVisualStyleBackColor = true;
            this.FileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // BankTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 550);
            this.Controls.Add(this.FileSelectBtn);
            this.Controls.Add(this.TransactionValueText);
            this.Controls.Add(this.TransactionDateText);
            this.Controls.Add(this.BranchNumberCombo);
            this.Controls.Add(this.TransactionTypeCombo);
            this.Controls.Add(this.CustomerIDText);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddTransactionBtn);
            this.Controls.Add(this.TransactionValueLabel);
            this.Controls.Add(this.TransactionDateLabel);
            this.Controls.Add(this.BranchNumberLabel);
            this.Controls.Add(this.TransactionTypeLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.TransactionCodeText);
            this.Controls.Add(this.TransactionCodeLabel);
            this.Controls.Add(this.AddTransactionLabel);
            this.Controls.Add(this.DisplayTransactionDataBtn);
            this.Controls.Add(this.TransactionDataText);
            this.Controls.Add(this.MonthCombo);
            this.Controls.Add(this.SelectMonthLabel);
            this.Controls.Add(this.BranchCombo);
            this.Controls.Add(this.SelectBranchLabel);
            this.Controls.Add(this.BankTransactionsLabel);
            this.Name = "BankTransactionsForm";
            this.Text = "Bank Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankTransactionsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankTransactionsLabel;
        private System.Windows.Forms.Label SelectBranchLabel;
        private System.Windows.Forms.ComboBox BranchCombo;
        private System.Windows.Forms.Label SelectMonthLabel;
        private System.Windows.Forms.ComboBox MonthCombo;
        private System.Windows.Forms.TextBox TransactionDataText;
        private System.Windows.Forms.Button DisplayTransactionDataBtn;
        private System.Windows.Forms.Label AddTransactionLabel;
        private System.Windows.Forms.Label TransactionCodeLabel;
        private System.Windows.Forms.TextBox TransactionCodeText;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label TransactionTypeLabel;
        private System.Windows.Forms.Label BranchNumberLabel;
        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.Label TransactionValueLabel;
        private System.Windows.Forms.Button AddTransactionBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox CustomerIDText;
        private System.Windows.Forms.ComboBox TransactionTypeCombo;
        private System.Windows.Forms.ComboBox BranchNumberCombo;
        private System.Windows.Forms.TextBox TransactionDateText;
        private System.Windows.Forms.TextBox TransactionValueText;
        private System.Windows.Forms.Button FileSelectBtn;
    }
}

