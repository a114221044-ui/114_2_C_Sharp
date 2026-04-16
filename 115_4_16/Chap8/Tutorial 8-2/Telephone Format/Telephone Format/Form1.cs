using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidNumber method accepts a string and
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            str = str.Trim(); // Remove any leading or trailing spaces.
            if (str.Length != 10) // Check if the length is exactly 10.
                return false;

            foreach (char c in str)
            {
                if (!char.IsDigit(c)) // Check if each character is a digit.
                    return false;
            }

            return true;
        }

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        private void TelephoneFormat(ref string str)
        {
            //str = str.Trim(); // Remove any leading or trailing spaces.
            //str = String.Concat("(", str.Substring(0, 2), ") ", str.Substring(2, 4), "-", str.Substring(6, 4));

            //str = str.Replace(" ", ""); // Remove any spaces from the formatted string.

            str=str.Insert(0, "(");// Insert "(" at the beginning.
            str=str.Insert(3, ") ");// Insert ") " after the area code.
            str=str.Insert(9, "-");// Insert "-" after the first 6 digits.
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text;
            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input);
                MessageBox.Show("格式化後的電話號碼: " + input, "結果");
            }
            else
            {
                MessageBox.Show("錯誤: 請輸入有效的10位數字電話號碼。", "輸入錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
