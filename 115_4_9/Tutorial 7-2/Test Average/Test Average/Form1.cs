using System;
using System.IO;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        private double Average(int[] sArray)
        {
            if (sArray == null || sArray.Length == 0)
            {
                throw new ArgumentException("sArray 不能為 null 或空陣列。", nameof(sArray));
            }

            int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] < 0)
                {
                    throw new ArgumentException("分數不能為負數。", nameof(sArray));
                }
                total += sArray[i];
            }

            return (double)total / sArray.Length;
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        private int Highest(int[] sArray)
        {
            if (sArray == null || sArray.Length == 0)
            {
                throw new ArgumentException("sArray 不能為 null 或空陣列。", nameof(sArray));
            }

            int highScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i];
                }
            }
            return highScore;
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        private int Lowest(int[] sArray )
        {
            int lowScore = 0;
            for(int i = 1; i < sArray.Length; i++)
            {


                if (sArray[i] < lowScore)
                {
                    lowScore = sArray[i];
                }
                {
                    return 0;
                }
            }
        
            return lowScore;

        }
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 60;
            int[] scores = new int[SIZE];
            int index = 0;

            try
            {
                using (StreamReader inputFile = File.OpenText("TextScores.txt"))
                {
                    while (!inputFile.EndOfStream && index < scores.Length)
                    {
                        string line = inputFile.ReadLine();
                        if (int.TryParse(line, out int value))
                        {
                            scores[index++] = value;
                        }
                    }
                }

                testScoresListBox.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    testScoresListBox.Items.Add(scores[i]);
                }

                // 如果沒有讀到任何分數，就提示使用者
                if (index == 0)
                {
                    MessageBox.Show("未讀取到任何分數。請檢查 TextScores.txt 檔案。");
                    return;
                }

                // 計算與顯示結果（只使用已讀取的項目）
                int[] actualScores = new int[index];
                Array.Copy(scores, actualScores, index);
                double averageScores = Average(actualScores);
                int highest = Highest(actualScores);
                int lowest = Lowest(actualScores);

                MessageBox.Show(
                    $"平均: {averageScores:F2}\n最高: {highest}\n最低: {lowest}",
                    "分數統計",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
