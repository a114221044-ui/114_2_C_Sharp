namespace Test_Score_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 必要的設計工具方法 — 僅修改介面屬性（文字、字型、大小、位置、註解），未新增程式功能或事件處理邏輯。
        /// 已新增「搜尋成績」介面元件（輸入欄位、搜尋按鈕、結果顯示欄），但未綁定任何事件處理程式，請在 Form1.cs 中自行實作搜尋邏輯。
        /// 以下每個元件初始化區塊上方皆有繁體中文註解，說明該元件的變更重點與用途。
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            // 新增：搜尋相關元件（僅介面，無事件處理）
            this.searchScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchScoreButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            // 說明: 成績清單 ListBox — 使用 18pt 字型並增加高度與寬度以顯示較大字體與多筆項目
            this.testScoresListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 31;
            this.testScoresListBox.Location = new System.Drawing.Point(12, 12);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(220, 220);
            this.testScoresListBox.TabIndex = 0;
            // 
            // avgScoreDescriptionLabel
            // 
            // 說明: 平均分數說明標籤 — 文字改為繁體中文，關閉 AutoSize 並給固定高度讓文字垂直置中
            this.avgScoreDescriptionLabel.AutoSize = false;
            this.avgScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(250, 20);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(220, 35);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均分數：";
            // 
            // aboveAvgDescriptionLabel
            // 
            // 說明: 高於平均人數說明標籤 — 文字改為繁體中文，關閉 AutoSize 並給固定高度以利排版整齊
            this.aboveAvgDescriptionLabel.AutoSize = false;
            this.aboveAvgDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(250, 70);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(320, 35);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均的人數：";
            // 
            // belowAvgDescriptionLabel
            // 
            // 說明: 低於平均人數說明標籤 — 文字改為繁體中文，關閉 AutoSize 並給固定高度以利排版整齊
            this.belowAvgDescriptionLabel.AutoSize = false;
            this.belowAvgDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(250, 120);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(320, 35);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均的人數：";
            // 
            // averageLabel
            // 
            // 說明: 顯示平均值的欄位 — 保留邊框並置中顯示，尺寸調整以符合 18pt 字型與可讀性
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averageLabel.Location = new System.Drawing.Point(430, 16);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(160, 40);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAverageLabel
            // 
            // 說明: 顯示高於平均人數的欄位 — 保留邊框並置中顯示，尺寸調整以符合 18pt 字型與可讀性
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aboveAverageLabel.Location = new System.Drawing.Point(430, 66);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(160, 40);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAverageLabel
            // 
            // 說明: 顯示低於平均人數的欄位 — 保留邊框並置中顯示，尺寸調整以符合 18pt 字型與可讀性
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.belowAverageLabel.Location = new System.Drawing.Point(430, 116);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(160, 40);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchScoreDescriptionLabel
            // 
            // 說明: 搜尋欄位說明標籤 — 提示使用者輸入欲搜尋的分數（繁體中文）
            this.searchScoreDescriptionLabel.AutoSize = false;
            this.searchScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchScoreDescriptionLabel.Location = new System.Drawing.Point(250, 165);
            this.searchScoreDescriptionLabel.Name = "searchScoreDescriptionLabel";
            this.searchScoreDescriptionLabel.Size = new System.Drawing.Size(140, 35);
            this.searchScoreDescriptionLabel.TabIndex = 9;
            this.searchScoreDescriptionLabel.Text = "搜尋分數：";
            // 
            // searchTextBox
            // 
            // 說明: 搜尋輸入欄位 — 使用 18pt 字型，供使用者輸入欲搜尋的分數（介面不處理驗證或搜尋邏輯）
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchTextBox.Location = new System.Drawing.Point(400, 165);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 38);
            this.searchTextBox.TabIndex = 10;
            // 
            // searchScoreButton
            // 
            // 說明: 搜尋按鈕（僅新增介面，未綁定 Click 事件） — 文字繁體中文「搜尋」
            this.searchScoreButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchScoreButton.Location = new System.Drawing.Point(530, 162);
            this.searchScoreButton.Name = "searchScoreButton";
            this.searchScoreButton.Size = new System.Drawing.Size(100, 42);
            this.searchScoreButton.TabIndex = 11;
            this.searchScoreButton.Text = "搜尋";
            this.searchScoreButton.UseVisualStyleBackColor = true;
            // 注意：未加入 this.searchScoreButton.Click += ... 以避免在尚未實作時造成編譯錯誤
            // 
            // searchResultLabel
            // 
            // 說明: 搜尋結果顯示欄 — 若搜尋成功顯示所在位置；若失敗顯示「分數不存在」。目前為介面欄位，內容由程式邏輯填入。
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchResultLabel.Location = new System.Drawing.Point(250, 215);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(380, 48);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 初始不設定文字，由搜尋邏輯填入 ("所在位置" 或 "分數不存在")
            // 
            // getScoresButton
            // 
            // 說明: 取得成績按鈕 — 保留現有事件綁定（getScoresButton_Click），僅微調位置以配合新增搜尋欄位
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.getScoresButton.Location = new System.Drawing.Point(250, 275);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(160, 50);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            // 說明: 離開按鈕 — 保留現有事件綁定（exitButton_Click），與取得成績按鈕排成一列以利操作
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(430, 275);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 50);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 說明: 視窗標題改為繁體中文，並調整 ClientSize 與預設 Font 以配合新增與放大的控制項
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 調整高度以容納新增搜尋欄位與按鈕
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchScoreButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchScoreDescriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "成績清單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;

        // 新增：搜尋相關欄位（僅介面欄位，無實作）
        private System.Windows.Forms.Label searchScoreDescriptionLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchScoreButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

