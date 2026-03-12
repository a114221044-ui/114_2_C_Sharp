using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] generatedNumbers = new int[5];
        private int[] winningNumbers = new int[5];
        private bool hasGenerated = false;
        private bool hasWinning = false;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            // 初始狀態：可按產生、可開啟檔案
            UpdateControlStates();
        }

        private void UpdateControlStates()
        {
            // 可根據狀態啟用/停用按鈕與其他互動
            btnGenerate.Enabled = true;
            btnOpen.Enabled = true;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // 使用基本迴圈與條件避免進階集合
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                int candidate;
                bool unique;
                do
                {
                    candidate = rnd.Next(1, 50); // 1..49
                    unique = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (generatedNumbers[j] == candidate)
                        {
                            unique = false;
                            break;
                        }
                    }
                } while (!unique);

                generatedNumbers[i] = candidate;
            }

            // 顯示於 Label 陣列
            for (int i = 0; i < lblNumbers.Length && i < generatedNumbers.Length; i++)
            {
                lblNumbers[i].Text = generatedNumbers[i].ToString();
            }

            hasGenerated = true;

            // 若已讀入開獎號碼則立即比對
            if (hasWinning)
            {
                CompareNumbersAndShow();
            }
            else
            {
                // 若尚未讀入開獎號碼，清除比對結果提示
                lblMatchCount.Text = "尚未讀入開獎號碼";
                lblMatchedNumbers.Text = "中獎號碼：";
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            ofd.Title = "選擇開獎號碼檔案 (每行一個號碼，共 5 行，範圍 1-49)";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string line;
                    int index = 0;
                    listBoxWinning.Items.Clear();

                    while ((line = sr.ReadLine()) != null && index < winningNumbers.Length)
                    {
                        string trimmed = line.Trim();
                        if (trimmed.Length == 0)
                        {
                            throw new Exception(string.Format("第 {0} 行為空白，格式錯誤。", index + 1));
                        }

                        int value;
                        if (!int.TryParse(trimmed, out value))
                        {
                            throw new Exception(string.Format("第 {0} 行內容無法轉為數字：'{1}'。", index + 1, trimmed));
                        }

                        if (value < 1 || value > 49)
                        {
                            throw new Exception(string.Format("第 {0} 行數字超出範圍（1-49）：{1}", index + 1, value));
                        }

                        // 檢查檔案內是否有重複（可視為格式錯誤）
                        for (int k = 0; k < index; k++)
                        {
                            if (winningNumbers[k] == value)
                            {
                                throw new Exception(string.Format("第 {0} 行數字與先前數字重複：{1}", index + 1, value));
                            }
                        }

                        winningNumbers[index] = value;
                        listBoxWinning.Items.Add(string.Format("第{0}個號碼: {1}", index + 1, value));
                        index++;
                    }

                    if (listBoxWinning.Items.Count != winningNumbers.Length)
                    {
                        throw new Exception(string.Format("檔案應包含 {0} 行有效號碼，目前讀到 {1} 行。", winningNumbers.Length, listBoxWinning.Items.Count));
                    }

                    hasWinning = true;
                    MessageBox.Show("開獎號碼讀取成功。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (hasGenerated)
                    {
                        CompareNumbersAndShow();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀檔錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxWinning.Items.Clear();
                hasWinning = false;
                lblMatchCount.Text = "讀檔失敗";
                lblMatchedNumbers.Text = "中獎號碼：";
            }
        }

        private void CompareNumbersAndShow()
        {
            // 計算中獎數量與列出中獎號碼
            int matchCount = 0;
            int[] matched = new int[5];
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                for (int j = 0; j < winningNumbers.Length; j++)
                {
                    if (generatedNumbers[i] == winningNumbers[j])
                    {
                        matched[matchCount] = generatedNumbers[i];
                        matchCount++;
                        break; // 每個產生號碼只計一次
                    }
                }
            }

            lblMatchCount.Text = string.Format("中{0}個號碼", matchCount);

            if (matchCount == 0)
            {
                lblMatchedNumbers.Text = "沒中獎";
            }
            else
            {
                // 組合中獎號碼字串（簡單字串處理）
                string s = "中獎號碼：";
                for (int i = 0; i < matchCount; i++)
                {
                    if (i > 0)
                    {
                        s += ", ";
                    }

                    s += matched[i].ToString();
                }

                lblMatchedNumbers.Text = s;
            }

            // 判定獎項級別（示範性）
            string prize;
            if (matchCount >= 5)
            {
                prize = "頭獎";
            }
            else if (matchCount == 4)
            {
                prize = "二獎";
            }
            else if (matchCount == 3)
            {
                prize = "三獎";
            }
            else if (matchCount == 2)
            {
                prize = "四獎（小獎）";
            }
            else
            {
                prize = "沒中獎";
            }

            // 顯示簡短訊息同時保留右側詳細顯示
            MessageBox.Show(string.Format("比對完成，{0}：{1}", lblMatchCount.Text, prize), "比對結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
