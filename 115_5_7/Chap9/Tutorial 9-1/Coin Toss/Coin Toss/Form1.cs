using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            outputListBox.Items.Clear();

            // 擲硬幣五次
            for (int i = 0; i < 5; i++)
            {
                // 產生 0 或 1 的隨機數字
                int coinSide = random.Next(0, 2);

                // 根據隨機數字顯示「正面」或「反面」
                if (coinSide == 0)
                {
                    outputListBox.Items.Add("正面");
                }
                else
                {
                    outputListBox.Items.Add("反面");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
