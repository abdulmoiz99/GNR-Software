namespace GNRSoftware
{
    partial class frm_Main
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_DateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lab_TotalGRNDate = new System.Windows.Forms.Label();
            this.lab_TotalGRN = new System.Windows.Forms.Label();
            this.lab_CurrentGRN = new System.Windows.Forms.Label();
            this.lab_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_DateTime
            // 
            this.lab_DateTime.AutoSize = true;
            this.lab_DateTime.Location = new System.Drawing.Point(689, 19);
            this.lab_DateTime.Name = "lab_DateTime";
            this.lab_DateTime.Size = new System.Drawing.Size(99, 13);
            this.lab_DateTime.TabIndex = 0;
            this.lab_DateTime.Text = "[Current Date Time]";
            this.lab_DateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(333, 119);
            this.txt_Barcode.MaxLength = 6;
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(100, 20);
            this.txt_Barcode.TabIndex = 1;
            this.txt_Barcode.TextChanged += new System.EventHandler(this.txt_Barcode_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(347, 172);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(30, 19);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lab_TotalGRNDate
            // 
            this.lab_TotalGRNDate.AutoSize = true;
            this.lab_TotalGRNDate.Location = new System.Drawing.Point(165, 285);
            this.lab_TotalGRNDate.Name = "lab_TotalGRNDate";
            this.lab_TotalGRNDate.Size = new System.Drawing.Size(113, 13);
            this.lab_TotalGRNDate.TabIndex = 4;
            this.lab_TotalGRNDate.Text = "Total GRN from [Date]";
            // 
            // lab_TotalGRN
            // 
            this.lab_TotalGRN.AutoSize = true;
            this.lab_TotalGRN.Location = new System.Drawing.Point(168, 316);
            this.lab_TotalGRN.Name = "lab_TotalGRN";
            this.lab_TotalGRN.Size = new System.Drawing.Size(68, 13);
            this.lab_TotalGRN.TabIndex = 5;
            this.lab_TotalGRN.Text = "[Total Count]";
            // 
            // lab_CurrentGRN
            // 
            this.lab_CurrentGRN.AutoSize = true;
            this.lab_CurrentGRN.Location = new System.Drawing.Point(354, 68);
            this.lab_CurrentGRN.Name = "lab_CurrentGRN";
            this.lab_CurrentGRN.Size = new System.Drawing.Size(41, 13);
            this.lab_CurrentGRN.TabIndex = 6;
            this.lab_CurrentGRN.Text = "[Count]";
            // 
            // lab_Error
            // 
            this.lab_Error.AutoSize = true;
            this.lab_Error.ForeColor = System.Drawing.Color.Red;
            this.lab_Error.Location = new System.Drawing.Point(333, 142);
            this.lab_Error.Name = "lab_Error";
            this.lab_Error.Size = new System.Drawing.Size(100, 13);
            this.lab_Error.TabIndex = 7;
            this.lab_Error.Text = "GRN already exists!";
            this.lab_Error.Visible = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Error);
            this.Controls.Add(this.lab_CurrentGRN);
            this.Controls.Add(this.lab_TotalGRN);
            this.Controls.Add(this.lab_TotalGRNDate);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.lab_DateTime);
            this.Name = "frm_Main";
            this.Text = "GRN Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_DateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lab_TotalGRNDate;
        private System.Windows.Forms.Label lab_TotalGRN;
        private System.Windows.Forms.Label lab_CurrentGRN;
        private System.Windows.Forms.Label lab_Error;
    }
}

