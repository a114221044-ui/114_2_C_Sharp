namespace Coin_Toss
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
        /// 注意：此方法為設計工具自動產生之初始化程式碼。以下變更僅針對：
        /// 1) 將所有元件的 Text 屬性改為繁體中文。
        /// 2) 將元件字型設為「微軟正黑體」並且大小為 18。
        /// 3) 適度調整元件大小與相對位置以改善顯示（僅版面調整，不更動事件綁定與變數名稱）。
        /// 所有其他行為與事件綁定均維持原狀。
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            // 說明：此 ListBox 用來顯示每次擲硬幣的結果。
            // 將字型改成繁體中文常見的「微軟正黑體」，字型大小 18，使中文顯示清楚。
            // 並放大 ListBox 以容納較大的字型與多行結果。
            this.outputListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 30;
            this.outputListBox.Location = new System.Drawing.Point(20, 16);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(380, 184);
            this.outputListBox.TabIndex = 0;
            // 
            // tossButton
            // 
            // 說明：擲硬幣按鈕。將文字改為繁體中文「擲五次」，字型同為 18，並放大按鈕以利操作。
            this.tossButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tossButton.Location = new System.Drawing.Point(28, 214);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(170, 60);
            this.tossButton.TabIndex = 1;
            this.tossButton.Text = "擲五次";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            // 說明：離開按鈕。文字改為繁體中文「離開」，字型大小 18，位置置於右側與擲鈕對齊。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(232, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 說明：表單標題改為繁體中文「擲硬幣示範」，同時調整表單大小以容納放大的字型與元件。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "擲硬幣示範";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}