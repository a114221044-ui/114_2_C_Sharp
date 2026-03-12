using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private IContainer components = null;
        private Label[] lblNumbers;
        private Button btnGenerate;
        private Button btnOpen;
        private Button btnExit;
        private ListBox listBoxWinning;
        private Label lblResultTitle;
        private Label lblMatchCount;
        private Label lblMatchedNumbers;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Initialize form properties
            this.components = new Container();
            this.ClientSize = new Size(800, 450);
            this.Text = "樂透號碼產生器";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize label array for numbers (5 labels)
            this.lblNumbers = new Label[5];
            Font numberFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            int startX = 30;
            int startY = 20;
            int gapX = 140;
            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label
                {
                    Font = numberFont,
                    Size = new Size(100, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(startX + i * gapX, startY),
                    Text = ""
                };
                this.lblNumbers[i] = lbl;
                this.Controls.Add(lbl);
            }

            // Initialize buttons
            this.btnGenerate = new Button
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Size = new Size(140, 50),
                Location = new Point(30, 100),
                Text = "產生號碼"
            };
            this.btnGenerate.Click += new EventHandler(this.BtnGenerate_Click);
            this.Controls.Add(this.btnGenerate);

            this.btnOpen = new Button
            {
                Font = new Font("Microsoft Sans Serif", 12F),
                Size = new Size(140, 50),
                Location = new Point(190, 100),
                Text = "開獎號碼"
            };
            this.btnOpen.Click += new EventHandler(this.BtnOpen_Click);
            this.Controls.Add(this.btnOpen);

            this.btnExit = new Button
            {
                Font = new Font("Microsoft Sans Serif", 12F),
                Size = new Size(140, 50),
                Location = new Point(350, 100),
                Text = "離開"
            };
            this.btnExit.Click += new EventHandler(this.BtnExit_Click);
            this.Controls.Add(this.btnExit);

            // Initialize ListBox for showing file read results
            this.listBoxWinning = new ListBox
            {
                Font = new Font("Microsoft Sans Serif", 12F),
                Location = new Point(30, 170),
                Size = new Size(420, 200)
            };
            this.Controls.Add(this.listBoxWinning);

            // Initialize result area labels (on the right)
            this.lblResultTitle = new Label
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(480, 170),
                Text = "比對結果："
            };
            this.Controls.Add(this.lblResultTitle);

            this.lblMatchCount = new Label
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular),
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(480, 220),
                Text = "中0個號碼"
            };
            this.Controls.Add(this.lblMatchCount);

            this.lblMatchedNumbers = new Label
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular),
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(480, 270),
                Text = "中獎號碼："
            };
            this.Controls.Add(this.lblMatchedNumbers);
        }

        #endregion
    }
}
