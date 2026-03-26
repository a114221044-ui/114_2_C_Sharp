using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // Create a List to hold the scores.
            List<int> scoresList = new List<int>();

            // Read the scores from the file into the List.
            ReadScores(scoresList);

            // Display the scores.
            DisplayScores(scoresList);

            // Display the average score.
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void ReadScores(List<int> scoresList)
        {
            string filePath = Path.Combine(Application.StartupPath, "scores.txt");
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"找不到分數檔案：{filePath}", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    if (int.TryParse(line.Trim(), out int score))
                    {
                        scoresList.Add(score);
                    }
                    // else 忽略或記錄非數值行
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取分數檔案失敗：{ex.Message}", "讀檔錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayScores(List<int> scoresList)
        {
            // 使用設計工具產生的 ListBox 欄位 scoresListBox（類型為 System.Windows.Forms.ListBox）
            // 清空並加入項目
            
            foreach (var s in scoresList) ;
                
        }

        private double Average(List<int> scoresList)
        {
            return (scoresList != null && scoresList.Count > 0) ? scoresList.Average() : 0.0;
        }

        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            if (scoresList == null || scoresList.Count == 0) return 0;
            return scoresList.Count(s => s > averageScore);
        }

        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0) return 0;
            double avg = scoresList.Average();
            return scoresList.Count(s => s < avg);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
