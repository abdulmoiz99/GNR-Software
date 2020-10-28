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
    public partial class frm_Main : Form
    {
        List<string> GRNList = new List<string>();

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            LoadConfig();
            SetCurrentDateTime();
        }

        private void LoadGRN() 
        {
            //Pending...
        }

        private void LoadConfig()
        {
            if (File.Exists(Application.StartupPath + "\\load.config"))
            {
                string[] config = File.ReadAllLines(Application.StartupPath + "\\load.config");
                SetCurrentGRN(Convert.ToInt32(config[0]));
                SetTotalGRN(Convert.ToInt32(config[1]));
                SetLastDate(config[2]);
            }
            else 
            {
                SetCurrentGRN(0);
                SetTotalGRN(0);
                SetLastDate();
                SaveConfig();
            }         
        }

        private void SaveConfig() 
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\load.config", false)) 
            {
                sw.WriteLine(lab_CurrentGRN.Text);
                sw.WriteLine(lab_TotalGRN.Text);
                sw.WriteLine(lab_TotalGRNDate.Text);
            }
        }

        private void SetCurrentDateTime()
        {
            lab_DateTime.Text = DateTime.Now.ToString("hh:mm:ss tt\n\ndd MMMM yyyy\n\ndddd");
        }

        private void SetLastDate()
        {
            lab_TotalGRNDate.Text = "Total GRN from " + DateTime.Now.ToShortDateString();
        }

        private void SetLastDate(string date)
        {
            lab_TotalGRNDate.Text = date;
        }

        private void SetCurrentGRN(int count) 
        {
            lab_CurrentGRN.Text = count.ToString();
        }

        private void SetTotalGRN(int count)
        {
            lab_TotalGRN.Text = count.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SetCurrentDateTime();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            SetLastDate();
            SetTotalGRN(0);
            txt_Barcode.Focus();
            txt_Barcode.SelectAll();
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
            lab_Error.Visible = false;

            if (txt_Barcode.TextLength == txt_Barcode.MaxLength) 
            {
                if (!GRNList.Contains(txt_Barcode.Text))
                {
                    GRNList.Add(txt_Barcode.Text);
                    SetCurrentGRN(Convert.ToInt32(lab_CurrentGRN.Text) + 1);
                    SetTotalGRN(Convert.ToInt32(lab_TotalGRN.Text) + 1);
                }
                else 
                {
                    lab_Error.Visible = true;
                }

                txt_Barcode.SelectAll();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SetCurrentGRN(0);
            txt_Barcode.Focus();
            txt_Barcode.SelectAll();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}
