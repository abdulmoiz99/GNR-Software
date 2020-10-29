using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GNRSoftware
{
    public partial class Form1 : Form
    {
        int grnCount = 0, totalGrnCount = 0;
        List<string> barcodeList = new List<string>();
        List<string> tempBarcodeList = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateCount()
        {
            grnCount++;
            totalGrnCount++;
            lab_grnCount.Text = grnCount.ToString();
            lab_TotalGrnCount.Text = totalGrnCount.ToString();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Excel files (.xlsx)|.xlsx";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Export Excel File To";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    string path = saveDlg.FileName;
                    using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {

                        IWorkbook workbook = new XSSFWorkbook();

                        ISheet sheet1 = workbook.CreateSheet("Barcode");


                        for (int rowIndex = 0; rowIndex < tempBarcodeList.Count; rowIndex++)
                        {
                            IRow row = sheet1.CreateRow(rowIndex);
                            row.CreateCell(0).SetCellValue(rowIndex + 1);
                            row.CreateCell(1).SetCellValue(barcodeList[rowIndex]);
                        }
                        workbook.Write(fs);
                    }
                    grnCount = 0;
                    File.Delete(Application.StartupPath + "\\temp.dat");
                    lab_grnCount.Text = grnCount.ToString();
                    lab_TotalGrnCount.Text = totalGrnCount.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }

            SetFocus();
        }
        private void InitializeSoftware()
        {
            try
            {
                var lines = File.ReadAllLines(Application.StartupPath + "\\data.dat");
                foreach (var line in lines)
                {
                    barcodeList.Add(line.Split(',')[0]);
                    totalGrnCount++;
                }
                var templines = File.ReadAllLines(Application.StartupPath + "\\temp.dat");
                foreach (var line in templines)
                {
                    tempBarcodeList.Add(line.Split(',')[0]);
                    grnCount++;
                }
            }
            catch (Exception)
            {
            }
        }
        private void DownloadTotalGRN()
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Excel files (.xlsx)|.xlsx";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Export Excel File To";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    string path = saveDlg.FileName;
                    using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {

                        IWorkbook workbook = new XSSFWorkbook();

                        ISheet sheet1 = workbook.CreateSheet("Barcode");


                        for (int rowIndex = 0; rowIndex < barcodeList.Count; rowIndex++)
                        {
                            IRow row = sheet1.CreateRow(rowIndex);
                            row.CreateCell(0).SetCellValue(rowIndex + 1);
                            row.CreateCell(1).SetCellValue(barcodeList[rowIndex]);
                        }

                        workbook.Write(fs);
                    }
                    File.Delete(Application.StartupPath + "\\data.dat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        private static void AddBarCodeToFile(string barcode)
        {
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\data.dat"))
            {
                sw.WriteLine(barcode);
            }
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\temp.dat"))
            {
                sw.WriteLine(barcode);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeSoftware();
            lab_grnCount.Text = grnCount.ToString();
            lab_TotalGrnCount.Text = totalGrnCount.ToString();
            SetFocus();
            if (File.Exists(Application.StartupPath + "\\load.config"))
            {
                string config = File.ReadAllText(Application.StartupPath + "\\load.config");
                lab_CurrentGRN.Text = config;

            }
            else
            {
                //Get current date //Save config
                lab_CurrentGRN.Text = "From Date: " + DateTime.Now.ToShortDateString();

                using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\load.config", false))
                {
                    sw.WriteLine(lab_CurrentGRN.Text);
                }
            }
        }

        private void txt_BarCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                lab_ErrorMessage.Visible = true;
                if (barcodeList.Contains(txt_BarCode.Text))
                {
                    lab_ErrorMessage.ForeColor = Color.Red;
                    lab_ErrorMessage.Text = txt_BarCode.Text + "-Already Exist";
                }
                else if (txt_BarCode.TextLength != 6)
                {
                    lab_ErrorMessage.ForeColor = Color.Red;
                    lab_ErrorMessage.Text = txt_BarCode.Text + "-Invalid Length";
                }
                else
                {
                    barcodeList.Add(txt_BarCode.Text);
                    tempBarcodeList.Add(txt_BarCode.Text);
                    AddBarCodeToFile(txt_BarCode.Text);
                    UpdateCount();
                    lab_ErrorMessage.ForeColor = Color.LimeGreen;
                    lab_ErrorMessage.Text = txt_BarCode.Text + " Accepted";
                }
                txt_BarCode.SelectAll();
            }
        }
        private void txt_BarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Random generator = new Random();
            //String r = "";
            //Cursor.Current = Cursors.WaitCursor;
            //for (int i = 0; i < 50000; i++)
            //{
            //    using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\data.dat"))
            //    {
            //        //FORMAT  barcode , bit 

            //        //if bit  = 0  :       == false else true
            //        r = generator.Next(0, 999999).ToString("D6");
            //        sw.WriteLine(r);
            //    }
            //}
            //Cursor.Current = Cursors.Default;
            txt_Password.Focus();
            pnl_Reset.Visible = true;
            //SetFocus();

        }
        private void txt_BarCode_Click(object sender, EventArgs e)
        {
            SetFocus();
        }
        private void SetFocus()
        {
            txt_BarCode.Focus();
            txt_BarCode.SelectAll();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\load.config", false))
            {
                sw.WriteLine(lab_CurrentGRN.Text);
            }
        }
        private void btn_ClosePanel_Click(object sender, EventArgs e)
        {
            pnl_Reset.Visible = false;
            txt_Password.Clear();
            SetFocus();
        }
        private void btn_PanelReset_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password123")
            {
                try
                {
                    pnl_Reset.Visible = false;
                    txt_Password.Clear();
                    DownloadTotalGRN();

                    grnCount = 0;
                    totalGrnCount = 0;
                    lab_grnCount.Text = grnCount.ToString();
                    lab_TotalGrnCount.Text = totalGrnCount.ToString();

                    lab_CurrentGRN.Text = "From Date: " + DateTime.Now.ToShortDateString();
                    using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\load.config", false))
                    {
                        sw.WriteLine(lab_CurrentGRN.Text);
                    }

                    MessageBox.Show("Reset Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SetFocus();
                }
            }
            else MessageBox.Show("Incorrect Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '●';
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lab_DateTime.Text = DateTime.Now.ToString();
        }
    }
}
