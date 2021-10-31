
namespace ArrayPractice
{
    partial class MonthConverter
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
            this.btnDisplayMonth = new System.Windows.Forms.Button();
            this.txtMonthNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplayMonth
            // 
            this.btnDisplayMonth.Location = new System.Drawing.Point(121, 75);
            this.btnDisplayMonth.Name = "btnDisplayMonth";
            this.btnDisplayMonth.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayMonth.TabIndex = 0;
            this.btnDisplayMonth.Text = "Display Month";
            this.btnDisplayMonth.UseVisualStyleBackColor = true;
            this.btnDisplayMonth.Click += new System.EventHandler(this.btnDisplayMonth_Click);
            // 
            // txtMonthNumber
            // 
            this.txtMonthNumber.Location = new System.Drawing.Point(121, 40);
            this.txtMonthNumber.Name = "txtMonthNumber";
            this.txtMonthNumber.Size = new System.Drawing.Size(38, 20);
            this.txtMonthNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month#:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month Name:";
            // 
            // lblMonthName
            // 
            this.lblMonthName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthName.Location = new System.Drawing.Point(121, 113);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(100, 23);
            this.lblMonthName.TabIndex = 4;
            // 
            // MonthConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 177);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonthNumber);
            this.Controls.Add(this.btnDisplayMonth);
            this.Name = "MonthConverter";
            this.Text = "Month Number to Name Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayMonth;
        private System.Windows.Forms.TextBox txtMonthNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonthName;
    }
}

