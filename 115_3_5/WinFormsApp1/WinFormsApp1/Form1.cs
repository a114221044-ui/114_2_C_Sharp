using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 服務價格常數
        private const decimal PRICE_REPLACE_OIL = 780m;
        private const decimal PRICE_LUBRICATION = 540m;
        private const decimal PRICE_WATER_WASH = 900m;
        private const decimal PRICE_TRANSMISSION_WASH = 2400m;
        private const decimal PRICE_INSPECTION = 450m;
        private const decimal PRICE_REPLACE_FILTER = 3000m;
        private const decimal PRICE_TIRE_REPAIR = 600m;

        // 其他設定
        private const decimal LABOR_HOURLY_RATE = 1620m; // 每小時人工費（可修改）
        private const decimal PARTS_TAX_RATE = 0.06m;    // 零件稅率 6%

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(textBoxPartsAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal partsAmount) &&
                partsAmount >= 0))
            {
                MessageBox.Show("請輸入正確的零件金額（數字，>= 0）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPartsAmount.Focus();
                return;
            }

            int laborHours = (int)numericUpDownLaborHours.Value;

            decimal servicesTotal = 0m;
            if (checkBoxReplaceOil.Checked) servicesTotal += PRICE_REPLACE_OIL;
            if (checkBoxLubrication.Checked) servicesTotal += PRICE_LUBRICATION;
            if (checkBoxWaterWash.Checked) servicesTotal += PRICE_WATER_WASH;
            if (checkBoxTransmissionWash.Checked) servicesTotal += PRICE_TRANSMISSION_WASH;
            if (checkBoxInspection.Checked) servicesTotal += PRICE_INSPECTION;
            if (checkBoxReplaceFilter.Checked) servicesTotal += PRICE_REPLACE_FILTER;
            if (checkBoxTireRepair.Checked) servicesTotal += PRICE_TIRE_REPAIR;

            decimal laborTotal = laborHours * LABOR_HOURLY_RATE;
            decimal serviceAndLabor = servicesTotal + laborTotal;

            decimal tax = Math.Round(partsAmount * PARTS_TAX_RATE, 0);
            decimal total = serviceAndLabor + partsAmount + tax;

            textBoxServiceAndLabor.Text = FormatCurrency(serviceAndLabor);
            textBoxPartsSummary.Text = FormatCurrency(partsAmount);
            textBoxTax.Text = FormatCurrency(tax);
            textBoxTotal.Text = FormatCurrency(total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清除所有輸入與結果
            checkBoxReplaceOil.Checked = false;
            checkBoxLubrication.Checked = false;
            checkBoxWaterWash.Checked = false;
            checkBoxTransmissionWash.Checked = false;
            checkBoxInspection.Checked = false;
            checkBoxReplaceFilter.Checked = false;
            checkBoxTireRepair.Checked = false;

            textBoxPartsAmount.Text = "0";
            numericUpDownLaborHours.Value = 0;

            textBoxServiceAndLabor.Text = string.Empty;
            textBoxPartsSummary.Text = string.Empty;
            textBoxTax.Text = string.Empty;
            textBoxTotal.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            // 確保先計算
            btnCalculate.PerformClick();

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "匯出費用報表";
                dlg.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                dlg.FileName = "RepairReport.txt";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("=== 汽車維修服務 報表 ===");
                    sb.AppendLine($"列印時間: {DateTime.Now}");
                    sb.AppendLine();

                    sb.AppendLine("已選服務：");
                    if (checkBoxReplaceOil.Checked) sb.AppendLine($" - 更換機油: {FormatCurrency(PRICE_REPLACE_OIL)}");
                    if (checkBoxLubrication.Checked) sb.AppendLine($" - 潤滑保養: {FormatCurrency(PRICE_LUBRICATION)}");
                    if (checkBoxWaterWash.Checked) sb.AppendLine($" - 水箱清洗: {FormatCurrency(PRICE_WATER_WASH)}");
                    if (checkBoxTransmissionWash.Checked) sb.AppendLine($" - 變速箱清洗: {FormatCurrency(PRICE_TRANSMISSION_WASH)}");
                    if (checkBoxInspection.Checked) sb.AppendLine($" - 檢驗: {FormatCurrency(PRICE_INSPECTION)}");
                    if (checkBoxReplaceFilter.Checked) sb.AppendLine($" - 更換消音器: {FormatCurrency(PRICE_REPLACE_FILTER)}");
                    if (checkBoxTireRepair.Checked) sb.AppendLine($" - 輪胎換位: {FormatCurrency(PRICE_TIRE_REPAIR)}");
                    sb.AppendLine();

                    sb.AppendLine($"零件 (NT$): {textBoxPartsSummary.Text}");
                    sb.AppendLine($"稅金 (零件): {textBoxTax.Text}");
                    sb.AppendLine($"服務與工資: {textBoxServiceAndLabor.Text}");
                    sb.AppendLine($"總費用: {textBoxTotal.Text}");
                    sb.AppendLine();
                    sb.AppendLine("謝謝您使用我們的服務。");

                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("報表已匯出。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"匯出時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string FormatCurrency(decimal amount)
        {
            // 以 NT$ 顯示，整數位格式
            return string.Format(CultureInfo.InvariantCulture, "NT${0:N0}", amount);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
