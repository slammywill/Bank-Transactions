using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swi126_Homework2
{
    public partial class BankTransactionsForm : Form
    {
        public BankTransactionsForm()
        {
            InitializeComponent();
        }

        bool ValidateTransactionCode()
        {
            if (int.TryParse(TransactionCodeText.Text, out int code) &&
                TransactionCodeText.Text.Length == 2)
            {
                foreach (Transaction transaction in Transaction.TransactionList)
                {
                    if (int.Parse(TransactionCodeText.Text) == transaction.transactionCode)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        double CalculateTodayWithdrawals()
        {
            double withdrawals = 0;

            foreach(Transaction transaction in Transaction.TransactionList)
            {
                if(transaction.transactionDate == TransactionDateText.Text &&
                    transaction.transactionType == 'w')
                {
                    withdrawals += transaction.transactionValue;
                }
            }
            return withdrawals;
        }
        
        
        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            const double MAX_WITHDRAWAL_PER_DAY = 10000;

            //Input Validation.
            if (string.IsNullOrEmpty(Transaction.transactionFileName))
            {
                MessageBox.Show("A transaction file must be selected to add a transaction.");
                return;
            }
            if (!ValidateTransactionCode())
            {
                MessageBox.Show("The transaction code must be a unique 2 digit number.");
                return;
            }
            else if (!(int.TryParse(CustomerIDText.Text, out int customerID) &&
                CustomerIDText.Text.Length == 6))
            {
                MessageBox.Show("The customer ID must be a 6 digit number.");
                return;
            }
            else if (TransactionTypeCombo.SelectedItem == null)
            {
                MessageBox.Show("A transaction type must be selected.");
                return;
            }
            else if (BranchNumberCombo.SelectedItem == null)
            {
                MessageBox.Show("A branch number must be selected.");
                return;
            }
            else if (!double.TryParse(TransactionValueText.Text, out double value))
            {
                MessageBox.Show("The transaction value must be a positive number.");
                return;
            }
            else if (double.Parse(TransactionValueText.Text) < 0)
            {
                MessageBox.Show("The transaction value must be a positive number.");
                return;
            }
            else if (TransactionTypeCombo.SelectedItem.ToString() == "Withdrawal" &&
                CalculateTodayWithdrawals() + double.Parse(TransactionValueText.Text) 
                > MAX_WITHDRAWAL_PER_DAY)
            {
                MessageBox.Show("You cannot withdraw more than $10,000 per day");
                return;
            }

            //--------------------------------------------------------------------------

            else
            {
                //Adding the new transaction if all the inputs are valid.
                Dictionary<string, char> transactionTypeDict = new Dictionary<string, char>
                {
                    {"Deposit", 'd'},
                    {"Withdrawal", 'w'}
                };
                int branchNumber = int.Parse(BranchNumberCombo.Text[0].ToString());
                Transaction transaction = new Transaction(int.Parse(TransactionCodeText.Text),
                    int.Parse(CustomerIDText.Text), transactionTypeDict[TransactionTypeCombo.SelectedItem.ToString()],
                    branchNumber, TransactionDateText.Text, double.Parse(TransactionValueText.Text)
                    );
                Transaction.TransactionList.Add(transaction);
                if (!Transaction.TransactionMonths.Contains(transaction.transactionMonth))
                {
                    Transaction.TransactionMonths.Add(transaction.transactionMonth);
                }
                MessageBox.Show("Transaction Added!");
                updateTransactionMonths();
                ClearAddTransactionFields();
            }


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        struct Transaction
        {
            public int transactionCode;
            public int customerID;
            public char transactionType;
            public int branchNumber;
            public string transactionDate;
            public double transactionValue;
            public string transactionMonth;

            public static List<Transaction> TransactionList = new List<Transaction>();
            public static string transactionFileName = "";
            public static List<string> TransactionMonths = new List<string>();
            public static int StartNumOfTransactions = 0;

            public Transaction(int transactionCode, int customerID, char transactionType,
                int branchNumber, string transactionDate, double transactionValue)
            {
                this.transactionCode = transactionCode;
                this.customerID = customerID;
                this.transactionType = transactionType;
                this.branchNumber = branchNumber;
                this.transactionDate = transactionDate;
                this.transactionValue = transactionValue;
                string[] date = this.transactionDate.Split('-');
                this.transactionMonth = date[1];

            }
        }

        string GetRawTransactionDataFromFile()
        {
            // Prompts the user to select a file of transactions and returns the string
            // of the entire file.
            StreamReader inputFile;
            OpenFileDialog ofd = new OpenFileDialog();
            string strResult;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(ofd.FileName);
                Transaction.transactionFileName = ofd.FileName;
                strResult = inputFile.ReadToEnd();
                inputFile.Close();
            }
            else
            {
                strResult = "";
            }

            return strResult;
        }

        void CreateTransactionList(string rawTransactions)
        {

            foreach (string transactionLine in rawTransactions.Split(
                new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                // Splits the string of all the transactions into individual transactions
                // and parses them into a Transaction struct, which is added to a list
                // of all the transactions.
                string[] data;
                data = transactionLine.Split(',');
                if (data.Length == 6)
                {
                    Transaction transaction = new Transaction(
                        int.Parse(data[0]),
                        int.Parse(data[1]),
                        char.Parse(data[2]),
                        int.Parse(data[3]),
                        data[4],
                        double.Parse(data[5]));
                    if (!Transaction.TransactionMonths.Contains(transaction.transactionMonth))
                    {
                        Transaction.TransactionMonths.Add(transaction.transactionMonth);
                    }
                    Transaction.TransactionList.Add(transaction);
                }
            }
        }

        void updateTransactionMonths()
        {
            foreach (string month in Transaction.TransactionMonths)
            {
                if (!MonthCombo.Items.Contains(month))
                {
                    MonthCombo.Items.Add(month);
                }
            }
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            string rawTransactions = GetRawTransactionDataFromFile();
            Transaction.TransactionList.Clear();
            CreateTransactionList(rawTransactions);

            // Changes what months are available to select from if more months are in the
            // list of transactions.
            updateTransactionMonths();
            SetTransactionDate();
            Transaction.StartNumOfTransactions = Transaction.TransactionList.Count;
        }

        void SetTransactionDate()
        {
            // Sets the date of the transaction in the add transaction section to the current date.
            Dictionary<string, string> date = new Dictionary<string, string>
            {
                {"01", "JAN"}, {"02", "FEB"}, {"03", "MAR"}, {"04", "APR"}, {"05", "MAY"},
                {"06", "JUN"}, {"07", "JUL"}, {"08", "AUG"}, {"09", "SEP"}, {"10", "OCT"},
                {"11", "NOV"}, {"12", "DEC"},
            };

            DateTime dateTime = DateTime.Now;
            string[] dateSplit = dateTime.ToString().Split(' ', '/');
            TransactionDateText.Text = dateSplit[0] + "-" + date[dateSplit[1]] + "-" + dateSplit[2];
        }


        int BranchSelected()
        {
            switch (BranchCombo.SelectedItem)
            {
                case "Riccarton":
                    return 1;
                case "Airport":
                    return 2;
                case "Hornby":
                    return 3;
                case "New Brighton":
                    return 4;
                case "The Palms":
                    return 5;
                case "Central":
                    return 6;
            }
            return 0;
        }

        private void DisplayTransactionDataBtn_Click(object sender, EventArgs e)
        {
            //Finds which branch has been selected, alerts user if none was selected.
            int branch;
            if (BranchCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a branch.");
                return;
            }
            else
            {
                branch = BranchSelected();
            }

            //--------------------------------------------------------------------------

            //Finds which month has been selected, alerts user if none was selected.
            string month;
            if (MonthCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.");
                return;
            }
            else
            {
                month = MonthCombo.SelectedItem.ToString();
            }

            //--------------------------------------------------------------------------

            int numOfTransactions = 0;
            double depositTotal = 0;
            double withdrawalTotal = 0;
            foreach (Transaction transaction in Transaction.TransactionList)
            {
                if (transaction.branchNumber == branch &&
                    transaction.transactionMonth == month)
                {
                    numOfTransactions++;
                    if (transaction.transactionType == 'd')
                    {
                        depositTotal += transaction.transactionValue;
                    }
                    else if (transaction.transactionType == 'w')
                    {
                        withdrawalTotal += transaction.transactionValue;
                    }
                }
            }
            TransactionDataText.Text = "Number of transactions: " + numOfTransactions.ToString() + "\r\n\r\n" +
                "Total deposit amount: $" + depositTotal.ToString() + "\r\n\r\n" +
                "Total withdrawal amount: $" + withdrawalTotal.ToString();
        }

        void ClearAddTransactionFields()
        {
            TransactionCodeText.Clear();
            CustomerIDText.Clear();
            TransactionTypeCombo.SelectedIndex = -1;
            BranchNumberCombo.SelectedIndex = -1;
            TransactionValueText.Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BranchCombo.SelectedIndex = -1;
            MonthCombo.SelectedIndex = -1;
            TransactionDataText.Clear();
            ClearAddTransactionFields();
        }

        private void BankTransactionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Adds new transactions to the file if any were added.
            if (string.IsNullOrEmpty(Transaction.transactionFileName))
            {
                return;
            }
            using (StreamWriter sw = File.AppendText(Transaction.transactionFileName))
            {
                for (int i = Transaction.StartNumOfTransactions;
                    i < Transaction.TransactionList.Count; i++)
                {
                    Transaction transaction = Transaction.TransactionList[i];
                    sw.WriteLine(transaction.transactionCode.ToString() + "," +
                        transaction.customerID.ToString() + "," +
                        transaction.transactionType.ToString() + "," +
                        transaction.branchNumber.ToString() + "," +
                        transaction.transactionDate + "," +
                        transaction.transactionValue.ToString());
                }
            }
        }
    }
}
