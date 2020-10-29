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

            using (SLDocument sl = new SLDocument())
            {
               // sl.SetCellValue("A1", 0);
                for (int i = 1; i <= barcodeList.Count; i++)
                {
                }
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
                        sl.SaveAs(path);
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

            txt_BarCode.Focus();
            txt_BarCode.SelectAll();
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
            }
            catch (Exception)
            {
            }
        }
        private static void AddBarCodeToFile(string barcode)
        {
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\data.dat"))
            {
                //FORMAT  barcode , bit 

                //if bit  = 0  :  reset == false else true
                sw.WriteLine(barcode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSoftware();
            lab_grnCount.Text = grnCount.ToString();
            lab_TotalGrnCount.Text = totalGrnCount.ToString();
            txt_BarCode.Focus();
            txt_BarCode.SelectAll();

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

            lab_CurrentGRN.Text = "From Date: " + DateTime.Now.ToShortDateString();

            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\load.config", false))
            {
                sw.WriteLine(lab_CurrentGRN.Text);
            }
            grnCount = 0;
            totalGrnCount = 0;

            lab_grnCount.Text = grnCount.ToString();
            lab_TotalGrnCount.Text = totalGrnCount.ToString();

            File.Delete(Application.StartupPath + "\\data.dat");

            barcodeList.Clear();

            txt_BarCode.Focus();
            txt_BarCode.SelectAll();
        }


        private void txt_BarCode_Click(object sender, EventArgs e)
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

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lab_DateTime.Text = DateTime.Now.ToString();
        }
    }
}



//Random generator = new Random();
//String r = "";
//Cursor.Current = Cursors.WaitCursor;
//            for (int i = 0; i< 10000000; i++)
//            {
//                using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\data.dat"))
//                {
//                    //FORMAT  barcode , bit 

//                    //if bit  = 0  :  reset == false else true
//                    r = generator.Next(0, 999999).ToString("D6");
//sw.WriteLine(r);
//                }
//            }
//            Cursor.Current = Cursors.Default;