﻿namespace GNRSoftware
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_CurrentGRN = new System.Windows.Forms.Label();
            this.lab_DateTime = new System.Windows.Forms.Label();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_BarCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_TotalGrnCount = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lab_grnCount = new System.Windows.Forms.Label();
            this.lab_ErrorMessage = new System.Windows.Forms.Label();
            this.pnl_Reset = new System.Windows.Forms.Panel();
            this.btn_ClosePanel = new System.Windows.Forms.Button();
            this.btn_PanelReset = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnl_Reset.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_CurrentGRN
            // 
            this.lab_CurrentGRN.AutoSize = true;
            this.lab_CurrentGRN.Location = new System.Drawing.Point(23, 48);
            this.lab_CurrentGRN.Name = "lab_CurrentGRN";
            this.lab_CurrentGRN.Size = new System.Drawing.Size(151, 30);
            this.lab_CurrentGRN.TabIndex = 0;
            this.lab_CurrentGRN.Text = "From Date: ";
            // 
            // lab_DateTime
            // 
            this.lab_DateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_DateTime.AutoSize = true;
            this.lab_DateTime.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateTime.Location = new System.Drawing.Point(25, 19);
            this.lab_DateTime.Name = "lab_DateTime";
            this.lab_DateTime.Size = new System.Drawing.Size(102, 36);
            this.lab_DateTime.TabIndex = 1;
            this.lab_DateTime.Text = "label2";
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(382, 19);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(130, 36);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_BarCode
            // 
            this.txt_BarCode.CausesValidation = false;
            this.txt_BarCode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BarCode.Location = new System.Drawing.Point(21, 170);
            this.txt_BarCode.Name = "txt_BarCode";
            this.txt_BarCode.Size = new System.Drawing.Size(491, 33);
            this.txt_BarCode.TabIndex = 1;
            this.txt_BarCode.Click += new System.EventHandler(this.txt_BarCode_Click);
            this.txt_BarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BarCode_KeyDown);
            this.txt_BarCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BarCode_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_TotalGrnCount);
            this.groupBox1.Controls.Add(this.lab_CurrentGRN);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.groupBox1.Location = new System.Drawing.Point(22, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total GRN";
            // 
            // lab_TotalGrnCount
            // 
            this.lab_TotalGrnCount.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lab_TotalGrnCount.Location = new System.Drawing.Point(28, 92);
            this.lab_TotalGrnCount.Name = "lab_TotalGrnCount";
            this.lab_TotalGrnCount.Size = new System.Drawing.Size(439, 91);
            this.lab_TotalGrnCount.TabIndex = 1;
            this.lab_TotalGrnCount.Text = "0";
            this.lab_TotalGrnCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(382, 207);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 36);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lab_grnCount
            // 
            this.lab_grnCount.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.lab_grnCount.Location = new System.Drawing.Point(50, 72);
            this.lab_grnCount.Name = "lab_grnCount";
            this.lab_grnCount.Size = new System.Drawing.Size(439, 91);
            this.lab_grnCount.TabIndex = 6;
            this.lab_grnCount.Text = "0";
            this.lab_grnCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_ErrorMessage
            // 
            this.lab_ErrorMessage.AutoSize = true;
            this.lab_ErrorMessage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lab_ErrorMessage.Location = new System.Drawing.Point(17, 207);
            this.lab_ErrorMessage.Name = "lab_ErrorMessage";
            this.lab_ErrorMessage.Size = new System.Drawing.Size(84, 28);
            this.lab_ErrorMessage.TabIndex = 7;
            this.lab_ErrorMessage.Text = "label2";
            this.lab_ErrorMessage.Visible = false;
            // 
            // pnl_Reset
            // 
            this.pnl_Reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Reset.Controls.Add(this.btn_ClosePanel);
            this.pnl_Reset.Controls.Add(this.btn_PanelReset);
            this.pnl_Reset.Controls.Add(this.txt_Password);
            this.pnl_Reset.Controls.Add(this.label1);
            this.pnl_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Reset.Location = new System.Drawing.Point(0, 0);
            this.pnl_Reset.Name = "pnl_Reset";
            this.pnl_Reset.Size = new System.Drawing.Size(530, 471);
            this.pnl_Reset.TabIndex = 8;
            this.pnl_Reset.Visible = false;
            // 
            // btn_ClosePanel
            // 
            this.btn_ClosePanel.Location = new System.Drawing.Point(309, 172);
            this.btn_ClosePanel.Name = "btn_ClosePanel";
            this.btn_ClosePanel.Size = new System.Drawing.Size(87, 31);
            this.btn_ClosePanel.TabIndex = 3;
            this.btn_ClosePanel.Text = "CLOSE";
            this.btn_ClosePanel.UseVisualStyleBackColor = true;
            this.btn_ClosePanel.Click += new System.EventHandler(this.btn_ClosePanel_Click);
            // 
            // btn_PanelReset
            // 
            this.btn_PanelReset.Location = new System.Drawing.Point(402, 172);
            this.btn_PanelReset.Name = "btn_PanelReset";
            this.btn_PanelReset.Size = new System.Drawing.Size(87, 31);
            this.btn_PanelReset.TabIndex = 2;
            this.btn_PanelReset.Text = "RESET";
            this.btn_PanelReset.UseVisualStyleBackColor = true;
            this.btn_PanelReset.Click += new System.EventHandler(this.btn_PanelReset_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(96, 142);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(393, 27);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasword: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 471);
            this.Controls.Add(this.pnl_Reset);
            this.Controls.Add(this.lab_ErrorMessage);
            this.Controls.Add(this.lab_grnCount);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_BarCode);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lab_DateTime);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GNR SOFTWARE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_Reset.ResumeLayout(false);
            this.pnl_Reset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_CurrentGRN;
        private System.Windows.Forms.Label lab_DateTime;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_BarCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_TotalGrnCount;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lab_grnCount;
        private System.Windows.Forms.Label lab_ErrorMessage;
        private System.Windows.Forms.Panel pnl_Reset;
        private System.Windows.Forms.Button btn_ClosePanel;
        private System.Windows.Forms.Button btn_PanelReset;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
    }
}

