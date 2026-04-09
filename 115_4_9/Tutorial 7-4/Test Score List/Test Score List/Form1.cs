using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 內部結構：代表一筆成績（學號 + 分數）
        private struct ScoreEntry
        {
            public string Id;
            public int Score;

            public override string ToString()
            {
                return string.IsNullOrWhiteSpace(Id) ? Score.ToString() : string.Format("{0} {1}", Id, Score);
            }
        }

        // 將成績清單儲存為欄位，以便搜尋使用
        private List<ScoreEntry> scoresList = new List<ScoreEntry>();

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // Clear and Read scores into 欄位
            scoresList.Clear();
            ReadScores();

            // Display the scores.
            DisplayScores(scoresList);

            // Display the average score.
            double averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            int numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            int numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 嘗試在多個位置尋找檔案（包括向上父資料夾與 bin\Debug）
        private string FindFile(string fileName)
        {
            var dir = new DirectoryInfo(Application.StartupPath);
            for (int i = 0; i < 8 && dir != null; i++)
            {
                string candidate = Path.Combine(dir.FullName, fileName);
                if (File.Exists(candidate)) return candidate;

                string candidateBinDebug = Path.Combine(dir.FullName, "bin", "Debug", fileName);
                if (File.Exists(candidateBinDebug)) return candidateBinDebug;

                dir = dir.Parent;
            }

            // 最後嘗試直接在啟動目錄
            string fallback = Path.Combine(Application.StartupPath, fileName);
            return File.Exists(fallback) ? fallback : null;
        }

        // ReadScores 會填入 this.scoresList，支援 "學號 分數" 與單一分數一行格式
        private void ReadScores()
        {
            string[] tryNames = new[] { "scores.txt", "TestScores.txt" };
            string filePath = null;
            foreach (var name in tryNames)
            {
                filePath = FindFile(name);
                if (!string.IsNullOrEmpty(filePath)) break;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("找不到分數檔案（scores.txt 或 TestScores.txt）。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (var rawLine in File.ReadLines(filePath))
                {
                    if (string.IsNullOrWhiteSpace(rawLine)) continue;

                    // 以空白或 tab 分割 tokens（支援一個或多個空白）
                    var tokens = rawLine.Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (tokens.Length >= 2)
                    {
                        // 分數通常為最後一個 token，學號為其餘連接
                        string scoreToken = tokens[tokens.Length - 1];
                        string id = string.Join(" ", tokens.Take(tokens.Length - 1));

                        if (int.TryParse(scoreToken, out int score))
                        {
                            scoresList.Add(new ScoreEntry { Id = id, Score = score });
                        }
                        // 無法解析則跳過該行
                    }
                    else
                    {
                        // 若只有一個 token，嘗試當作單獨分數（沒有學號）
                        if (tokens.Length == 1 && int.TryParse(tokens[0], out int scoreOnly))
                        {
                            scoresList.Add(new ScoreEntry { Id = string.Empty, Score = scoreOnly });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("讀取分數檔案失敗：{0}", ex.Message), "讀檔錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void DisplayScores(List<ScoreEntry> list)
        {
            testScoresListBox.Items.Clear();

            foreach (var entry in list)
            {
                testScoresListBox.Items.Add(entry.ToString());
            }
        }

        private double Average(List<ScoreEntry> list)
        {
            return (list != null && list.Count > 0) ? list.Average(e => e.Score) : 0.0;
        }

        private int AboveAverage(List<ScoreEntry> list, double averageScore)
        {
            if (list == null || list.Count == 0) return 0;
            return list.Count(s => s.Score > averageScore);
        }

        private int BelowAverage(List<ScoreEntry> list)
        {
            if (list == null || list.Count == 0) return 0;
            double avg = list.Average(e => e.Score);
            return list.Count(s => s.Score < avg);
        }

        // 搜尋按鈕事件：若尚未讀入，會自動尋找並讀入 scores/TestScores；支援以學號或分數搜尋
        private void searchScoreButton_Click(object sender, EventArgs e)
        {
            // 若尚未載入，嘗試讀取
            if (scoresList == null || scoresList.Count == 0)
            {
                ReadScores();
                DisplayScores(scoresList);
            }

            var query = (searchTextBox.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(query))
            {
                searchResultLabel.Text = "請輸入學號或分數";
                return;
            }

            // 若為數字，搜尋分數相等的學生
            if (int.TryParse(query, out int qScore))
            {
                var matches = scoresList
                    .Select((entry, index) => new { Entry = entry, Index = index })
                    .Where(x => x.Entry.Score == qScore)
                    .ToList();

                if (matches.Count == 0)
                {
                    searchResultLabel.Text = "分數不存在";
                    testScoresListBox.ClearSelected();
                    return;
                }

                // 選取第一個並捲動到該位置，顯示總數與第一個索引（1-based）
                int firstIndex = matches[0].Index;
                testScoresListBox.ClearSelected();
                if (firstIndex >= 0 && firstIndex < testScoresListBox.Items.Count)
                {
                    testScoresListBox.SelectedIndex = firstIndex;
                    testScoresListBox.TopIndex = firstIndex;
                }

                searchResultLabel.Text = string.Format("找到 {0} 筆，第一筆位置：{1}", matches.Count, firstIndex + 1);
                return;
            }

            // 否則以學號精準比對（不區分大小寫）
            var idMatches = scoresList
                .Select((entry, index) => new { Entry = entry, Index = index })
                .Where(x => !string.IsNullOrWhiteSpace(x.Entry.Id) &&
                            string.Equals(x.Entry.Id, query, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (idMatches.Count == 0)
            {
                searchResultLabel.Text = "學號不存在";
                testScoresListBox.ClearSelected();
                return;
            }

            int firstIdx = idMatches[0].Index;
            testScoresListBox.ClearSelected();
            if (firstIdx >= 0 && firstIdx < testScoresListBox.Items.Count)
            {
                testScoresListBox.SelectedIndex = firstIdx;
                testScoresListBox.TopIndex = firstIdx;
            }

            searchResultLabel.Text = string.Format("找到 {0} 筆，第一筆位置：{1}", idMatches.Count, firstIdx + 1);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
