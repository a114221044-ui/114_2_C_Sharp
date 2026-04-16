using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_UPPERCASE = 8; // Minimum number of uppercase letters required
            string password = passwordTextBox.Text; // Get the password from the text box
            if(password.Length < WIN_LENGTH)
            {
                MessageBox.Show("Password is too short.");
                return;
            }
            else
             {int upperCaseCount = NumberUpperCase(password); // Count uppercase letters
                int lowerCaseCount = NumberLowerCase(password); // Count lowercase letters
                int digitCount = NumberDigits(password); // Count digits
                if (lowerCaseCount < 1) { 
                    MessageBox.Show("Password must contain at least one lowercase letter.");
                }
                else if (upperCaseCount < 1) { 
                    MessageBox.Show("Password must contain at least one uppercase letter.");
                }
                else if (digitCount < 1) { 
                    MessageBox.Show("Password must contain at least one digit.");
                }
                else
                {
                    MessageBox.Show("Password is valid.");
                }

            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
