namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxOilLubrication;
        private System.Windows.Forms.CheckBox checkBoxReplaceOil;
        private System.Windows.Forms.CheckBox checkBoxLubrication;

        private System.Windows.Forms.GroupBox groupBoxWash;
        private System.Windows.Forms.CheckBox checkBoxWaterWash;
        private System.Windows.Forms.CheckBox checkBoxTransmissionWash;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.CheckBox checkBoxReplaceFilter;
        private System.Windows.Forms.CheckBox checkBoxTireRepair;

        private System.Windows.Forms.GroupBox groupBoxPartsLabor;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.TextBox textBoxPartsAmount;
        private System.Windows.Forms.Label labelLaborHours;
        private System.Windows.Forms.NumericUpDown numericUpDownLaborHours;

        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelServiceAndLabor;
        private System.Windows.Forms.TextBox textBoxServiceAndLabor;
        private System.Windows.Forms.Label labelPartsSummary;
        private System.Windows.Forms.TextBox textBoxPartsSummary;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportReport;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOilLubrication = new GroupBox();
            checkBoxReplaceOil = new CheckBox();
            checkBoxLubrication = new CheckBox();
            groupBoxWash = new GroupBox();
            checkBoxWaterWash = new CheckBox();
            checkBoxTransmissionWash = new CheckBox();
            groupBoxOther = new GroupBox();
            checkBoxInspection = new CheckBox();
            checkBoxReplaceFilter = new CheckBox();
            checkBoxTireRepair = new CheckBox();
            groupBoxPartsLabor = new GroupBox();
            labelParts = new Label();
            textBoxPartsAmount = new TextBox();
            labelLaborHours = new Label();
            numericUpDownLaborHours = new NumericUpDown();
            groupBoxSummary = new GroupBox();
            labelServiceAndLabor = new Label();
            textBoxServiceAndLabor = new TextBox();
            labelPartsSummary = new Label();
            textBoxPartsSummary = new TextBox();
            labelTax = new Label();
            textBoxTax = new TextBox();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            btnExportReport = new Button();
            groupBoxOilLubrication.SuspendLayout();
            groupBoxWash.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBoxPartsLabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLaborHours).BeginInit();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOilLubrication
            // 
            groupBoxOilLubrication.Controls.Add(checkBoxReplaceOil);
            groupBoxOilLubrication.Controls.Add(checkBoxLubrication);
            groupBoxOilLubrication.Location = new Point(16, 16);
            groupBoxOilLubrication.Name = "groupBoxOilLubrication";
            groupBoxOilLubrication.Size = new Size(240, 80);
            groupBoxOilLubrication.TabIndex = 0;
            groupBoxOilLubrication.TabStop = false;
            groupBoxOilLubrication.Text = "機油和潤滑";
            // 
            // checkBoxReplaceOil
            // 
            checkBoxReplaceOil.AutoSize = true;
            checkBoxReplaceOil.Location = new Point(12, 22);
            checkBoxReplaceOil.Name = "checkBoxReplaceOil";
            checkBoxReplaceOil.Size = new Size(190, 27);
            checkBoxReplaceOil.TabIndex = 0;
            checkBoxReplaceOil.Text = "更換機油 (NT$780)";
            // 
            // checkBoxLubrication
            // 
            checkBoxLubrication.AutoSize = true;
            checkBoxLubrication.Location = new Point(12, 46);
            checkBoxLubrication.Name = "checkBoxLubrication";
            checkBoxLubrication.Size = new Size(190, 27);
            checkBoxLubrication.TabIndex = 1;
            checkBoxLubrication.Text = "潤滑保養 (NT$540)";
            // 
            // groupBoxWash
            // 
            groupBoxWash.Controls.Add(checkBoxWaterWash);
            groupBoxWash.Controls.Add(checkBoxTransmissionWash);
            groupBoxWash.Location = new Point(272, 16);
            groupBoxWash.Name = "groupBoxWash";
            groupBoxWash.Size = new Size(240, 80);
            groupBoxWash.TabIndex = 1;
            groupBoxWash.TabStop = false;
            groupBoxWash.Text = "清洗服務";
            // 
            // checkBoxWaterWash
            // 
            checkBoxWaterWash.AutoSize = true;
            checkBoxWaterWash.Location = new Point(12, 22);
            checkBoxWaterWash.Name = "checkBoxWaterWash";
            checkBoxWaterWash.Size = new Size(190, 27);
            checkBoxWaterWash.TabIndex = 0;
            checkBoxWaterWash.Text = "水箱清洗 (NT$900)";
            // 
            // checkBoxTransmissionWash
            // 
            checkBoxTransmissionWash.AutoSize = true;
            checkBoxTransmissionWash.Location = new Point(12, 46);
            checkBoxTransmissionWash.Name = "checkBoxTransmissionWash";
            checkBoxTransmissionWash.Size = new Size(222, 27);
            checkBoxTransmissionWash.TabIndex = 1;
            checkBoxTransmissionWash.Text = "變速箱清洗 (NT$2,400)";
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(checkBoxInspection);
            groupBoxOther.Controls.Add(checkBoxReplaceFilter);
            groupBoxOther.Controls.Add(checkBoxTireRepair);
            groupBoxOther.Location = new Point(16, 110);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(240, 120);
            groupBoxOther.TabIndex = 2;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "其他服務";
            // 
            // checkBoxInspection
            // 
            checkBoxInspection.AutoSize = true;
            checkBoxInspection.Location = new Point(12, 22);
            checkBoxInspection.Name = "checkBoxInspection";
            checkBoxInspection.Size = new Size(154, 27);
            checkBoxInspection.TabIndex = 0;
            checkBoxInspection.Text = "檢驗 (NT$450)";
            // 
            // checkBoxReplaceFilter
            // 
            checkBoxReplaceFilter.AutoSize = true;
            checkBoxReplaceFilter.Location = new Point(12, 46);
            checkBoxReplaceFilter.Name = "checkBoxReplaceFilter";
            checkBoxReplaceFilter.Size = new Size(222, 27);
            checkBoxReplaceFilter.TabIndex = 1;
            checkBoxReplaceFilter.Text = "更換消音器 (NT$3,000)";
            // 
            // checkBoxTireRepair
            // 
            checkBoxTireRepair.AutoSize = true;
            checkBoxTireRepair.Location = new Point(12, 70);
            checkBoxTireRepair.Name = "checkBoxTireRepair";
            checkBoxTireRepair.Size = new Size(190, 27);
            checkBoxTireRepair.TabIndex = 2;
            checkBoxTireRepair.Text = "輪胎換位 (NT$600)";
            // 
            // groupBoxPartsLabor
            // 
            groupBoxPartsLabor.Controls.Add(labelParts);
            groupBoxPartsLabor.Controls.Add(textBoxPartsAmount);
            groupBoxPartsLabor.Controls.Add(labelLaborHours);
            groupBoxPartsLabor.Controls.Add(numericUpDownLaborHours);
            groupBoxPartsLabor.Location = new Point(272, 110);
            groupBoxPartsLabor.Name = "groupBoxPartsLabor";
            groupBoxPartsLabor.Size = new Size(240, 120);
            groupBoxPartsLabor.TabIndex = 3;
            groupBoxPartsLabor.TabStop = false;
            groupBoxPartsLabor.Text = "零件和工時";
            // 
            // labelParts
            // 
            labelParts.AutoSize = true;
            labelParts.Location = new Point(12, 26);
            labelParts.Name = "labelParts";
            labelParts.Size = new Size(102, 23);
            labelParts.TabIndex = 0;
            labelParts.Text = "零件 (NT$):";
            // 
            // textBoxPartsAmount
            // 
            textBoxPartsAmount.Location = new Point(100, 22);
            textBoxPartsAmount.Name = "textBoxPartsAmount";
            textBoxPartsAmount.Size = new Size(116, 30);
            textBoxPartsAmount.TabIndex = 1;
            textBoxPartsAmount.Text = "0";
            // 
            // labelLaborHours
            // 
            labelLaborHours.AutoSize = true;
            labelLaborHours.Location = new Point(12, 60);
            labelLaborHours.Name = "labelLaborHours";
            labelLaborHours.Size = new Size(103, 23);
            labelLaborHours.TabIndex = 2;
            labelLaborHours.Text = "工時 (小時):";
            // 
            // numericUpDownLaborHours
            // 
            numericUpDownLaborHours.Location = new Point(100, 56);
            numericUpDownLaborHours.Name = "numericUpDownLaborHours";
            numericUpDownLaborHours.Size = new Size(72, 30);
            numericUpDownLaborHours.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(labelServiceAndLabor);
            groupBoxSummary.Controls.Add(textBoxServiceAndLabor);
            groupBoxSummary.Controls.Add(labelPartsSummary);
            groupBoxSummary.Controls.Add(textBoxPartsSummary);
            groupBoxSummary.Controls.Add(labelTax);
            groupBoxSummary.Controls.Add(textBoxTax);
            groupBoxSummary.Controls.Add(labelTotal);
            groupBoxSummary.Controls.Add(textBoxTotal);
            groupBoxSummary.Location = new Point(16, 246);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(496, 120);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "費用摘要";
            // 
            // labelServiceAndLabor
            // 
            labelServiceAndLabor.AutoSize = true;
            labelServiceAndLabor.Location = new Point(12, 24);
            labelServiceAndLabor.Name = "labelServiceAndLabor";
            labelServiceAndLabor.Size = new Size(100, 23);
            labelServiceAndLabor.TabIndex = 0;
            labelServiceAndLabor.Text = "服務與工資";
            // 
            // textBoxServiceAndLabor
            // 
            textBoxServiceAndLabor.Location = new Point(140, 20);
            textBoxServiceAndLabor.Name = "textBoxServiceAndLabor";
            textBoxServiceAndLabor.ReadOnly = true;
            textBoxServiceAndLabor.Size = new Size(160, 30);
            textBoxServiceAndLabor.TabIndex = 1;
            // 
            // labelPartsSummary
            // 
            labelPartsSummary.AutoSize = true;
            labelPartsSummary.Location = new Point(12, 52);
            labelPartsSummary.Name = "labelPartsSummary";
            labelPartsSummary.Size = new Size(46, 23);
            labelPartsSummary.TabIndex = 2;
            labelPartsSummary.Text = "零件";
            // 
            // textBoxPartsSummary
            // 
            textBoxPartsSummary.Location = new Point(140, 48);
            textBoxPartsSummary.Name = "textBoxPartsSummary";
            textBoxPartsSummary.ReadOnly = true;
            textBoxPartsSummary.Size = new Size(160, 30);
            textBoxPartsSummary.TabIndex = 3;
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Location = new Point(12, 80);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(99, 23);
            labelTax.TabIndex = 4;
            labelTax.Text = "稅金 (零件)";
            // 
            // textBoxTax
            // 
            textBoxTax.Location = new Point(140, 76);
            textBoxTax.Name = "textBoxTax";
            textBoxTax.ReadOnly = true;
            textBoxTax.Size = new Size(160, 30);
            textBoxTax.TabIndex = 5;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(320, 24);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(64, 23);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "總費用";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(376, 20);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(108, 30);
            textBoxTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(60, 380);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 28);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 28);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(420, 380);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 28);
            btnExit.TabIndex = 8;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnExportReport
            // 
            btnExportReport.Location = new Point(300, 380);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(100, 28);
            btnExportReport.TabIndex = 7;
            btnExportReport.Text = "匯出報表";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 420);
            Controls.Add(groupBoxOilLubrication);
            Controls.Add(groupBoxWash);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxPartsLabor);
            Controls.Add(groupBoxSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExportReport);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            Load += Form1_Load;
            groupBoxOilLubrication.ResumeLayout(false);
            groupBoxOilLubrication.PerformLayout();
            groupBoxWash.ResumeLayout(false);
            groupBoxWash.PerformLayout();
            groupBoxOther.ResumeLayout(false);
            groupBoxOther.PerformLayout();
            groupBoxPartsLabor.ResumeLayout(false);
            groupBoxPartsLabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLaborHours).EndInit();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
