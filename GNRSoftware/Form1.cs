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
        List<string> GRNList = new List<string>();

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
        }
        private void InitializeSoftware()
        {
            try
            {

                using (var reader = new StreamReader(Application.StartupPath + @"\data.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        string value = line[1].ToString();
                        if (value == "0")
                        {
                            barcodeList.Add(line[0].ToString());
                            totalGrnCount++;
                        }
                    }
                }

            }
            catch (Exception)
            {
            }
        }
        private static void AddBarCodeToFile(string barcode)
        {
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\data.csv"))
            {
                //FORMAT  barcode , bit , date
                //if bit  = 0  :  reset == false else true
                sw.WriteLine(barcode + ",0," + DateTime.Now.ToShortDateString());
            }
        }

        private void txt_BarCode_TextChanged(object sender, EventArgs e)
        {
            //string barcode = txt_BarCode.Text.Trim();
            //if (txt_BarCode.Text != "")
            //{

            //    if (barcode.Length != 6) // bar code must be of 6 digits - client requirement
            //    {
            //        lab_ErrorMessage.ForeColor = Color.Red;
            //        lab_ErrorMessage.Text = barcode + "-Invalid Barcode";
            //    }
            //    else
            //    {
            //        lab_ErrorMessage.ForeColor = Color.LimeGreen;
            //        lab_ErrorMessage.Text = barcode + " Accepted";
            //        AddBarCodeToFile(barcode);
            //        UpdateCount();
            //    }
            //}
            //txt_BarCode.Text = string.Empty;

            if (txt_BarCode.TextLength == txt_BarCode.MaxLength)
            {
                if (!GRNList.Contains(txt_BarCode.Text))
                {
                    GRNList.Add(txt_BarCode.Text);
                    AddBarCodeToFile(txt_BarCode.Text);
                    UpdateCount();
                    lab_ErrorMessage.ForeColor = Color.LimeGreen;
                    lab_ErrorMessage.Text = txt_BarCode.Text + " Accepted";
                }
                else
                {
                    lab_ErrorMessage.ForeColor = Color.Red;
                    lab_ErrorMessage.Text = txt_BarCode.Text + "-Already Exist";
                }

                txt_BarCode.SelectAll();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSoftware();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lab_DateTime.Text = DateTime.Now.ToString();
        }
    }
}
