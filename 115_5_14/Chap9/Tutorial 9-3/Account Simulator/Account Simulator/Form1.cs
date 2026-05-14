using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private BankAccount account = new BankAccount(20000m);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balanceLabel.Text = account.Balance.ToString("C");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
          decimal depositAmount;
            if (decimal.TryParse(depositTextBox.Text, out depositAmount))
            {
                account.Deposit(depositAmount);
                balanceLabel.Text = account.Balance.ToString("C");
                depositTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal number for the deposit amount.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal withdrawAmount;
            if (decimal.TryParse(withdrawTextBox.Text, out withdrawAmount))
            {
                account.Withdraw(withdrawAmount);
                balanceLabel.Text = account.Balance.ToString("C");
                withdrawTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal number for the withdraw amount.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
