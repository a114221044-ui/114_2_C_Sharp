using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidFormat method accepts a string argument
        // and determines whether it is properly formatted as
        // a US telephone number in the following manner:
        // (XXX)XXX-XXXX
        // If the argument is properly formatted, the method
        // returns true, otherwise false.
        private bool IsValidFormat(string str)
        {
            // Check if the string length is exactly 14 characters
            if (str.Length != 13)
                return false;

            // Check if the first character is '('
            if (str[0] != '(')
                return false;

            // Check if the fourth character is ')'
            if (str[4] != ')')
                return false;

            // Check if the ninth character is '-'
            if (str[8] != '-')
                return false;

            // Check if all other characters are digits
            for (int i = 10; i < 13; i++)
            {
                if (i != 4 && i != 8) // Skip the positions of '(' ,')' and '-'
                {
                    if (!char.IsDigit(str[i]))
                        return false;
                }
            }

            return true;
        }

        // The unformat method accepts a string, by reference,
        // assumed to contain a telephone number formatted in
        // this manner: (XXX)XXX-XXXX.
        // The method unformats the string by removing the
        // parentheses and the hyphen.
        private void Unformat(ref string str)
        {
            // Remove the '(' and ')' characters
            //str = str.Replace("(", "").Replace(")", "");

            // Remove the '-' character
            //str = str.Replace("-", "");

            str = str.Remove(0, 1); // Remove the first character '('
            str = str.Remove(2, 1); // Remove the fourth character ')'
            str = str.Remove(5, 1); // Remove the seventh character '-'
            str = str.Insert(6, ""); // Insert an empty string at the third position
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            // Get the text from the numberTextBox
            string input = numberTextBox.Text;

            // Check if the input is in valid format
            if (IsValidFormat(input))
            {
                // Unformat the number
                Unformat(ref input);

                // Display the unformatted number
                MessageBox.Show("未格式化的電話號碼: " + input, "結果");
            }
            else
            {
                MessageBox.Show("輸入的電話號碼格式不正確。請確保格式為 (XXX)XXX-XXXX", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
