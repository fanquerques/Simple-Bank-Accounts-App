using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AccountsApp
{
    public partial class frmAccounts : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account myAccount;
        public frmAccounts()
        {
            InitializeComponent();
        }


        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked)
            {
                txtInterestRate.Enabled = false;
                txtDailyWithdrawLimit.Enabled = true;
            }
        }
        private void rbtnSavings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSavings.Checked)
            {
                txtInterestRate.Enabled = true;
                txtDailyWithdrawLimit.Enabled = false;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = Convert.ToInt32(txtAccountNumber.Text);
                double accountBalance = Convert.ToDouble(txtBalance.Text);

                // check if accName contains only letters
                string accountName = txtClientName.Text;
                if (!accountName.All(char.IsLetter))
                {
                    throw new FormatException();
                }

                Account newAccount;
                if (rbtnChecking.Checked)
                {
                    double dailyWithdrawLimit = Convert.ToDouble(txtDailyWithdrawLimit.Text);
                    newAccount = new CheckingAccount(accountNumber, accountName, accountBalance, dailyWithdrawLimit);
                }
                else
                {
                    double interestRate = Convert.ToDouble(txtInterestRate.Text);
                    newAccount = new SavingsAccount(accountNumber, accountName, accountBalance, interestRate);
                }

                accounts.Add(newAccount);
                ClearControls();
                MessageBox.Show($"Account created! Total number of accounts: {accounts.Count}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid input for account number, balance, and client name.");
            }
        }
      


        private void ClearControls()
        {
            txtAccountNumber.Text = "";
            txtClientName.Text = "";
            txtBalance.Text = "0.00";
            txtDailyWithdrawLimit.Text = "";
            txtInterestRate.Text = "";
            rbtnChecking.Checked = false;
            rbtnSavings.Checked = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int accountNumber = Convert.ToInt32(txtSearchByAccountNumber.Text);
            Account account = accounts.FirstOrDefault(a => a.Number == accountNumber);

            if (account != null)
            {
                txtAccountNumber.Text = account.Number.ToString();
                txtClientName.Text = account.Name;
                txtBalance.Text = account.Balance.ToString("F2");

                if (account is CheckingAccount checkingAccount)
                {
                    rbtnChecking.Checked = true;
                    txtDailyWithdrawLimit.Text = checkingAccount.Limit.ToString("F2");
                    txtInterestRate.Text = "";
                }
                else if (account is SavingsAccount savingsAccount)
                {
                    rbtnSavings.Checked = true;
                    txtInterestRate.Text = savingsAccount.Interest.ToString("F2");
                    txtDailyWithdrawLimit.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }

       
    }
}
