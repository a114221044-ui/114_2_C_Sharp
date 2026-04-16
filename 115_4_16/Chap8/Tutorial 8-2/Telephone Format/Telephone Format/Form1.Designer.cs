namespace Telephone_Format
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.formatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            // 使用者輸入電話號碼的文字框
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.numberTextBox.Location = new System.Drawing.Point(92, 80); // 調整位置
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 39); // 調整大小
            this.numberTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            // 提示使用者輸入的標籤
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.instructionLabel.Location = new System.Drawing.Point(12, 20); // 調整位置
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(360, 50); // 調整大小
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "請輸入10位數字，我將格式化為電話號碼。";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatButton
            // 
            // 格式化按鈕
            this.formatButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.formatButton.Location = new System.Drawing.Point(64, 140); // 調整位置
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(120, 50); // 調整大小
            this.formatButton.TabIndex = 2;
            this.formatButton.Text = "格式化";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // exitButton
            // 
            // 離開按鈕
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.exitButton.Location = new System.Drawing.Point(200, 140); // 調整位置
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50); // 調整大小
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 表單的主要設定
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220); // 調整表單大小
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "電話號碼格式化";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Button exitButton;
    }
}

